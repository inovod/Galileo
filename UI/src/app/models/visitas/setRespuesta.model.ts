import { ResRespuestaModel } from '../responseDto/resRespuestas.model';

export class SetRespuestaModel{
    respuesta: ResRespuestaModel;
    ValueName: string;
    rowGuidVisita: string;s
    constructor() {
        this.ValueName = '';
        this.rowGuidVisita = '';
        this.respuesta = new ResRespuestaModel();
    }
}

/*cdReferencia: string;
referencia: string;
cdPreguntaCuestionario: string;
cdCuestionario: string;
cdPregunta: string;
pregunta: string;
surtido: string;
uiRespuestaCuestionario:string;
respuesta:string;*/