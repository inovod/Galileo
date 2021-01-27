import { Component, OnInit, ViewChildren, QueryList } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { CuestionarioSearchModel } from 'src/app/models/cuestionario/cuestionarioSearch.model';
import { NgbDate } from '@ng-bootstrap/ng-bootstrap';
import { AdminService } from 'src/app/services/admin/admin.service';
import { CuestionariolistadoService } from 'src/app/services/cuestionario/cuestionariolistado.service';
import { Observable } from 'rxjs';
import { ResCuestionarioModel } from 'src/app/models/responseDto/resCuestionario.model';
import { CuestionarioSortableDirective, SortEvent } from './cuestionario-sortable.directive';
import Swal from 'sweetalert2';
import { CuestionarioService } from 'src/app/services/cuestionario/cuestionario.service';
import { RequestBorrarCuestionarioModel } from 'src/app/models/cuestionario/RequestBorrarCuestionario';

@Component({
  selector: 'app-custionariosearch',
  templateUrl: './custionariosearch.component.html',
  styleUrls: ['./custionariosearch.component.css']
})
export class CustionariosearchComponent implements OnInit {

  forma: FormGroup;
  filter: CuestionarioSearchModel = new CuestionarioSearchModel();
  loading = false;
  cuestionario$: Observable<ResCuestionarioModel[]>;
  CuestionarioSeleccion: ResCuestionarioModel[] = [];
  total$: Observable<number>;
  @ViewChildren(CuestionarioSortableDirective) headers: QueryList<CuestionarioSortableDirective>;
  constructor(private adminService: AdminService,
              public cuestionarioListServ: CuestionariolistadoService,
              public cuestionarioServicio: CuestionarioService) {
    this.forma = new FormGroup({
      // tslint:disable-next-line:object-literal-key-quotes
      'fhasta': new FormControl('' , Validators.required),
      // tslint:disable-next-line:object-literal-key-quotes
      'fDesde': new FormControl('' , Validators.required),
      // tslint:disable-next-line:object-literal-key-quotes
      'clientes':  new FormControl('' , Validators.required)
  });
    this.cuestionarioListServ.page = 1;
    this.forma.setValue(this.filter);
  }
  onSort({column, direction}: SortEvent) {
    // resetting other headers
    this.headers.forEach(header => {
      if (header.sortable !== column) {
        header.direction = '';
      }
    });
    this.cuestionarioListServ.sortColumn = column;
    this.cuestionarioListServ.sortDirection = direction;
  }
  ngOnInit() {
    this.adminService.getClientes().subscribe(resp => {
      this.filter.clientes = resp;
    });
  }

  chekCuestSelection(event: any , cuestionario: ResCuestionarioModel ) {
    if ( event.target.checked) {
      cuestionario.seleccionado = true;
      this.CuestionarioSeleccion.push(cuestionario);
    } else {
      this.CuestionarioSeleccion.forEach((item, index) => {
        if (cuestionario.idcuestionario === item.idcuestionario) {
          this.CuestionarioSeleccion.splice(index, 1);
        }
      });
    }
  }

  borrarCuestionario() {
    Swal.fire({
      title: 'Seleccionar una fecha de baja',
      html: '<input type="date" required id="start" name="trip-start" min="2019-01-01">',
      showCancelButton: true,
      preConfirm: () => {
        const inputValue = (document.getElementById('start') as HTMLInputElement).value;
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
        const request: RequestBorrarCuestionarioModel = new RequestBorrarCuestionarioModel();
        this.CuestionarioSeleccion.forEach((item , index) => {
          request.cuestionarios.push(item.idcuestionario);
        });
        request.fechaBaja = inputValue.toString();
        let peticionBorrado: Observable<any>;
        peticionBorrado = this.cuestionarioServicio.borrarCuestionarios(request);
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

   /* Swal.fire({
      title: '¿Estás seguro?',
      text: '¡No podrás revertir esto!',
      type: 'warning',
      showCancelButton: true,
      confirmButtonColor: '#3085d6',
      cancelButtonColor: '#d33',
      confirmButtonText: 'Sí, bórralo!'
    }).then((result) => {
      if (result.value) {
        let peticionBorrado: Observable<any>;
        peticionBorrado = this.cuestionarioServicio.borrarCuestionarios(this.CuestionarioSeleccion);
        peticionBorrado.subscribe(resp => {
          Swal.fire({
            title : '',
            text : 'Se borrado correctamente',
            type: 'success'
          }).then((reborrado) => {
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
    });*/
  }

  search() {
    if (this.filter.clientes.length ===  0) {
      this.cuestionarioListServ.cuestionarioListado = [];
    } else {
      /// this.rutaListadoServ.rutasListado =  this.rutaListadoServ.getRutas(this.lstRutas);
      this.cuestionarioListServ.getCuestionario(this.forma.value).subscribe(resp => {
        this.cuestionarioListServ.cuestionarioListado = resp;
      }, error => {
        if (error.status === 404) {
          this.cuestionarioListServ.cuestionarioListado = [];
          this.cuestionarioListServ.actualizaListado();
        }
      }, () => {
        this.cuestionarioListServ.actualizaListado();
        this.cuestionario$ = this.cuestionarioListServ.getCuestionario$;
        this.total$ = this.cuestionarioListServ.total$;
      });
    }
  }

}
