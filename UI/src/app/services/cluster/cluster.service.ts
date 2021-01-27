import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { map } from 'rxjs/operators';
import { AsignarClusterModel } from '../../models/cluster/asignarcluster.model';


@Injectable({
  providedIn: 'root'
})
export class ClusterService {

  constructor(private http: HttpClient) { }
  private urlCluster = 'https://app.metafase.com/aurora_test/api/Cluster';
  // private urlCluster = 'https://localhost:44368/api/Cluster';

  asignarTiendaConfig(dto: AsignarClusterModel) {
      return this.http.post(
      `${this.urlCluster}/`, dto)
      .pipe(
        map(resp => {
         return resp;
        })
      );
   }
}
