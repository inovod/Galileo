import { Component ,  OnInit} from '@angular/core';
import {FormGroup, FormControl, Validators} from '@angular/forms';
import { Router, ActivatedRoute } from '@angular/router';

import { Observable } from 'rxjs';
import Swal from 'sweetalert2';

/// SERVICIOS
import { UserService } from '../../services/user.service';

/// MODELOS
import { UsuarioModel } from '../../models/usuario.model';


@Component({
  selector: 'app-register-user',
  templateUrl: './register-user.component.html',
  styleUrls: ['./register-user.component.css']
})
export class RegisterUserComponent implements OnInit {
  usuarioModelo = new UsuarioModel();

  forma: FormGroup;

  constructor(private userService: UserService ,
              private router: Router) {

    this.forma = new FormGroup({
      // tslint:disable-next-line:object-literal-key-quotes
      'nombre': new FormControl(''),
      // tslint:disable-next-line:object-literal-key-quotes
      'apellidos': new FormControl(''),
      // tslint:disable-next-line:object-literal-key-quotes
      'email': new FormControl(''),
      // tslint:disable-next-line:object-literal-key-quotes
      'login': new FormControl(''),
      // tslint:disable-next-line:object-literal-key-quotes
      'password': new FormControl(''),
       // tslint:disable-next-line:object-literal-key-quotes
      'password2': new FormControl('')
    });

    this.forma.get('login').setValidators( [Validators.required , Validators.minLength(6) ]);
    this.forma.get('password').setValidators( [Validators.required , this.passwordValidate ]);
    this.forma.get('password2').setValidators( [Validators.required , this.passwordEquals.bind(this.forma) ]);
    this.forma.get('nombre').setValidators( [Validators.required , Validators.minLength(4)]);
    this.forma.get('apellidos').setValidators( [Validators.required , Validators.minLength(4)]);
    this.forma.get('email').setValidators( [Validators.required , Validators.pattern('[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,3}$')]);
  }
  ngOnInit() {
  }
  guardar() {
    if (this.forma.invalid) {
      return;
    }
    this.usuarioModelo = this.forma.value;
    console.log(this.usuarioModelo);
    Swal.fire({
      title: 'Espere',
      text: 'Guardando información',
      type: 'info',
      allowOutsideClick: false,
    });

    Swal.showLoading();

    let peticion: Observable<any>;

    peticion = this.userService.crearUsuario(this.usuarioModelo);

    peticion.subscribe(resp => {
      Swal.fire({
        title : this.usuarioModelo.nombre + ' ' + this.usuarioModelo.apellidos,
        text : 'Se inserto correctamente',
        type: 'success'
      }).then((result) => {
        if (result.value) {
          this.router.navigateByUrl('/ListadoUsuarios');
        }
      });
    }, (error) => {
      Swal.fire({
        title : 'Error',
        text : 'No se ha podido realizar la operacion',
        type: 'error'
      });
    });
  }
  // tslint:disable-next-line:whitespace
  passwordValidate(control: FormControl): { [ s: string]: boolean} {

    /// Controlamos que la longitud no sea mayor a 6
    if (control.value.length < 6 ) {
      return { RequiresTooShort : true };
    }

    /// Controlamos que contenga al menos un no valor alfanumerico.
    const regex = new RegExp('[^a-zA-Z0-9_]');
    if ( !regex.test(control.value)) {
      return { RequiresNonAlphanumeric : true };
    }

    /// Controlamos que contengan al menos un Diguito
    const regexDiguit = new RegExp('[0-9]');
    if ( !regexDiguit.test(control.value)) {
      return { RequiresRequiresDigit : true };
    }

    return null;
  }

  passwordEquals(control: FormControl): any {
    console.log(this);
    const forma: any = this;

    if (control.value !== forma.get('password').value) {
      return {
        noiguales: true
      };
    }
    return null;
  }



}
