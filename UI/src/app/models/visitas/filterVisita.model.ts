import { NgbDate } from '@ng-bootstrap/ng-bootstrap';
import { IOption } from 'ng-select';

export class FilterVisitaModel {
    clientes: Array<IOption>;
    vendedor: Array<IOption>;
    tienda: Array<IOption>;
    fDesde: NgbDate;
    fhasta: NgbDate;
    constructor() {
        this.clientes = [];
        this.vendedor = [];
        this.tienda = [];
        this.fDesde = null;
        this.fhasta = null;
    }
}
