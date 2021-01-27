import { NgbDate } from '@ng-bootstrap/ng-bootstrap';
import { IOption } from 'ng-select';

export class CuestionarioSearchModel {
    fDesde: NgbDate;
    fhasta: NgbDate;
    clientes: Array<IOption>;
    constructor() {
        this.fhasta = null;
        this.fDesde = null;
        this.clientes = [];
    }
}
