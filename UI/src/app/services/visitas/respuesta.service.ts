import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { map } from 'rxjs/operators';
import { ResRespuestaModel } from 'src/app/models/responseDto/resRespuestas.model';
import { SetRespuestaModel } from 'src/app/models/visitas/setRespuesta.model';

@Injectable({
    providedIn: 'root'
  })
export class RespuestaService {
    // private url = 'https://localhost:44368/api/Visita';
    private url = 'https://app.metafase.com/Galileo_API_DESA/api/Visita';
    constructor(private http: HttpClient) { }

    updateRespuesta(respuesta: ResRespuestaModel, descripcion: string , rowguidVista: string) {
        const updateRespuesta: SetRespuestaModel = new SetRespuestaModel();
        updateRespuesta.respuesta = respuesta;
        updateRespuesta.ValueName = descripcion;
        updateRespuesta.rowGuidVisita = rowguidVista;
        return this.http.post(
          `${this.url}/SetVisitasRespuestas`, updateRespuesta)
          .pipe(
            map(resp => {
             return resp;
            })
          );
      }

      BorrarRespuesta(respuesta: ResRespuestaModel , descripcion: string,rowguidVista: string) {
        const updateRespuesta: SetRespuestaModel = new SetRespuestaModel();
        updateRespuesta.respuesta = respuesta;
        updateRespuesta.ValueName = descripcion.toString();
        updateRespuesta.rowGuidVisita = rowguidVista;
        return this.http.post(
          `${this.url}/SetVisitasRespuestas`, updateRespuesta)
          .pipe(
            map(resp => {
             return resp;
            })
          );
      }
}