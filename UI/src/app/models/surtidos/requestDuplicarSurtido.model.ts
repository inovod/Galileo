export class RequestDuplicarSurtidoModel {
    idsurtido: number;
    cliente: number;
    canal: string;
    cadena: number[];
    ensena: number[];
    constructor() {
        this.cadena = [];
        this.ensena = [];
    }
}
