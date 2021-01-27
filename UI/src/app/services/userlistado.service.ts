import { Injectable, PipeTransform } from '@angular/core';
import { map, tap, debounceTime, switchMap, delay } from 'rxjs/operators';
import { SortDirection } from '../pages/user/userpage/sortable.directive';
import { BehaviorSubject, Subject, Observable, of } from 'rxjs';
import { DecimalPipe } from '@angular/common';
import { UsuarioInfoModel } from 'src/app/models/usuarioInfo.model';
import { HttpClient } from '@angular/common/http';


interface SearchResult {
  countries: UsuarioInfoModel[];
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

function sort(usuarios: UsuarioInfoModel[], column: string, direction: string): UsuarioInfoModel[] {
  if (direction === '') {
    return usuarios;
  } else {
    return [...usuarios].sort((a, b) => {
      const res = compare(a[column], b[column]);
      return direction === 'asc' ? res : -res;
    });
  }
}

function matches(country: UsuarioInfoModel, term: string, pipe: PipeTransform) {
  return country.nombre.toLowerCase().includes(term.toLowerCase())
  || pipe.transform(country.apellidos).includes(term)
  || pipe.transform(country.email).includes(term);
}


@Injectable({
  providedIn: 'root'
})
export class UserlistadoService {

  private url = 'https://app.metafase.com/aurora_test/api';
  // tslint:disable-next-line:variable-name
  private _loading$ = new BehaviorSubject<boolean>(true);
  // tslint:disable-next-line:variable-name
  private _search$ = new Subject<void>();
  // tslint:disable-next-line:variable-name
  private _countries$ = new BehaviorSubject<UsuarioInfoModel[]>([]);
  // tslint:disable-next-line:variable-name
  private _total$ = new BehaviorSubject<number>(0);

  UsuariosListado: UsuarioInfoModel[] = [];

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
      this._countries$.next(result.countries);
      this._total$.next(result.total);
    });

    this._search$.next();
  }

  get countries$() { return this._countries$.asObservable(); }
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
    let countries = sort( this.UsuariosListado, sortColumn, sortDirection);

    // 2. filter
    countries = countries.filter(country => matches(country, searchTerm, this.pipe));
    const total = countries.length;

    // 3. paginate
    countries = countries.slice((page - 1) * pageSize, (page - 1) * pageSize + pageSize);
    return of({countries, total});
  }
  public getUsuarios() {
    return this.http.get(`${this.url}/user/GetAllUser`)
    .pipe(
      map( this.crearArregloUsuario)
    );
  }
  private crearArregloUsuario(usuarioObj: object) {
    return usuarioObj['result'];
  }
}
