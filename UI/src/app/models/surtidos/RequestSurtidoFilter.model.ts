import { NgbDate } from '@ng-bootstrap/ng-bootstrap';

export class RequestSurtidoFilterModel {
    cliente: number;
    canal: number;
    cadena: number;
    ensema: Array<number>;
    fdesde: NgbDate;
    fhasta: NgbDate;
}
