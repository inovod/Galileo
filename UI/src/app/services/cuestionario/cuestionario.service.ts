import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { map } from 'rxjs/operators';
import { RequestBorrarCuestionarioModel } from 'src/app/models/cuestionario/RequestBorrarCuestionario';

@Injectable({
  providedIn: 'root'
})
export class CuestionarioService {
  /// private url = 'https://localhost:44368/api/Cuestionario';
  private url = 'https://app.metafase.com/aurora_test/api/Cuestionario';

  constructor(private http: HttpClient) { }

  borrarCuestionarios(request: RequestBorrarCuestionarioModel) {
    return this.http.post(
      `${this.url}/`, request)
      .pipe(
        map(resp => {
         return resp;
        })
      );
  }
}
