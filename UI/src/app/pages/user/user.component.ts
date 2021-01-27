import { Component, OnInit } from '@angular/core';

/// SERVICIOS
import { UserService } from 'src/app/services/user.service';
import { UsuarioModel } from '../../models/usuario.model';
import { UsuarioInfoModel } from 'src/app/models/usuarioInfo.model';
import { throwIfEmpty } from 'rxjs/operators';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
  styleUrls: ['./user.component.css']
})
export class UserComponent implements OnInit {
  usuarios: UsuarioModel[] = [];
  cargando = false;
  constructor(private usuarioService: UserService) { }

  ngOnInit() {
      this.cargando = true;
      this.usuarioService.getUsuarios().subscribe(resp => {
        this.usuarios = resp;
        this.cargando = false;
      });

  }
  borrarUsuario(usuario: UsuarioModel, i: number) {
    Swal.fire({
      title: '¿ Esta seguro ?',
      text: `Está segura que desea borrar  a ${ usuario.nombre + ' ' + usuario.apellidos}`,
      type: 'question',
      showConfirmButton: true,
      showCancelButton:  true,
    }).then(resp => {
      if ( resp.value ) {
        this.usuarios.splice(i, 1);
        this.usuarioService.borrarUsuario(usuario.id).subscribe();
      }
    });
  }
}
