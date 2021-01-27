import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { LoginModel } from '../../models/login.model';
import { AuthService } from '../../services/auth.service';
import Swal from 'sweetalert2';
import { Router } from '@angular/router';


@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styles: []
})
export class LoginComponent implements OnInit {

  constructor(private auth: AuthService,
              private router: Router) { }

  usuLogin = new LoginModel();
  recordarme = false;

  ngOnInit() {

    if ( localStorage.getItem('email')) {
        this.usuLogin.login = localStorage.getItem('email');
        this.recordarme = true;
    }
  }

  login(form: NgForm) {

    if ( form.invalid ) {return; }

    Swal.fire({
      allowOutsideClick: false,
      type: 'info',
      text: 'Espere por favor'
    });
    Swal.showLoading();

    this.auth.login(this.usuLogin).subscribe( resp => {
      Swal.close();
      if (this.recordarme) {
        localStorage.setItem('email', this.usuLogin.login);
      }

      this.router.navigateByUrl('/home');

    }, (err) => {
      Swal.fire({
        allowOutsideClick: false,
        type: 'error',
        title: 'Error al autenticar',
        text: 'Error de login'
      });
      console.log(err);
    });

  }
}
