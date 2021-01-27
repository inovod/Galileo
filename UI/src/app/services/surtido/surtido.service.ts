import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ResSurtidoModel } from 'src/app/models/responseDto/resSurtido.model';
import { map } from 'rxjs/operators';
import { RequestDuplicarSurtidoModel } from 'src/app/models/surtidos/requestDuplicarSurtido.model';
import { RequestBorrarSurtidoModel } from 'src/app/models/surtidos/requestBorrarSurtido.model';
import { FileItem } from 'src/app/models/surtidos/file-item';

@Injectable({
  providedIn: 'root'
})
export class SurtidoService {
  // private url = 'https://localhost:44368/api/Surtidos';
  private url = 'https://app.metafase.com/Galileo_API_DESA/api/Surtidos';
  constructor(private http: HttpClient) { }

  duplicarSurtidos(request: RequestDuplicarSurtidoModel) {
    return this.http.post(
      `${this.url}/DuplicarSurtidos`, request)
      .pipe(
        map(resp => {
         return resp;
        })
      );
  }
  borrarSurtidos(request: RequestBorrarSurtidoModel) {
    return this.http.post(
      `${this.url}/BorrarSurtido`, request)
      .pipe(
        map(resp => {
         return resp;
        })
      );
  }
  cargarImagenes(imagenes: FileItem[]) {
    console.log('servicio cargar' ,  imagenes);
    for (const item of imagenes) {
        item.estaSubiendo = true;
        if ( item.progreso >= 100) {
          continue;
        }
        const formData = new FormData();
        formData.append('file', item.archivo);
        return this.http.post(
          `${this.url}/SurtidoMaxivo`, formData)
          .pipe(
            map(resp => {
              item.progreso = 100;
              return resp;
            })
          );
    }
  }
}
