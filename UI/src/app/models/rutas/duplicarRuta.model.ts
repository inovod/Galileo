import { IOption } from 'ng-select';

export class DuplicarRutaModel {
    clientes: Array<IOption>;
    vendedor: Array<IOption>;

    constructor() {
        this.clientes = [];
        this.vendedor = [];
    }
}
