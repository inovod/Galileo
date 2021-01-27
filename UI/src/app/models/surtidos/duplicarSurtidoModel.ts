import { IOption } from 'ng-select';

export class DuplicarSurtidoModel {
    canal: Array<IOption>;
    cadenas: Array<IOption>;
    ensena: Array<IOption>;

    constructor() {
        this.canal = [];
        this.cadenas = [];
        this.ensena = [];
    }
}
