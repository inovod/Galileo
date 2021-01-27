import { NgbDate } from '@ng-bootstrap/ng-bootstrap';
import { IOption } from 'ng-select';
export class VistaSearchModel {
    fVisita: NgbDate;
    clientes: Array<IOption>;
    vendedor: Array<IOption>;
    tienda: Array<IOption>;
    /*tienda: Array<IOption>;*/
    constructor() {
        this.fVisita = null;
        this.clientes = [];
        this.vendedor = [];
        this.tienda = [];
        /*this.tienda = [];*/
    }
}
