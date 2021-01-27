import { Component, OnInit, ViewChildren, QueryList} from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { RutasService } from '../../services/rutas/rutas.service';
import { FilterRutaModel } from '../../models/rutas/filterRuta.model';
import { Router, NavigationExtras } from '@angular/router';
import { ResRutasModel } from 'src/app/models/responseDto/resRutas.model';
import { RutaslistadoService } from 'src/app/services/rutas/rutaslistado.service';
import { AdminService } from '../../services/admin/admin.service';
import { IOption } from 'ng-select';
import { Observable } from 'rxjs';
import Swal from 'sweetalert2';
import { RutaSortableDirective, SortEvent } from './ruta-sortable.directive';

export interface ParamRutasDuplicadas {
  rutas: Array<ResRutasModel>;
}
@Component({
  selector: 'app-rutassearch',
  templateUrl: './rutassearch.component.html',
  styleUrls: ['./rutassearch.component.css']
})
export class RutassearchComponent implements OnInit  {

  forma: FormGroup;
  filterRutas: FilterRutaModel = new FilterRutaModel();
  rutasSeleccion: ResRutasModel[] = [];
  loading =  false;
  visibleCabecera = true;
  rutas$: Observable<ResRutasModel[]>;
  total$: Observable<number>;
  @ViewChildren(RutaSortableDirective) headers: QueryList<RutaSortableDirective>;
  constructor(private rutaServicio: RutasService ,
              private router: Router,
              public rutaListadoServ: RutaslistadoService ,
              private adminService: AdminService) {
    this.filterRutas = new  FilterRutaModel();
    this.forma = new FormGroup({
        // tslint:disable-next-line:object-literal-key-quotes
        'clientes': new FormControl('', Validators.required),
        // tslint:disable-next-line:object-literal-key-quotes
        'vendedor': new FormControl('', Validators.required),
        // tslint:disable-next-line:object-literal-key-quotes
        'rutasBaja': new FormControl(),
    });
    this.rutaListadoServ.page = 1;
    this.forma.setValue(this.filterRutas);
  }

  onSort({column, direction}: SortEvent) {
    // resetting other headers
    this.headers.forEach(header => {
      if (header.sortable !== column) {
        header.direction = '';
      }
    });
    this.rutaListadoServ.sortColumn = column;
    this.rutaListadoServ.sortDirection = direction;
  }

  ngOnInit() {
    /// this.rutaListadoServ.rutasListado = [];
    this.adminService.getClientes().subscribe(resp => {
      this.filterRutas.clientes = resp;
    });
    this.filterRutas.rutasBaja = false;
  }

  chekRutaSelection(event: any , ruta: ResRutasModel ) {
    if ( event.target.checked) {
      ruta.selecionado = true;
      this.rutasSeleccion.push(ruta);
    } else {
      this.rutasSeleccion.forEach((item, index) => {
        if (ruta.idruta === item.idruta) {
          this.rutasSeleccion.splice(index, 1);
        }
      });
    }
  }
  selectCliente(option: IOption) {
      this.adminService.getVendedores(option.value).subscribe(resp => {
        this.filterRutas.vendedor = resp;
      });
  }
  deleteCliente(option: IOption) {
    this.forma.get('vendedor').setValue('');
  }
  search() {
    this.loading = true;
    if (this.filterRutas.clientes.length ===  0) {
      this.rutaListadoServ.rutasListado = [];
    } else {
      this.rutaListadoServ.getRutas(this.forma.value).subscribe(resp => {
        this.rutaListadoServ.rutasListado = resp;
      }, error => {
        if (error.status === 404) {
          this.rutaListadoServ.rutasListado = [];
          this.rutaListadoServ.actualizaListado();
        }
      }, () => {

        this.rutaListadoServ.actualizaListado();
        this.rutas$ = this.rutaListadoServ.getRutas$;
        this.total$ = this.rutaListadoServ.total$;
        this.loading = false;
      });
    }
  }
  async editDescription(ruta: any ) {
    const { value: email } = await Swal.fire({
      title: 'Modificar Descripcion Ruta',
      input: 'text',
      inputPlaceholder: 'Descripcion ruta'
    });
    if (email) {
      const peticionUpdate = this.rutaServicio.updateDescription(ruta.idRuta, email);
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

  duplicarRutas() {
    // tslint:disable-next-line:one-variable-per-declaration
    const param: ParamRutasDuplicadas = {
      rutas: this.rutasSeleccion,
    };
    const navigationExtras: NavigationExtras = {
      queryParams: {
          // tslint:disable-next-line:object-literal-key-quotes
          // tslint:disable-next-line:quotemark
          "rutasSelected": JSON.stringify(param) ,
      }
    };
    this.router.navigate(['/duplicadoRutas'], navigationExtras);
  }

}
