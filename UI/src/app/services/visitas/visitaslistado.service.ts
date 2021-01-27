import { DecimalPipe } from '@angular/common';
import { HttpClient } from '@angular/common/http';
import { Injectable, PipeTransform } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import { Observable } from 'rxjs/internal/Observable';
import { of } from 'rxjs/internal/observable/of';
import { Subject } from 'rxjs/internal/Subject';
import { tap , debounceTime , switchMap, delay, map} from 'rxjs/operators';
import { ResVisitaModel } from 'src/app/models/responseDto/resVisita.model';
import { FilterVisitaModel } from 'src/app/models/visitas/filterVisita.model';
import { SortDirection } from 'src/app/pages/user/userpage/sortable.directive';

interface SearchResult {
    visitas: ResVisitaModel[];
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
function sort(usuarios: ResVisitaModel[], column: string, direction: string): ResVisitaModel[] {
    if (direction === '') {
      return usuarios;
    } else {
      return [...usuarios].sort((a, b) => {
        const res = compare(a[column], b[column]);
        return direction === 'asc' ? res : -res;
      });
    }
  }

function matches(visita: ResVisitaModel, term: string, pipe: PipeTransform) {
    return visita.vendedor.toLowerCase().includes(term.toLowerCase())
    || pipe.transform(visita.vendedor).includes(term)
    || pipe.transform(visita.codigodetienda).includes(term);
    /*|| pipe.transform(ruta.fcAlta).includes(term);*/
  }
@Injectable({
  providedIn : 'root'
})
export class VisitaslistadoService {

  // private url = 'https://localhost:44368/api/Visita';
  private url = 'https://app.metafase.com/Galileo_API_DESA/api/Visita';
  // tslint:disable-next-line:variable-name
  private _loading$ = new BehaviorSubject<boolean>(true);
  // tslint:disable-next-line:variable-name
  private _search$ = new Subject<void>();
  // tslint:disable-next-line:variable-name
  private _visitas$ = new BehaviorSubject<ResVisitaModel[]>([]);
  // tslint:disable-next-line:variable-name
  private _total$ = new BehaviorSubject<number>(0);

  visitasListado: ResVisitaModel[] = [];

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
      debounceTime(300),
      switchMap(() => this._search()),
      delay(300),
      tap(() => this._loading$.next(false))
    ).subscribe(result => {
      this._visitas$.next(result.visitas);
      this._total$.next(result.total);
    });

    this._search$.next();
  }

  actualizaListado() {
    this._search$.pipe(
      tap(() => this._loading$.next(true)),
      debounceTime(300),
      switchMap(() => this._search()),
      delay(300),
      tap(() => this._loading$.next(false))
    ).subscribe(result => {
      this._visitas$.next(result.visitas);
      this._total$.next(result.total);
    });
    this._search$.next();
  }

  get getVistas$() { return this._visitas$.asObservable(); }
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
    let visitas = sort( this.visitasListado, sortColumn, sortDirection);

    // 2. filter
    visitas =  visitas.filter(country => matches(country, searchTerm, this.pipe));
    const total = visitas.length;

    // 3. paginate
    visitas = visitas.slice((page - 1) * pageSize, (page - 1) * pageSize + pageSize);
    return of({visitas, total});
  }
  public getVisitas(filtro: FilterVisitaModel) {
    const idclient: number =  Number(filtro.clientes.toString());
    const idvendedor: number = Number(filtro.vendedor.toString());
    const idtienda: number = Number(filtro.tienda.toString());
    let fechaD = '';
    if (filtro.fDesde) {
      fechaD = filtro.fDesde.day + '/' + filtro.fDesde.month + '/' + filtro.fDesde.year;
    }
    let fechaH = '';
    if (filtro.fhasta) {
      fechaH = filtro.fhasta.day + '/' + filtro.fhasta.month + '/' + filtro.fhasta.year;
    }
    // tslint:disable-next-line:max-line-length
    return this.http.get(`${this.url}/GetVisitas?idcliente=${idclient}&idvendedor=${idvendedor}&fechadesde=${fechaD}&fechahasta=${fechaH}&idtienda=${idtienda}`)
    .pipe(
      map( this.crearArregloVisita)
    );
  }
  private crearArregloVisita(visitas: object) {
    // tslint:disable-next-line:no-string-literal
    return visitas['itemCollection'];
  }
}
