import { Component, OnInit, QueryList, ViewChildren, Input } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { FilterSurtidosModel } from 'src/app/models/surtidos/filterSurtidos.model';
import { ResSurtidoModel } from 'src/app/models/responseDto/resSurtido.model';
import { Observable } from 'rxjs';
import { SurtidoSortableDirective, SortEvent } from './surtido-sortable.directive';
import { SurtidolistadoService } from 'src/app/services/surtido/surtidolistado.service';
import { AdminService } from 'src/app/services/admin/admin.service';
import { RequestSurtidoFilterModel } from '../../models/surtidos/RequestSurtidoFilter.model';
import Swal from 'sweetalert2';
import { SurtidoService } from 'src/app/services/surtido/surtido.service';
import { NavigationExtras, Router } from '@angular/router';
import { RequestBorrarSurtidoModel } from 'src/app/models/surtidos/requestBorrarSurtido.model';

@Component({
  selector: 'app-surtidosearch',
  templateUrl: './surtidosearch.component.html',
  styleUrls: ['./surtidosearch.component.css']
})
export class SurtidosearchComponent implements OnInit {

  forma: FormGroup;
  filterSurtidos: FilterSurtidosModel = new FilterSurtidosModel();
  suritdoSeleccion: ResSurtidoModel[] = [];
  loading =  false;
  surtidos$: Observable<ResSurtidoModel[]>;
  total$: Observable<number>;
  @ViewChildren(SurtidoSortableDirective) headers: QueryList<SurtidoSortableDirective>;
  constructor(public surtidoList: SurtidolistadoService,
              private adminService: AdminService,
              private surtidoServ: SurtidoService,
              private router: Router) {
    this.filterSurtidos = new FilterSurtidosModel();
    this.forma = new FormGroup({
       // tslint:disable-next-line:object-literal-key-quotes
       'fhasta': new FormControl('' , Validators.required),
       // tslint:disable-next-line:object-literal-key-quotes
       'fDesde': new FormControl('' , Validators.required),
       // tslint:disable-next-line:object-literal-key-quotes
       'clientes':  new FormControl('' , Validators.required),
        // tslint:disable-next-line:object-literal-key-quotes
       'canal':  new FormControl('' , Validators.required),
       // tslint:disable-next-line:object-literal-key-quotes
       'cadena':  new FormControl('' , Validators.required),
         // tslint:disable-next-line:object-literal-key-quotes
       'ensena':  new FormControl('' , Validators.required)
    });
    this.surtidoList.page = 1;

    // tslint:disable-next-line:no-string-literal
    this.forma.controls['canal'].valueChanges.subscribe( data => {
      if (data !== undefined) {
          this.adminService.getCadenas(data).subscribe(resp => {
            this.filterSurtidos.cadena = resp;
          });
      } else {
        this.filterSurtidos.cadena = [];
        this.filterSurtidos.ensena = [];
        this.forma.get('cadena').setValue([]);
        this.forma.get('ensena').setValue([]);
      }
    });
    // tslint:disable-next-line:no-string-literal
    this.forma.controls['cadena'].valueChanges.subscribe( data => {
      if (this.forma.get('cadena').value !== undefined) {
        if (this.filterSurtidos.cadena.length > 0) {
          this.adminService.getEnsena(this.forma.get('cadena').value).subscribe(resp => {
            this.filterSurtidos.ensena = resp;
          });
        }
      } else {
        if (data === undefined) {
          this.forma.get('ensena').setValue([]);
          this.filterSurtidos.ensena = [];
        }
      }
    });
    // tslint:disable-next-line:no-string-literal
    this.forma.controls['ensena'].valueChanges.subscribe( data => {
      /// console.log('canal' , this.forma.get('canal').value);
    });
  }

  ngOnInit() {
    this.adminService.getClientes().subscribe(resp => {
      this.filterSurtidos.clientes = resp;
    });
    this.adminService.getCanal().subscribe(resp => {
      this.filterSurtidos.canal = resp;
    });
  }

  duplicarSurtido(surtido: ResSurtidoModel) {
    const navigationExtras: NavigationExtras = {
      queryParams: {
          // tslint:disable-next-line:quotemark
          "paramSurtido": JSON.stringify(surtido) ,
      }
    };
    this.router.navigate(['/duplicadoSurtido'], navigationExtras);
  }

  chekSurtidoSelection(event: any , surtido: ResSurtidoModel ) {
    if ( event.target.checked) {
      surtido.selecionado = true;
      this.suritdoSeleccion.push(surtido);
    } else {
      this.suritdoSeleccion.forEach((item, index) => {
        if (surtido.idSurtido === item.idSurtido) {
          this.suritdoSeleccion.splice(index, 1);
        }
      });
    }
  }

 borrarSurtido() {
    Swal.fire({
      title: 'Seleccionar una fecha de baja',
      html: '<input type="date" required id="start" name="trip-start" min="2019-01-01">',
      showCancelButton: true,
      preConfirm: () => {
        let inputValue = (document.getElementById('start') as HTMLInputElement).value;
        if (inputValue === '') {
          Swal.showValidationMessage(
            `Debe introducir una fecha`
          );
        }
      }
    }).then((result) => {
      if (result.value) {
        // tslint:disable-next-line:prefer-const
        let inputValue = (document.getElementById('start') as HTMLInputElement).value;
        const request: RequestBorrarSurtidoModel = new RequestBorrarSurtidoModel();
        this.suritdoSeleccion.forEach((item , index) => {
          request.surtidos.push(item.idSurtido);
        });
        request.fechaBaja = inputValue.toString();
        let peticionBorrado: Observable<any>;
        peticionBorrado = this.surtidoServ.borrarSurtidos(request);
        peticionBorrado.subscribe(resp => {
          Swal.fire({
            title : '',
            text : 'Se borrado correctamente',
            type: 'success'
          }).then((reborrado) => {
            // forma.reset();
            this.search();
          });
        }, (error) => {
          Swal.fire({
            title : '',
            text : 'No se ha podido realizar la operación',
            type: 'error'
          });
        });
      }
    });
  }

  onSort({column, direction}: SortEvent) {
    // resetting other headers
    this.headers.forEach(header => {
      if (header.sortable !== column) {
        header.direction = '';
      }
    });
    this.surtidoList.sortColumn = column;
    this.surtidoList.sortDirection = direction;
  }
  search() {
    if (!this.forma.valid) {
      return ;
    } else {
      this.suritdoSeleccion = [];
      // this.filterSurtidos.clientes = this.forma.get('clientes').value;
      const filtro = new RequestSurtidoFilterModel();
      filtro.cliente = this.forma.get('clientes').value;
      filtro.cadena = this.forma.get('cadena').value;
      filtro.canal = this.forma.get('canal').value;
      filtro.ensema = this.forma.get('ensena').value;
      filtro.fdesde = this.forma.get('fDesde').value;
      filtro.fhasta = this.forma.get('fhasta').value;

      this.surtidoList.getSurtido(filtro).subscribe(resp => {
       this.surtidoList.surtidosListado = resp;
      }, error => {
        if (error.status === 404) {
          this.surtidoList.surtidosListado = [];
          this.surtidoList.actualizaListado();
        }
      } , () => {
        this.surtidoList.actualizaListado();
        this.surtidos$ = this.surtidoList.getSurtido$;
        this.total$ = this.surtidoList.total$;
      });
    }
   /// console.log('formu' , this.forma.value);
  }

}
