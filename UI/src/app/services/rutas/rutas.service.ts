import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { DuplicarRutasRequestModel } from 'src/app/models/rutas/duplicarRutaRequest.model';
import { map } from 'rxjs/operators';
import { DescriptionRutaModel } from 'src/app/models/rutas/descripcionRuta.model';

@Injectable({
  providedIn: 'root'
})
export class RutasService {
  private url = 'https://app.metafase.com/aurora_test/api/rutas';
/// private url = 'https://localhost:44368/api/rutas';

  constructor(private http: HttpClient) { }

  duplicarRutas(request: DuplicarRutasRequestModel) {
    return this.http.post(
      `${this.url}/DuplicarRutas`, request)
      .pipe(
        map(resp => {
         return resp;
        })
      );
  }

  updateDescription(idruta: number , descripcion: string) {
    const updateDescripcion: DescriptionRutaModel = new DescriptionRutaModel();
    updateDescripcion.descripcion = descripcion;
    updateDescripcion.idRuta = Number(idruta);
    return this.http.post(
      `${this.url}/UpdateDescription`, updateDescripcion)
      .pipe(
        map(resp => {
         return resp;
        })
      );
  }

}
