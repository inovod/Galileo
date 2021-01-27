import { Component, OnInit, ViewChildren, QueryList } from '@angular/core';
import { FormGroup, Validators, FormControl } from '@angular/forms';
import { SortEvent, VisitaSortableDirective } from './visita-sortable.directive';
import { AdminService } from 'src/app/services/admin/admin.service';
import { VisitaslistadoService } from '../../services/visitas/visitaslistado.service';
import { NavigationExtras, Router } from '@angular/router';
import { FilterVisitaModel } from 'src/app/models/visitas/filterVisita.model';
import { ResVisitaModel } from '../../models/responseDto/resVisita.model';
import { Observable } from 'rxjs';



@Component({
  selector: 'app-visitas',
  templateUrl: './visitasearch.component.html'
})
export class VisitasearchComponent implements OnInit {
  forma: FormGroup;
  filterVisitas: FilterVisitaModel = new FilterVisitaModel();
  visitaSeleccion: ResVisitaModel[] = [];
  loading =  false;
  visibleCabecera = true;
  visitas$: Observable<ResVisitaModel[]>;
  total$: Observable<number>;
  @ViewChildren(VisitaSortableDirective) headers: QueryList<VisitaSortableDirective>;
  constructor(private adminService: AdminService,
              public visitaListadoServ: VisitaslistadoService,
              private router: Router) {
    this.forma = new FormGroup({
      // tslint:disable-next-line:object-literal-key-quotes
      'fDesde': new FormControl(''),
      'fhasta': new FormControl(''),
      'clientes':  new FormControl('' , Validators.required),
      'vendedor':  new FormControl(''),
      'tienda':  new FormControl('')
    });
    this.visitaListadoServ.page = 1;
    this.forma.setValue(this.filterVisitas);
    /// this.forma.setValue(this.filter);
    // tslint:disable-next-line:no-string-literal
    this.forma.controls['clientes'].valueChanges.subscribe( data => {
      if (data !== undefined) {
          this.adminService.getVendedores(data).subscribe(resp => {
            this.filterVisitas.vendedor = resp;
          });
      } else {
        this.filterVisitas.vendedor = [];
        this.forma.get('vendedor').setValue([]);
      }
    });
    // tslint:disable-next-line:no-string-literal
    this.forma.controls['vendedor'].valueChanges.subscribe( data => {
      if (this.forma.get('vendedor').value !== undefined) {
         this.adminService.getTiendas(this.forma.get('clientes').value, this.forma.get('vendedor').value).subscribe(resp => {
           this.filterVisitas.tienda = resp;
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
    this.visitaListadoServ.sortColumn = column;
    this.visitaListadoServ.sortDirection = direction;
  }
  ngOnInit() {
    this.adminService.getClientes().subscribe(resp => {
      this.filterVisitas.clientes = resp;
    });
  }

  editRespuestas(visita: ResVisitaModel ) {
    // console.log(visita);
    const navigationExtras: NavigationExtras = {
      queryParams: {
          // tslint:disable-next-line:quotemark
          "paramVisita": JSON.stringify(visita) ,
      }
    };
    this.router.navigate(['/respuestaSearch'], navigationExtras);
  }

  chekRutaSelection(event: any , visita: ResVisitaModel ) {
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
    if (this.filterVisitas.clientes.length ===  0) {
      // this.rutaListadoServ.rutasListado = [];
      this.visitaListadoServ.visitasListado = [];
    } else {
      this.visitaListadoServ.getVisitas(this.forma.value).subscribe( resp => {
        this.visitaListadoServ.visitasListado = resp;
      } , error => {
        if (error.status === 404) {
          this.visitaListadoServ.visitasListado = [];
          this.visitaListadoServ.actualizaListado();
        }
      } , () => {
        this.visitaListadoServ.actualizaListado();
        this.visitas$ = this.visitaListadoServ.getVistas$;
        this.total$ = this.visitaListadoServ.total$;
        this.loading = false;
      });
      /* this.rutaListadoServ.getRutas(this.forma.value).subscribe(resp => {
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
      }); */
    }
  }
}
