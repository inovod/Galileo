import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ResSurtidoModel } from 'src/app/models/responseDto/resSurtido.model';
import { NgForm } from '@angular/forms';
import { DuplicarSurtidoModel } from 'src/app/models/surtidos/duplicarSurtidoModel';
import { AdminService } from 'src/app/services/admin/admin.service';
import { IOption } from 'ng-select';
import Swal from 'sweetalert2';
import { RequestDuplicarSurtidoModel } from 'src/app/models/surtidos/requestDuplicarSurtido.model';
import { SurtidoService } from 'src/app/services/surtido/surtido.service';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-duplicarsurtido',
  templateUrl: './duplicarsurtido.component.html',
  styleUrls: ['./duplicarsurtido.component.css']
})
export class DuplicarsurtidoComponent implements OnInit {
  surtidoRequest: ResSurtidoModel;
  itemSelectCanal: string [] = [];
  canalesModel: Array<IOption>;
  validarCanal = '';
  itemSelectCadenas: string [] = [];
  cadenasModel: Array<IOption>;
  validarCadena = '';
  itemSelectEnsena: string [] = [];
  ensenaModel: Array<IOption>;
  validarEnsena = '';

  duplicarSurtidos: DuplicarSurtidoModel = new DuplicarSurtidoModel();
  constructor(private routeActive: ActivatedRoute,
              private adminService: AdminService,
              private surtidosrv: SurtidoService) {
    this.routeActive.queryParams.subscribe(params => {
      this.surtidoRequest = JSON.parse(params["paramSurtido"]);
      console.log(this.surtidoRequest);
    });

    this.cadenasModel = [];
    this.ensenaModel = [];
    this.canalesModel = [];

  }

  ngOnInit() {
    this.adminService.getCanal().subscribe(resp => {
      this.canalesModel = resp;
    });
  }
  selectCanal(item: IOption) {
   this.cadenasModel = [];
   this.ensenaModel = [];
   this.duplicarSurtidos.canal.push(item);
   this.adminService.getCadenas(item.value).subscribe(resp => {
    this.cadenasModel = resp;
    });
   this.validarCanal = '0';
  }
  deleteCanal(item: IOption) {
    this.cadenasModel = [];
    this.duplicarSurtidos.cadenas = [];
    this.ensenaModel = [];
    this.duplicarSurtidos.ensena = [];
    this.validarCanal = '';
    this.validarCadena = '';
    this.validarEnsena = '';
    this.itemSelectCanal = [];
    this.itemSelectCadenas = [];
    this.itemSelectEnsena = [];
  }
  selectCadena(item: IOption) {
    this.validarCadena = '0';
    this.duplicarSurtidos.cadenas.push(item);
    this.adminService.getEnsenaMultiple(this.duplicarSurtidos.cadenas).subscribe(resp => {
      this.ensenaModel = resp;
    });
  }

  deleteCadena(option: IOption) {
    this.duplicarSurtidos.cadenas.forEach((item, index) => {
      if (option.value === item.value) {
        this.duplicarSurtidos.cadenas.splice(index, 1);
      }
    });
    this.itemSelectCadenas.forEach((item, index) => {
        if (option.value === item) {
          this.itemSelectCadenas.splice(index, 1);
        }
     });
    if (this.duplicarSurtidos.cadenas.length <= 0) {
      this.validarCadena = '';
    }
    if (this.duplicarSurtidos.cadenas.length > 0 ) {
      this.actualizarComboEnsena();
    } else {
      this.itemSelectEnsena = [];
      this.ensenaModel = [];
      this.duplicarSurtidos.ensena = [];
     }
  }

  selectEnsena(item: IOption) {
    this.validarEnsena = '0';
    this.duplicarSurtidos.ensena.push(item);
  }
  deleteEnsena(option: IOption) {
    this.duplicarSurtidos.ensena.forEach((item, index) => {
      if (option.value === item.value) {
        this.duplicarSurtidos.ensena.splice(index, 1);
      }
    });
    this.itemSelectEnsena.forEach((item, index) => {
        if (option.value === item) {
          this.itemSelectEnsena.splice(index, 1);
        }
     });

    if (this.duplicarSurtidos.ensena.length <= 0) {
      this.validarEnsena = '';
    }
  }

  actualizarComboEnsena() {
    // Actualizamos el combo de enseña.
    this.adminService.getEnsenaMultiple(this.duplicarSurtidos.cadenas).subscribe(resp => {
      this.ensenaModel = resp;
      this.duplicarSurtidos.ensena.forEach((item , index) => {
       const index2 =  this.ensenaModel.find( x => x.value === item.value);
       if (!index2) {
           this.duplicarSurtidos.ensena.splice(index, 1);
       }
      });
      this.itemSelectEnsena.forEach( (item, index) => {
       const index2 =  this.ensenaModel.find( x => x.value === item);
       if (!index2) {
         this.itemSelectEnsena.splice(index, 1);
       }
      });
      if (this.duplicarSurtidos.cadenas.length <= 0) {
         this.validarEnsena = '';
      }
    });
}
  guardar(forma: NgForm) {
    if (forma.invalid) {
      return;
    }
    Swal.fire({
      title: 'Espere',
      text: 'Guardando información',
      type: 'info',
      allowOutsideClick: false,
    });
    Swal.showLoading();
    const data: RequestDuplicarSurtidoModel = new RequestDuplicarSurtidoModel();
    data.cliente = this.surtidoRequest.idCliente;
    data.idsurtido = this.surtidoRequest.idSurtido;
    data.canal = this.itemSelectCanal.toString();
    this.duplicarSurtidos.cadenas.forEach((item , index) => {
      data.cadena.push(Number(item.value));
    });
    this.duplicarSurtidos.ensena.forEach((item , index) => {
      data.ensena.push(Number(item.value));
    });

    let peticionUpdate: Observable<any>;
    peticionUpdate = this.surtidosrv.duplicarSurtidos(data);
    peticionUpdate.subscribe(resp => {
      Swal.fire({
        title : '',
        text : 'Se Guardado correctamente',
        type: 'success'
      }).then((result) => {
        this.cadenasModel = [];
        this.duplicarSurtidos.cadenas = [];
        this.ensenaModel = [];
        this.duplicarSurtidos.ensena = [];
        this.validarCanal = '';
        this.validarCadena = '';
        this.validarEnsena = '';
        this.itemSelectCanal = [];
        this.itemSelectCadenas = [];
        this.itemSelectEnsena = [];
        forma.reset();
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
