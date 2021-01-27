import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { LoginModel } from '../models/login.model';
import { UsuarioModel } from '../models/usuario.model';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

     private url = 'https://app.metafase.com/Galileo_API_DESA/api';
     private urloAuth = 'https://app.metafase.com/Galileo_API_DESA/api/oAuth';
     // private url = 'https://localhost:44368/api';
     // private urloAuth = 'https://localhost:44368/api/oAuth';
     
    // private url = 'https://localhost:44368/api';
    // private urloAuth = 'https://localhost:44368/api/oAuth';

    userToken: string;


  constructor(private http: HttpClient) {
    this.leerToken();
  }

  logOut() {
    localStorage.removeItem('token');
  }

  login(loginModel: LoginModel) {
    const authData = {
      Login: loginModel.login,
      Password : loginModel.password
    };
    return this.http.post(
     `${this.urloAuth}/SignIn`, authData)
     .pipe(
      map(resp => {
       // tslint:disable-next-line:no-string-literal
       this.guardarToken(resp['token']);
       return resp;
      })
    );
  }

  nuevoUsuario(usuario: UsuarioModel) {
    const authData = {
      UserName: usuario.email,
      Email: usuario.email,
      Password : usuario.password
    };
    return this.http.post(
     `${this.url}/user`, authData);
  }

  private guardarToken(idtoken: string) {
    this.userToken = idtoken;
    localStorage.setItem('token', idtoken);

    const hoy = new Date();
    hoy.setSeconds( 3600 );
    localStorage.setItem('expira', hoy.getTime().toString());
  }

  leerToken() {
      if ( localStorage.getItem('token')) {
        this.userToken = localStorage.getItem('token');
      } else {
        this.userToken = '';
      }
      return this.userToken;
  }
  EstaAutenticado(): boolean {

    if (this.userToken.length < 2 ) {
      return false;
    }

    const expira = Number(localStorage.getItem('expira'));
    const expiraDate = new Date();
    expiraDate.setTime(expira);

    if (expiraDate > new Date()) {
      return true;
    } else {
      return false;
    }
  }
}
