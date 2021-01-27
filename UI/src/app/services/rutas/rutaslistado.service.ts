import { Injectable, PipeTransform } from '@angular/core';
import { ResRutasModel } from 'src/app/models/responseDto/resRutas.model';
import { BehaviorSubject, Subject, Observable, of } from 'rxjs';
import { tap, debounceTime, switchMap, delay, map } from 'rxjs/operators';
import { SortDirection } from '../../pages/rutas/ruta-sortable.directive';
import { DecimalPipe } from '@angular/common';
import { FilterRutaModel } from 'src/app/models/rutas/filterRuta.model';
import { HttpClient } from '@angular/common/http';

interface SearchResult {
  rutas: ResRutasModel[];
  total: number;
}

interface State {
  page: number;
  pageSize: number;
  searchTerm: string;
  sortColumn: string;
  sortDirection: SortDirection;
}

function compare(v1, v2) {
  return v1 < v2 ? -1 : v1 > v2 ? 1 : 0;
}
function sort(usuarios: ResRutasModel[], column: string, direction: string): ResRutasModel[] {
  if (direction === '') {
    return usuarios;
  } else {
    return [...usuarios].sort((a, b) => {
      const res = compare(a[column], b[column]);
      return direction === 'asc' ? res : -res;
    });
  }
}

function matches(ruta: ResRutasModel, term: string, pipe: PipeTransform) {
  return ruta.cliente.toLowerCase().includes(term.toLowerCase())
  || pipe.transform(ruta.vendedor).includes(term)
  || pipe.transform(ruta.provincia).includes(term);
  /*|| pipe.transform(ruta.fcAlta).includes(term);*/
}

@Injectable({
  providedIn: 'root'
})
export class RutaslistadoService {

  private url = 'https://app.metafase.com/aurora_test/api/rutas';
  // tslint:disable-next-line:variable-name
  private _loading$ = new BehaviorSubject<boolean>(true);
  // tslint:disable-next-line:variable-name
  private _search$ = new Subject<void>();
  // tslint:disable-next-line:variable-name
  private _rutas$ = new BehaviorSubject<ResRutasModel[]>([]);
  // tslint:disable-next-line:variable-name
  private _total$ = new BehaviorSubject<number>(0);

  rutasListado: ResRutasModel[] = [];

  // tslint:disable-next-line:variable-name
  private _state: State = {
    page: 1,
    pageSize: 4,
    searchTerm: '',
    sortColumn: '',
    sortDirection: ''
  };

  constructor(private pipe: DecimalPipe, private http: HttpClient) {
    this._search$.pipe(
      tap(() => this._loading$.next(true)),
      debounceTime(200),
      switchMap(() => this._search()),
      delay(200),
      tap(() => this._loading$.next(false))
    ).subscribe(result => {
      this._rutas$.next(result.rutas);
      this._total$.next(result.total);
    });

    this._search$.next();
  }
  actualizaListado() {
    this._search$.pipe(
      tap(() => this._loading$.next(true)),
      debounceTime(200),
      switchMap(() => this._search()),
      delay(200),
      tap(() => this._loading$.next(false))
    ).subscribe(result => {
      this._rutas$.next(result.rutas);
      this._total$.next(result.total);
    });
    this._search$.next();
  }

  get getRutas$() { return this._rutas$.asObservable(); }
  get total$() { return this._total$.asObservable(); }
  get loading$() { return this._loading$.asObservable(); }
  get page() { return this._state.page; }
  get pageSize() { return this._state.pageSize; }
  get searchTerm() { return this._state.searchTerm; }

  // tslint:disable-next-line:adjacent-overload-signatures
  set page(page: number) { this._set({page}); }
  // tslint:disable-next-line:adjacent-overload-signatures
  set pageSize(pageSize: number) { this._set({pageSize}); }
  // tslint:disable-next-line:adjacent-overload-signatures
  set searchTerm(searchTerm: string) { this._set({searchTerm}); }
  set sortColumn(sortColumn: string) { this._set({sortColumn}); }
  set sortDirection(sortDirection: SortDirection) { this._set({sortDirection}); }

  private _set(patch: Partial<State>) {
    Object.assign(this._state, patch);
    this._search$.next();
  }

  private _search(): Observable<SearchResult> {
    const {sortColumn, sortDirection, pageSize, page, searchTerm} = this._state;
    // 1. sort
    let rutas = sort( this.rutasListado, sortColumn, sortDirection);

    // 2. filter
    rutas = rutas.filter(country => matches(country, searchTerm, this.pipe));
    const total = rutas.length;

    // 3. paginate
    rutas = rutas.slice((page - 1) * pageSize, (page - 1) * pageSize + pageSize);
    return of({rutas, total});
  }
  public getRutas(filtro: FilterRutaModel) {
    const idclient: number =  Number(filtro.clientes.toString());
    const idvendedor: number = Number(filtro.vendedor.toString());
    return this.http.get(`${this.url}/GetRutas?idcliente=${idclient}&idvendedor=${idvendedor}&rutasbaja=${filtro.rutasBaja}`)
    .pipe(
      map( this.crearArregloRuta)
    );
  }
  private crearArregloRuta(ruta: object) {
    return ruta['result'];
  }

}
