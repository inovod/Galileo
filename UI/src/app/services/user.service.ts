import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { map } from 'rxjs/operators';

/// Importacion de modelos
import { UsuarioModel } from '../models/usuario.model';
import { UsuarioInfoModel } from '../models/usuarioInfo.model';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  private url = 'https://app.metafase.com/aurora_test/api';

  constructor(private http: HttpClient) { }

  crearUsuario(usuario: UsuarioModel) {
    /// Esta instruccion lo que hace es eliminar de  nuestro objecto UsuarioModel la propiedas Id
    // delete usuario.id;

    const usuarioInsertData = {
      UserName: usuario.login,
      Email: usuario.email,
      Password : usuario.password,
      Nombre: usuario.nombre,
      Apellidos: usuario.apellidos
    };
    return this.http.post(
      `${this.url}/user`, usuarioInsertData)
      .pipe(
        map(resp => {
         return resp;
        })
      );
  }
  borrarUsuario(id: string) {
    console.log('borrarUsuario');
    console.log(id);
    return this.http.delete(`${this.url}/user?UserId=${id}`);
  }
  actualizarUsuario(usuario: UsuarioInfoModel) {
    return this.http.put(
      `${this.url}/user`, usuario)
      .pipe(
        map(resp => {
         return resp;
        })
      );
  }
  getUsuarios() {
    return this.http.get(`${this.url}/user/GetAllUser`)
    .pipe(
      map(resp => {
        // tslint:disable-next-line:no-string-literal
        return resp['result'];
      })
    );
  }

   getUsario(id: string) {
     return this.http.get(`${this.url}/user/GetUserById?id=${id}`)
    .pipe(
      map( this.crearArregloUsuario)
    );
  }
  private crearArregloUsuario(usuarioObj: object) {
    let usuarioModel: UsuarioInfoModel = new UsuarioInfoModel();
    // tslint:disable-next-line:no-string-literal
    usuarioModel = usuarioObj['result'];
    delete usuarioModel.appUserId;
    return usuarioModel;
  }
}
