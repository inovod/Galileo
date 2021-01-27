import { IOption } from 'ng-select';
import { NgbDate } from '@ng-bootstrap/ng-bootstrap';

export class FilterSurtidosModel {
    clientes: Array<IOption>;
    fDesde: NgbDate;
    fhasta: NgbDate;
    canal: Array<IOption>;
    cadena: Array<IOption>;
    ensena: Array<IOption>;
    constructor() {
        this.clientes = [];
        this.fDesde = null;
        this.fhasta = null;
        this.canal = [];
        this.cadena = [];
        this.ensena = [];
    }
}
