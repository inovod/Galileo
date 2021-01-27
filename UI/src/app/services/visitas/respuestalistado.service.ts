import { DecimalPipe } from '@angular/common';
import { HttpClient } from '@angular/common/http';
import { Injectable, PipeTransform } from '@angular/core';
import { BehaviorSubject, Observable, Subject } from 'rxjs';
import { tap , debounceTime , switchMap, delay, map} from 'rxjs/operators';
import { ResRespuestaModel } from 'src/app/models/responseDto/resRespuestas.model';
import { FilterRespuestaModel } from 'src/app/models/visitas/filterRespuestas.model';
import { SortDirection } from 'src/app/pages/user/userpage/sortable.directive';
import { of } from 'rxjs/internal/observable/of';

interface SearchResult {
    respuestas: ResRespuestaModel[];
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
function sort(usuarios: ResRespuestaModel[], column: string, direction: string): ResRespuestaModel[] {
    if (direction === '') {
      return usuarios;
    } else {
      return [...usuarios].sort((a, b) => {
        const res = compare(a[column], b[column]);
        return direction === 'asc' ? res : -res;
      });
    }
  }

function matches(visita: ResRespuestaModel, term: string, pipe: PipeTransform) {
    return visita.pregunta.toLowerCase().includes(term.toLowerCase())
    || pipe.transform(visita.referencia).includes(term);
    // || pipe.transform(visita.pregunta).includes(term);
    /*|| pipe.transform(ruta.fcAlta).includes(term);*/
  }

@Injectable({
    providedIn : 'root'
  })
export class RespuestaListadoService {
    private url = 'https://app.metafase.com/Galileo_API_DESA/api/Visita';
    // private url = 'https://localhost:44368/api/Visita';

   /// private url = 'https://app.metafase.com/Galileo_API_DESA/api/Visita';

    // tslint:disable-next-line: variable-name
    private _loading$ = new BehaviorSubject<boolean>(true);
    // tslint:disable-next-line:variable-name
    private _search$ = new Subject<void>();
    // tslint:disable-next-line:variable-name
    private _respuestas$ = new BehaviorSubject<ResRespuestaModel[]>([]);
    // tslint:disable-next-line:variable-name
    private _total$ = new BehaviorSubject<number>(0);

    respuestasListado: ResRespuestaModel[] = [];

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
          this._respuestas$.next(result.respuestas);
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
          this._respuestas$.next(result.respuestas);
          this._total$.next(result.total);
        });
        this._search$.next();
      }
      get getRespuestas$() { return this._respuestas$.asObservable(); }
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
    let respuestas = sort( this.respuestasListado, sortColumn, sortDirection);

    // 2. filter
    respuestas =  respuestas.filter(country => matches(country, searchTerm, this.pipe));
    const total = respuestas.length;

    // 3. paginate
    respuestas = respuestas.slice((page - 1) * pageSize, (page - 1) * pageSize + pageSize);
    return of({respuestas, total});
  }

  public getRespuestas(filtro: FilterRespuestaModel) {
    const visita: string =  filtro.visitaRespuesta.toString();
    const idtipo: number = Number(filtro.tipoRespuesta.toString());
    const cadena: string = filtro.cadenaFiltro.toString();
    //const visita =  '634EDBD1-018E-456E-AF9E-00017EFB72CC';
    //const idtipo = 4;
    //const cadena = 'PVP';

    let surtido = '0';
    if (filtro.surtido) {
        surtido = '1';
    }
    // surtido = '1';
    // tslint:disable-next-line:max-line-length
    return this.http.get(`${this.url}/GetVisitasRespuestas?visita=${visita}&idtipo=${idtipo}&cadena=${cadena}&surtido=${surtido}`)
    .pipe(
      map( this.crearArregloVisita)
    );
  }
  private crearArregloVisita(visitas: object) {
    // tslint:disable-next-line:no-string-literal
    return visitas['itemCollection'];
  }

}
