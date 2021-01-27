import { Component, OnInit } from '@angular/core';
import {FormGroup, FormControl, Validators} from '@angular/forms';
import { Router, ActivatedRoute } from '@angular/router';

import { Observable } from 'rxjs';
/// SERVICIOS
import { UserService } from 'src/app/services/user.service';
import { UsuarioInfoModel } from '../../models/usuarioInfo.model';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-edit-user',
  templateUrl: './edit-user.component.html',
  styleUrls: ['./edit-user.component.css']
})
export class EditUserComponent implements OnInit {
  forma: FormGroup;
  usuarioModel = new UsuarioInfoModel();

  constructor( private userService: UserService ,
               private router: Router ,
               private routerAct: ActivatedRoute) {

    this.forma = new FormGroup({
      // tslint:disable-next-line:object-literal-key-quotes
      'id': new FormControl(''),
      // tslint:disable-next-line:object-literal-key-quotes
      'nombre': new FormControl(''),
      // tslint:disable-next-line:object-literal-key-quotes
      'apellidos': new FormControl(''),
      // tslint:disable-next-line:object-literal-key-quotes
      'email': new FormControl(''),
      // tslint:disable-next-line:object-literal-key-quotes
      'bloqueado': new FormControl(''),
    });
    const id = this.routerAct.snapshot.paramMap.get('id');
    let peticion: Observable<any>;
    peticion = this.userService.getUsario(id);

    peticion.subscribe(resp => {
      this.usuarioModel = resp;
      this.forma.setValue(this.usuarioModel);
    });

    this.forma.get('nombre').setValidators( [Validators.required , Validators.minLength(4)]);

 }

  ngOnInit() {
    console.log('ngOnIni');
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

    this.usuarioModel = this.forma.value;
    let peticionUpdate: Observable<any>;
    peticionUpdate = this.userService.actualizarUsuario(this.usuarioModel);

    peticionUpdate.subscribe(resp => {
      Swal.fire({
        title : this.usuarioModel.nombre + ' ' + this.usuarioModel.apellidos,
        text : 'Se actualizo correctamente',
        type: 'success'
      }).then((result) => {
        if (result.value) {
          this.router.navigateByUrl('/ListadoUsuarios');
        }
      });
    }, (error) => {
      Swal.fire({
        title : this.usuarioModel.nombre + ' ' + this.usuarioModel.apellidos,
        text : 'No se ha podido realizar la operación',
        type: 'error'
      });
    });
  }

}
