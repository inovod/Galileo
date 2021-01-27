import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute} from '@angular/router';
import { ResRutasModel } from 'src/app/models/responseDto/resRutas.model';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { DuplicarRutaModel } from 'src/app/models/rutas/duplicarRuta.model';
import { AdminService } from 'src/app/services/admin/admin.service';
import { IOption } from 'ng-select';
import { DuplicarRutasRequestModel } from 'src/app/models/rutas/duplicarRutaRequest.model';
import { RutasService } from 'src/app/services/rutas/rutas.service';
import Swal from 'sweetalert2';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-duplicadorutas',
  templateUrl: './duplicadorutas.component.html',
  styleUrls: ['./duplicadorutas.component.css']
})
export class DuplicadorutasComponent implements OnInit {
  rutaselection: Array<ResRutasModel> = [];
  forma: FormGroup;
  duplicarRutas: DuplicarRutaModel = new DuplicarRutaModel();
  constructor(private routeActive: ActivatedRoute ,
              private adminService: AdminService ,
              private rutaService: RutasService ,
              private router: Router) {
    this.routeActive.queryParams.subscribe(params => {
      /// console.log(JSON.parse(params["rutasD"]));
      this.rutaselection = JSON.parse(params["rutasSelected"]).rutas;
      console.log(this.rutaselection);
    });

    this.forma = new FormGroup({
      'clientes' : new FormControl('', Validators.required) ,
      'vendedor' : new FormControl('' , Validators.required )
    });
    this.forma.setValue(this.duplicarRutas);
  }

  ngOnInit() {
    this.adminService.getClientes().subscribe(resp => {
      this.duplicarRutas.clientes = resp;
    });
  }

  selectCliente(option: IOption) {
      this.adminService.getVendedores(option.value).subscribe(resp => {
        this.duplicarRutas.vendedor = resp;
      });
  }
  deleteCliente(option: IOption) {
    this.forma.get('vendedor').setValue('');
  }
  volverListadoRutas() {

  }
  guardar() {
    if (this.forma.invalid) {
        return;
    }
    Swal.fire({
      title: 'Espere',
      text: 'Guardando información',
      type: 'info',
      allowOutsideClick: false,
    });
    Swal.showLoading();

    const request: DuplicarRutasRequestModel = new DuplicarRutasRequestModel();
    request.cliente = Number(this.forma.get('clientes').value);
    request.vendedor = Number(this.forma.get('vendedor').value);
    request.Rutas = this.rutaselection;
    let peticionUpdate: Observable<any>;
    peticionUpdate = this.rutaService.duplicarRutas(request);

    peticionUpdate.subscribe(resp => {
      Swal.fire({
        title : '',
        text : 'Se guardado correctamente',
        type: 'success'
      }).then((result) => {
        if (result.value) {
          this.router.navigateByUrl('/rutas');
        }
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
