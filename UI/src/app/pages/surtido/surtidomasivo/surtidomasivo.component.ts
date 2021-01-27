import { Component, OnInit } from '@angular/core';
import { FileItem } from 'src/app/models/surtidos/file-item';
import { SurtidoService } from 'src/app/services/surtido/surtido.service';

@Component({
  selector: 'app-surtidomasivo',
  templateUrl: './surtidomasivo.component.html',
  styles: []
})
export class SurtidomasivoComponent implements OnInit {
  estaSobreElemento = false;
  archivos: FileItem[] = [];
  constructor(private surtidosrv: SurtidoService) { }

  ngOnInit() {
  }

  cargarImagenes() {
    this.surtidosrv.cargarImagenes(this.archivos).subscribe(resp => {
      console.log(resp);
    });
  }

  limpiarArchivos() {
    this.archivos = [];
  }

}
