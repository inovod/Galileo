import { IOption } from 'ng-select';

export class FilterRespuestaModel {
    visitaRespuesta: string;
    tipoRespuesta: Array<IOption>;
    cadenaFiltro: string;
    surtido: boolean;
    constructor() {
        this.tipoRespuesta = [];
        this.surtido = false;
        this.visitaRespuesta = '';
        this.cadenaFiltro = '';
    }
}
