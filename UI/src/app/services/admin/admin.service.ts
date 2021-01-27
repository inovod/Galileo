import { Injectable } from '@angular/core';
import { ItemModel } from 'src/app/models/admin/item.model';
import { IOption } from 'ng-select';
import { ProvinciaModel } from 'src/app/models/admin/provincia.model';
import { HttpClient } from '@angular/common/http';
import { map } from 'rxjs/operators';
@Injectable({
  providedIn: 'root'
})
export class AdminService {
   /* private url = 'https://app.metafase.com/aurora_test/api/admin';
   private urlpre = 'https://app.metafase.com/galileo_api_desa/api/admin'; */ 

   // private url = 'https://app.metafase.com/Galileo_API_DESA/api/admin';
   // private url = 'https://app.metafase.com/Galileo_API_DESA/api/admin';
   private url = 'https://localhost:44368/api/admin';
  constructor(private http: HttpClient) { }

  getCanal() {
    return this.http.get(`${this.url}/GetCanales`).pipe(
      map(resp => {
        // tslint:disable-next-line:no-string-literal
        // return this.cloneOptions(resp['result']);
        return this.cloneOptions(resp['collectionItem']);
      })
    );
  }
  getTipoRespuestas() {
    return this.http.get(`${this.url}/GetTiposRespuestas`).pipe(
      map(resp => {
        // tslint:disable-next-line:no-string-literal
        // return this.cloneOptions(resp['result']);
        return this.cloneOptions(resp['collectionItem']);
      })
    );
  }
  getCadenas(idcanal) {
    return this.http.get(`${this.url}/GetCadenas?cdcanal=${idcanal}`).pipe(
      map( resp => {
        // tslint:disable-next-line:no-string-literal
        return this.cloneOptions(resp['collectionItem']);
      })
    );
  }
  getEnsena(idcadena) {
    return this.http.get(`${this.url}/GetEnsena?cdcadena=${idcadena}`).pipe(
      map( resp => {
        // tslint:disable-next-line:no-string-literal
        return this.cloneOptions(resp['collectionItem']);
      })
    );
  }
  getEnsenaMultiple(cadena: IOption[]) {
    let request = '';
    // tslint:disable-next-line:only-arrow-functions
    cadena.forEach( function(item) {
      // console.log(value);
      request += item.value + '@';
    });
    return this.http.get(`${this.url}/GetEnsenaMultiple?cdcadena=${request}`).pipe(
      map( resp => {
        // tslint:disable-next-line:no-string-literal
        return this.cloneOptions(resp['collectionItem']);
      })
    );
  }
  getProvincia() {
    return this.http.get(`${this.url}/GetProvincia`).pipe(
      map(resp => {
        // tslint:disable-next-line:no-string-literal
        return this.cloneOptionsProPobla(resp['collectionItem']);
      })
    );
  }

  getMunicipio(idcodigo: IOption[]) {
    let cadena = '';
    // tslint:disable-next-line:only-arrow-functions
    idcodigo.forEach( function(item) {
      // console.log(value);
      cadena += item.value + '@';
    });

    return this.http.get(`${this.url}/GetMunicipio?cdProvincia=${cadena}`).pipe(
      // tslint:disable-next-line:no-string-literal
      map( resp => {
         // tslint:disable-next-line:no-string-literal
        return this.cloneOptionsProPobla(resp['collectionItem']);
      })
    );
  }
  getSector() {
    return this.http.get(`${this.url}/GetSector`).pipe(
      map(resp => {
        // tslint:disable-next-line:no-string-literal
        return this.cloneOptions(resp['collectionItem']);
      })
    );
  }
  getFamilia(sectores: IOption[]) {
    // tslint:disable-next-line:forin
    // tslint:disable-next-line:only-arrow-functions
    let cadena = '';
    // tslint:disable-next-line:only-arrow-functions
    sectores.forEach( function(item) {
      // console.log(value);
      cadena += item.value + '@';
    });
    if (cadena !== '') {
      return this.http.get(`${this.url}/GetFamilia?cdsector=${cadena}`).pipe(
        map( resp => {
          // tslint:disable-next-line:no-string-literal
          return this.cloneOptions(resp['collectionItem']);
        })
      );
    }
  }

  getCategorias(sectores: IOption[], familias: IOption[]) {
    // tslint:disable-next-line:forin
    // tslint:disable-next-line:only-arrow-functions
    let sectoresParam = '';
    let familiasParam = '';
    // tslint:disable-next-line:only-arrow-functions
    sectores.forEach( function(item) {
       sectoresParam += item.value + '@';
    });
    // tslint:disable-next-line:only-arrow-functions
    familias.forEach( function(item) {
      familiasParam += item.value + '@';
    });

    return this.http.get(`${this.url}/GetCategoria?cdsector=${sectoresParam}&cdfamilia=${familiasParam}`).pipe(
        // tslint:disable-next-line:whitespace
        // tslint:disable-next-line:no-string-literal
        map( resp => {
          return this.cloneOptions(resp['collectionItem']);
        })
      );
  }

  getSegmento(sectores: IOption[], familias: IOption[] , categorias: IOption[]) {
    // tslint:disable-next-line:forin
    // tslint:disable-next-line:only-arrow-functions
    let sectoresParam = '';
    let familiasParam = '';
    let categoriasParam = '';
    // tslint:disable-next-line:only-arrow-functions
    sectores.forEach( function(item) {
       sectoresParam += item.value + '@';
    });
    // tslint:disable-next-line:only-arrow-functions
    familias.forEach( function(item) {
      familiasParam += item.value + '@';
    });

     // tslint:disable-next-line:only-arrow-functions
    categorias.forEach( function(item) {
      categoriasParam += item.value + '@';
    });
    // tslint:disable-next-line:max-line-length
    return this.http.get(`${this.url}/GetSegmento?cdsector=${sectoresParam}&cdfamilia=${familiasParam}&cdcategorias=${categoriasParam}`).pipe(
        // tslint:disable-next-line:whitespace
        // tslint:disable-next-line:no-string-literal
        map( resp => {
          return this.cloneOptions(resp['collectionItem']);
        })
      );
  }

  getCluster(cadena, ensena: IOption[] ) {
    // tslint:disable-next-line:forin
    // tslint:disable-next-line:only-arrow-functions
    let ensenaParam = '';

    // tslint:disable-next-line:only-arrow-functions
    ensena.forEach( function(item) {
      ensenaParam += item.value + '@';
    });
    // tslint:disable-next-line:only-arrow-functions
    // tslint:disable-next-line:max-line-length
    return this.http.get(`${this.url}/GetCluster?cdcadena=${cadena}&cdensena=${ensenaParam}`).pipe(
        // tslint:disable-next-line:whitespace
        // tslint:disable-next-line:no-string-literal
        map( resp => {
          return this.cloneOptions(resp['collectionItem']);
        })
      );
  }

  getClientes() {
    return this.http.get(`${this.url}/GetClientes`).pipe(
      map(resp => {
        // tslint:disable-next-line:no-string-literal
        return this.cloneOptions(resp['collectionItem']);
      })
    );
  }

  getVendedores(idcliente) {
    return this.http.get(`${this.url}/GetVendedores?idcliente=${idcliente}`).pipe(
      map(resp => {
        // tslint:disable-next-line:no-string-literal
        return this.cloneOptions(resp['collectionItem']);
      })
    );
  }

  getTiendas(idcliente, cdvendedor: IOption[]) {
    const cdclienteParam = '@' + idcliente;
    let cdvendedorParam = '';

   // tslint:disable-next-line:only-arrow-functions
    cdvendedor.forEach( function(item) {
    cdvendedorParam += item + '@';
   });


    return this.http.get(`${this.url}/GetTiendas?cdcliente=${cdclienteParam}&cdvendedor=${cdvendedorParam}`).pipe(
      map(resp => {
        // tslint:disable-next-line:no-string-literal
        return this.cloneOptions(resp['collectionItem']);
      })
    );
  }

  private cloneOptions(options: ItemModel[]): Array<IOption> {
    return options.map(option => ({
        value: option.id,
        label: option.name
    }));
  }
  private cloneOptionsProPobla(options: ProvinciaModel[]): Array<IOption> {
    return options.map(option => ({
        value: option.codigo,
        label: option.descripcion
    }));
  }
}
