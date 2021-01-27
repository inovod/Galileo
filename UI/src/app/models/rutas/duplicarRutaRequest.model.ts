import { ResRutasModel } from '../responseDto/resRutas.model';

export class DuplicarRutasRequestModel {
    cliente: number;
    vendedor: number;
    Rutas: Array<ResRutasModel>;
    constructor() {
        this.cliente = 0;
        this.vendedor = 0;
        this.Rutas = [];
    }
}
