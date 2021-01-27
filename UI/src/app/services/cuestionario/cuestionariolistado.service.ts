import { Injectable, PipeTransform } from '@angular/core';
import { ResCuestionarioModel } from 'src/app/models/responseDto/resCuestionario.model';
import { SortDirection } from 'src/app/pages/cuestionario/cuestionario-sortable.directive';
import { BehaviorSubject } from 'rxjs/internal/BehaviorSubject';
import { Subject, Observable, of } from 'rxjs';
import { DecimalPipe } from '@angular/common';
import { HttpClient } from '@angular/common/http';
import { tap, debounceTime, switchMap, delay, map } from 'rxjs/operators';
import { FilterCuestionarioModel } from 'src/app/models/cuestionario/filterCuestionario.model';
import { CuestionarioSearchModel } from 'src/app/models/cuestionario/cuestionarioSearch.model';


interface SearchResult {
  cuestionario: ResCuestionarioModel[];
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
function sort(usuarios: ResCuestionarioModel[], column: string, direction: string): ResCuestionarioModel[] {
  if (direction === '') {
    return usuarios;
  } else {
    return [...usuarios].sort((a, b) => {
      const res = compare(a[column], b[column]);
      return direction === 'asc' ? res : -res;
    });
  }
}

function matches(ruta: ResCuestionarioModel, term: string, pipe: PipeTransform) {
  return ruta.cliente.toLowerCase().includes(term.toLowerCase())
  || pipe.transform(ruta.cliente).includes(term)
  || pipe.transform(ruta.cadena).includes(term);
}

@Injectable({
  providedIn: 'root'
})
export class CuestionariolistadoService {
  private url = 'https://app.metafase.com/aurora_test/api/Cuestionario';

  // tslint:disable-next-line:variable-name
  private _loading$ = new BehaviorSubject<boolean>(true);
  // tslint:disable-next-line:variable-name
  private _search$ = new Subject<void>();
  // tslint:disable-next-line:variable-name
  private _cuestionario$ = new BehaviorSubject<ResCuestionarioModel[]>([]);
  // tslint:disable-next-line:variable-name
  private _total$ = new BehaviorSubject<number>(0);

  cuestionarioListado: ResCuestionarioModel[] = [];

  // tslint:disable-next-line:variable-name
  private _state: State = {
    page: 1,
    pageSize: 10,
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
      this._cuestionario$.next(result.cuestionario);
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
      this._cuestionario$.next(result.cuestionario);
      this._total$.next(result.total);
    });
    this._search$.next();
  }

  get getCuestionario$() { return this._cuestionario$.asObservable(); }
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
    let cuestionario = sort( this.cuestionarioListado, sortColumn, sortDirection);

    // 2. filter
    cuestionario = cuestionario.filter(country => matches(country, searchTerm, this.pipe));
    const total = cuestionario.length;

    // 3. paginate
    cuestionario = cuestionario.slice((page - 1) * pageSize, (page - 1) * pageSize + pageSize);
    return of({cuestionario, total});
  }

  public getCuestionario(filtro: CuestionarioSearchModel) {
    const idclient: number =  Number(filtro.clientes.toString());
    let fechaIni = '';
    if (filtro.fDesde) {
      fechaIni = filtro.fDesde.day + '/' + filtro.fDesde.month + '/' + filtro.fDesde.year;
    }
    let fechaHasta = '';
    if (filtro.fhasta) {
      fechaHasta = filtro.fhasta.day + '/' + filtro.fhasta.month + '/' + filtro.fhasta.year;
    }
    return this.http.get(`${this.url}/GetCuestionarios?fechaIni=${fechaIni}&fechaFin=${fechaHasta}&cdCliente=${idclient}`)
    .pipe(
      map( this.crearArregloCuestionario)
    );
  }
  private crearArregloCuestionario(cuestionario: object) {
    console.log(cuestionario);
    // tslint:disable-next-line:no-string-literal
    return cuestionario['result'];
  }
}
