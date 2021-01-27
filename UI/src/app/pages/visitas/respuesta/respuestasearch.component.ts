import { Component, OnInit, ViewChildren, QueryList } from '@angular/core';
import { FormGroup, Validators, FormControl } from '@angular/forms';
import { AdminService } from 'src/app/services/admin/admin.service';
import { ActivatedRoute, Router } from '@angular/router';
import { Observable } from 'rxjs';
import { FilterRespuestaModel } from 'src/app/models/visitas/filterRespuestas.model';
import { ResRespuestaModel } from 'src/app/models/responseDto/resRespuestas.model';
import { RespuestaSortableDirective, SortEvent } from './respuesta-sortable.directive';
import { RespuestaListadoService } from 'src/app/services/visitas/respuestalistado.service';
import { ResVisitaModel } from 'src/app/models/responseDto/resVisita.model';
import Swal from 'sweetalert2';
import { RespuestaService } from 'src/app/services/visitas/respuesta.service';



@Component({
  selector: 'app-respuestas',
  templateUrl: './respuestasearch.component.html'
})
export class RespuestasearchComponent implements OnInit {
  forma: FormGroup;
  visitaRequest: ResVisitaModel;
  filterRespuestas: FilterRespuestaModel = new FilterRespuestaModel();
  respuestaSeleccion: ResRespuestaModel[] = [];
  loading =  false;
  respuestaCabecera = true;
  respuestas$: Observable<ResRespuestaModel[]>;
  total$: Observable<number>;
  @ViewChildren(RespuestaSortableDirective) headers: QueryList<RespuestaSortableDirective>;
  constructor(private adminService: AdminService,
              private routeActive: ActivatedRoute,
              public respuestaListadoServ: RespuestaListadoService,
              public respuestaServ : RespuestaService,
              private router: Router) {
    this.forma = new FormGroup({
      // tslint:disable-next-line:object-literal-key-quotes
     'tipoRespuesta': new FormControl('', Validators.required),
      // tslint:disable-next-line:object-literal-key-quotes
      'surtido':  new FormControl(''),
      // tslint:disable-next-line:object-literal-key-quotes
      'visitaRespuesta':  new FormControl(''),
      // tslint:disable-next-line:object-literal-key-quotes
      'cadenaFiltro':  new FormControl(''),
     });
    this.routeActive.queryParams.subscribe(params => {
      this.visitaRequest = JSON.parse(params["paramVisita"]);
    });
    this.respuestaListadoServ.page = 1;
    this.forma.setValue(this.filterRespuestas);

  }
  onSort({column, direction}: SortEvent) {
    // resetting other headers
    this.headers.forEach(header => {
      if (header.sortable !== column) {
        header.direction = '';
      }
    });
    this.respuestaListadoServ.sortColumn = column;
    this.respuestaListadoServ.sortDirection = direction;
  }
  ngOnInit() {
    this.adminService.getTipoRespuestas().subscribe(resp => {
      this.filterRespuestas.tipoRespuesta = resp;
    });
  }

  async editRespuestas(respuesta: ResRespuestaModel ) {
    console.log(respuesta);
    const ipAPI = '//api.ipify.org?format=json';
    
    const inputValue = fetch(ipAPI)
      .then(response => response.json())
      .then(data => data.ip);

    const { value: respuestadig } = await Swal.fire({
      title: respuesta.pregunta,
      input: 'text',
      inputValue,
      showCancelButton: true,
      inputValidator: (value) => {
        if (!value) {
          return 'You need to write something!';
        }
      }
    })
    if (respuestadig) {
      // Swal.fire(`Your IP address is ${respuestadig}`);

      const peticionUpdate = this.respuestaServ.updateRespuesta(respuesta, respuestadig,this.visitaRequest.visita);
      peticionUpdate.subscribe(resp => {
        Swal.fire({
          title : '',
          text : 'Se guardado correctamente',
          type: 'success'
        }).then((result) => {
          this.search();
          /// forma.reset();
        });
      }, (error) => {
        Swal.fire({
          title : '',
          text : 'No se ha podido realizar la operación',
          type: 'error'
        });
      });

    }
  }

   borrarRespuesta(respuesta: ResRespuestaModel ) {
    console.log(this.filterRespuestas.visitaRespuesta);
    Swal.fire({
      title: '¿ Esta seguro ?',
      text: `Está segura que desea borrar  las respuesta`,
      type: 'question',
      showConfirmButton: true,
      showCancelButton:  true,
    }).then(resp => {
      if ( resp.value ) {
       this.respuestaServ.BorrarRespuesta(respuesta, '',this.visitaRequest.visita).subscribe(retorno => {
        Swal.fire({
          title : '',
          text : 'Se borrado correctamente',
          type: 'success'
        }).then((result) => {
          this.search();
          /// forma.reset();
        });

       });
      }
    });
   }

  chekRutaSelection(event: any , visita: ResRespuestaModel ) {
    /*if ( event.target.checked) {
      visita.selecionado = true;
      this.visitaSeleccion.push(visita);
    } else {
      this.visitaSeleccion.forEach((item, index) => {
        if (visita.visita === item.idruta) {
          this.rutasSeleccion.splice(index, 1);
        }
      });
    }*/
  }

  search() {
    this.loading = true;
    if (this.filterRespuestas.tipoRespuesta.length ===  0) {
      // this.rutaListadoServ.rutasListado = [];
      this.respuestaListadoServ.respuestasListado = [];
    } else {
      this.forma.get('visitaRespuesta').setValue(this.visitaRequest.visita);
      // this.forma.get('cadenaFiltro').setValue(this.visitaRequest.c);
      this.respuestaListadoServ.getRespuestas(this.forma.value).subscribe( resp => {
        this.respuestaListadoServ.respuestasListado = resp;
      } , error => {
        if (error.status === 404) {
          this.respuestaListadoServ.respuestasListado = [];
          this.respuestaListadoServ.actualizaListado();
        }
      } , () => {
        this.respuestaListadoServ.actualizaListado();
        this.respuestas$ = this.respuestaListadoServ.getRespuestas$;
        this.total$ = this.respuestaListadoServ.total$;
        this.loading = false;
      });
    }
  }
}
