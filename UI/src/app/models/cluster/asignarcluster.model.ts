export class AsignarClusterModel {
    canal: string;
    cadena: string;
    ensena: number[];
    poblacion: string;
    provincia: string;
    sector: number[];
    familia: number[];
    categoria: number[];
    segmento: number[];
    cluster: string;
    
    constructor() {
        this.ensena  = [];
        this.sector = [];
        this.familia = [];
        this.categoria = [];
        this.segmento = [];
     }
}
