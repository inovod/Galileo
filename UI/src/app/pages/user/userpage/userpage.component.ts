import { Component, ViewChildren, QueryList } from '@angular/core';
import { Observable } from 'rxjs';
import { UsuarioInfoModel } from 'src/app/models/usuarioInfo.model';
import {SortableDirective, SortEvent} from './sortable.directive';
import { UserlistadoService } from '../../../services/userlistado.service';
import { UserService } from 'src/app/services/user.service';
import { UsuarioModel } from 'src/app/models/usuario.model';
import Swal from 'sweetalert2';
import { Router, RouterLinkWithHref } from '@angular/router';

@Component({
  selector: 'app-userpage',
  templateUrl: './userpage.component.html',
  styleUrls: ['./userpage.component.css']
})
export class UserpageComponent {
  countries$: Observable<UsuarioInfoModel[]>;
  total$: Observable<number>;

  @ViewChildren(SortableDirective) headers: QueryList<SortableDirective>;

  constructor(public UsuListServ: UserlistadoService,
              private usuarioService: UserService,
              private router: Router) {

      UsuListServ.getUsuarios().subscribe(resp => {
      UsuListServ.UsuariosListado = resp;
    });
      this.countries$ = UsuListServ.countries$;
      this.total$ = UsuListServ.total$;
  }

  onSort({column, direction}: SortEvent) {
    // resetting other headers
    this.headers.forEach(header => {
      if (header.sortable !== column) {
        header.direction = '';
      }
    });
    this.UsuListServ.sortColumn = column;
    this.UsuListServ.sortDirection = direction;
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
        /// this.usuarios.splice(i, 1);
        this.usuarioService.borrarUsuario(usuario.id).subscribe( resp => {
          window.location.reload();
        });
        // tslint:disable-next-line:quotemar
      }
    });
  }
}
