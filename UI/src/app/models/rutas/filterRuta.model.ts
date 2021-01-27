import { IOption } from 'ng-select';

export class FilterRutaModel {
    clientes: Array<IOption>;
    vendedor: Array<IOption>;
    rutasBaja: boolean;

    constructor() {
        this.clientes = [];
        this.vendedor = [];
        this.rutasBaja = false;
    }
}
