import { IOption } from 'ng-select';

export class ClusterModel {
    canal: Array<IOption>;
    cadena: Array<IOption>;
    ensena: Array<IOption>;
    provincia: Array<IOption>;
    municipio: Array<IOption>;
    sector: Array<IOption>;
    familia: Array<IOption>;
    categoria: Array<IOption>;
    segmento: Array<IOption>;
    cluster: Array<IOption>;

    constructor() {
        this.canal = [];
        this.cadena = [];
        this.ensena = [];
        this.provincia = [];
        this.municipio = [];
        this.sector = [];
        this.familia = [];
        this.categoria = [];
        this.segmento = [];
        this.cluster = [];
    }
}
