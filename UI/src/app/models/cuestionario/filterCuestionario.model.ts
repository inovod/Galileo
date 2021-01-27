import { IOption } from 'ng-select';
import { NgbDate } from '@ng-bootstrap/ng-bootstrap';
export class FilterCuestionarioModel {
    fechaIni: NgbDate;
    fechaHasta: NgbDate;
    clientes: Array<IOption>;
    constructor() {
        this.clientes = [];
        this.fechaIni = null;
        this.fechaHasta = null;
    }
}
