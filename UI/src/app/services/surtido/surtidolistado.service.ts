import { Injectable, PipeTransform } from '@angular/core';
import { ResSurtidoModel } from 'src/app/models/responseDto/resSurtido.model';
import { SortDirection } from 'src/app/pages/surtido/surtido-sortable.directive';
import { BehaviorSubject, Subject, Observable, of } from 'rxjs';
import { DecimalPipe } from '@angular/common';
import { HttpClient } from '@angular/common/http';
import { tap, debounceTime, switchMap, delay, map } from 'rxjs/operators';
import { FilterSurtidosModel } from 'src/app/models/surtidos/filterSurtidos.model';
import { RequestSurtidoFilterModel } from 'src/app/models/surtidos/RequestSurtidoFilter.model';

interface SearchResult {
  surtido: ResSurtidoModel[];
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
function sort(surtido: ResSurtidoModel[], column: string, direction: string): ResSurtidoModel[] {
  if (direction === '') {
    return surtido;
  } else {
    return [...surtido].sort((a, b) => {
      const res = compare(a[column], b[column]);
      return direction === 'asc' ? res : -res;
    });
  }
}

function matches(surtido: ResSurtidoModel, term: string, pipe: PipeTransform) {
  return surtido.cliente.toLowerCase().includes(term.toLowerCase())
  || pipe.transform(surtido.cliente).includes(term)
  || pipe.transform(surtido.cadena).includes(term);
}

@Injectable({
  providedIn: 'root'
})
export class SurtidolistadoService {
    // private url = 'https://localhost:44368/api/surtidos';
    private url = 'https://app.metafase.com/Galileo_API_DESA/api/surtidos';

  // tslint:disable-next-line:variable-name
  private _loading$ = new BehaviorSubject<boolean>(true);
  // tslint:disable-next-line:variable-name
  private _search$ = new Subject<void>();
  // tslint:disable-next-line:variable-name
  private _surtido$ = new BehaviorSubject<ResSurtidoModel[]>([]);
  // tslint:disable-next-line:variable-name
  private _total$ = new BehaviorSubject<number>(0);

  surtidosListado: ResSurtidoModel[] = [];

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
      this._surtido$.next(result.surtido);
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
      this._surtido$.next(result.surtido);
      this._total$.next(result.total);
    });
    this._search$.next();
  }

  get getSurtido$() { return this._surtido$.asObservable(); }
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
    let surtido = sort( this.surtidosListado, sortColumn, sortDirection);

    // 2. filter
    surtido = surtido.filter(country => matches(country, searchTerm, this.pipe));
    const total = surtido.length;

    // 3. paginate
    surtido = surtido.slice((page - 1) * pageSize, (page - 1) * pageSize + pageSize);
    return of({surtido, total});
  }
  public getSurtido(filtro: RequestSurtidoFilterModel) {
    let fechaD = '';
    if (filtro.fdesde) {
      fechaD = filtro.fdesde.day + '/' + filtro.fdesde.month + '/' + filtro.fdesde.year;
    }
    let fechaH = '';
    if (filtro.fhasta) {
      fechaH = filtro.fhasta.day + '/' + filtro.fhasta.month + '/' + filtro.fhasta.year;
    }
    const request = {
      cliente: filtro.cliente,
      cadena: filtro.cadena,
      canal: filtro.canal,
      ensena: filtro.ensema,
      fechaDesde: fechaD,
      fechaHasta: fechaH
    };
    return this.http.post(
      `${this.url}/GetSurtidos`, request)
      .pipe(
        map( this.crearArregloSurtido)
      );
  }
  private crearArregloSurtido(cuestionario: object) {
    console.log(cuestionario);
    // tslint:disable-next-line:no-string-literal
    return cuestionario['itemCollection'];
  }

}
