import { Component, OnInit } from '@angular/core';
import { ClusterModel } from '../../models/cluster/cluster.model';
import { ClusterService } from '../../services/cluster/cluster.service';
import { IOption } from 'ng-select';
import { NgForm } from '@angular/forms';
import Swal from 'sweetalert2';
import { Observable } from 'rxjs';
import { AsignarClusterModel } from 'src/app/models/cluster/asignarcluster.model';
import { AdminService } from '../../services/admin/admin.service';

@Component({
  selector: 'app-cluster',
  templateUrl: './cluster.component.html',
  styleUrls: ['./cluster.component.css']
})
export class ClusterComponent implements OnInit {

  canalesModel: Array<IOption>;
  cadenasModel: Array<IOption>;
  ensenaModel: Array<IOption>;
  provinciaModel: Array<IOption>;
  municipioModel: Array<IOption>;
  sectorModel: Array<IOption>;
  familiaModel: Array<IOption>;
  categoriasModel: Array<IOption>;
  segmentoModel: Array<IOption>;
  clusterModel: Array<IOption>;
  cluster = new ClusterModel();
  itemSelectCanal: string [] = [];
  itemSelectCadenas: string [] = [];
  itemSelectEnsena: string [] = [];
  itemSelectCluster: string [] = [];
  itemSelectSector: string [] = [];
  itemSelectFamilia: string [] = [];
  itemSelectCategoria: string [] = [];
  itemSelectSegmento: string []  = [];
  itemSelectProvincia: string []  = [];
  itemSelectMunicipio: string []  = [];
  validarCadena = '';
  validarCanal = '';
  validarEnsena = '';
  validarCluster = '';
  validarSector = '';
  validarFamilia = '';
  validarCategoria = '';
  validarSegmento = '';
  validarProvincia = '';
  validarMunicipio = '';
  constructor(private clusterService: ClusterService , private adminService: AdminService) {
    /*this.cluster.canal = [];
    this.cluster.cadena = [];
    this.cluster.sector = [];
    this.cluster.familia = [];
    this.cluster.categoria = [];
    this.cluster.segmento = [];
    this.cluster.ensena = [];
    this.cluster.cluster = [];
    this.cluster.provincia = [];
    this.cluster.municipio = [];*/
    this.validarCadena = '';
    this.validarCanal = '';
    this.validarEnsena = '';
    this.validarSector = '';
    this.validarFamilia = '';
    this.validarCategoria = '';
    this.validarSegmento = '';
  }

  ngOnInit() {
    this.adminService.getCanal().subscribe(resp => {
      this.canalesModel = resp;
    });
    this.adminService.getSector().subscribe(resp => {
      this.sectorModel = resp;
    });

    this.adminService.getProvincia().subscribe(resp => {
      this.provinciaModel = resp;
    });
  }
  canalSelect(option: IOption) {

    this.cluster.ensena = [];
    this.itemSelectEnsena = [];
    this.ensenaModel = [];
    this.cluster.cluster = [];
    this.itemSelectCluster = [];
    this.clusterModel = [];
    this.cluster.canal.push(option);
    this.adminService.getCadenas(option.value).subscribe(resp => {
        this.cadenasModel = resp;
      });
    this.validarCanal = '0';
  }

  canalDelete(option: IOption) {
    this.cluster.canal.forEach((item, index) => {
      if (option.value === item.value) {
         this.cluster.canal.splice(index, 1);
      }
    });
    this.validarCadena = '';
    this.cluster.cadena = [];
    this.cadenasModel = [];
    this.itemSelectCadenas = [];
    this.cluster.ensena = [];
    this.itemSelectEnsena = [];
    this.ensenaModel = [];
    this.validarEnsena = '';
    this.cluster.cluster = [];
    this.itemSelectCluster = [];
    this.clusterModel = [];
    this.validarCluster = '';
    this.validarCanal = '';
  }

  cadenaSelect(option: IOption) {
    this.cluster.cluster = [];
    this.itemSelectCluster = [];
    this.clusterModel = [];
    this.cluster.cadena.push(option);
    this.adminService.getEnsena(option.value).subscribe(resp => {
        this.ensenaModel = resp;
      });
    this.validarCadena = '0';
  }

  cadenaDelete(option: IOption) {
    this.cluster.cadena.forEach((item, index) => {
      if (option.value === item.value) {
         this.cluster.cadena.splice(index, 1);
      }
    });
    this.cluster.ensena = [];
    this.itemSelectEnsena = [];
    this.ensenaModel = [];
    this.validarEnsena = '';

    this.cluster.cluster = [];
    this.itemSelectCluster = [];
    this.clusterModel = [];
    this.validarCadena = '';
    this.validarCluster = '';
  }

  ensenaSelect(option: IOption) {
    this.cluster.ensena.push(option);
    this.validarEnsena = '0';
    if ( option.value.toString() !== '0' ) {
      this.adminService.getCluster(this.cluster.cadena[0].value ,  this.cluster.ensena).subscribe(resp => {
        this.clusterModel = resp;
      });
    }
  }

  ensenaDelete(option: IOption) {
    this.cluster.ensena.forEach((item, index) => {
      if (option.value === item.value) {
         this.cluster.ensena.splice(index, 1);
      }
    });
    this.itemSelectEnsena.forEach((item, index) => {
       if (option.value === item) {
         this.itemSelectEnsena.splice(index, 1);
       }
    });
    if (this.cluster.ensena.length <= 0) {
        this.validarEnsena = '';
    }
    this.actualizarCluster();
  }

  clusterSelect(option: IOption) {
    this.cluster.cluster.push(option);
    this.validarCluster = '0';
  }

  clusterDelete(option: IOption) {
    this.cluster.cluster.forEach((item, index) => {
      if (option.value === item.value) {
         this.cluster.cluster.splice(index, 1);
      }
    });
    this.itemSelectCluster.forEach((item, index) => {
       if (option.value === item) {
         this.itemSelectCluster.splice(index, 1);
       }
    });
  }

  sectorSelect(option: IOption) {
    this.cluster.sector.push(option);
    this.validarSector = '0';
    this.adminService.getFamilia(this.cluster.sector).subscribe( resp => {
      this.familiaModel = resp;
    });
  }

  sectorDelete(option: IOption) {
     this.cluster.sector.forEach((item, index) => {
       if (option.value === item.value) {
          this.cluster.sector.splice(index, 1);
       }
     });
     this.itemSelectSector.forEach((item, index) => {
        if (option.value === item) {
          this.itemSelectSector.splice(index, 1);
        }
     });
    // Actualizamos el combo de familias.
     if (this.cluster.sector.length > 0 ) {
        this.actualizarComboFamilia();
        this.actualizarCategorias();
        this.actualizarSegmento();

     } else {
          this.itemSelectFamilia = [];
          this.familiaModel = [];
          this.cluster.familia = [];
          this.itemSelectCategoria = [];
          this.categoriasModel = [];
          this.cluster.categoria = [];
          this.itemSelectSegmento = [];
          this.segmentoModel = [];
          this.cluster.segmento = [];
          this.validarSector = '';
          this.validarFamilia = '';
          this.validarCategoria = '';
          this.validarSegmento = '';
     }
  }

  familiaSelect(option: IOption) {
    this.cluster.familia.push(option);
    this.validarFamilia = '0';
    this.adminService.getCategorias(this.cluster.sector, this.cluster.familia).subscribe(resp => {
        this.categoriasModel = resp;
    });
  }

  familiaDelete(option: IOption) {
    this.cluster.familia.forEach((item, index) => {
      if (option.value === item.value) {
         this.cluster.familia.splice(index, 1);
      }
    });
    this.itemSelectFamilia.forEach((item, index) => {
       if (option.value === item) {
         this.itemSelectFamilia.splice(index, 1);
       }
    });
    this.actualizarCategorias();
    this.actualizarSegmento();
  }

  provinciaSelect(option: IOption) {
    this.cluster.provincia.push(option);
    this.validarProvincia = '0';
    this.adminService.getMunicipio(this.cluster.provincia).subscribe(resp => {
      this.municipioModel = resp;
    });
  }

  provinciaDelete(option: IOption) {
    this.cluster.provincia.forEach((item, index) => {
      if (option.value === item.value) {
         this.cluster.provincia.splice(index, 1);
      }
    });
    this.itemSelectProvincia.forEach((item, index) => {
       if (option.value === item) {
         this.itemSelectProvincia.splice(index, 1);
       }
    });
    this.actualizarMunicipio();
  }
  municipioSelect(option: IOption) {
    this.cluster.municipio.push(option);
    this.validarMunicipio = '0';
  }
  municipioDelete(option: IOption) {
    this.cluster.municipio.forEach((item, index) => {
      if (option.value === item.value) {
         this.cluster.municipio.splice(index, 1);
      }
    });
    this.itemSelectMunicipio.forEach((item, index) => {
       if (option.value === item) {
         this.itemSelectMunicipio.splice(index, 1);
       }
    });
    if (this.cluster.municipio.length === 0) {
      this.validarMunicipio = '';
    }
  }

  categoriaSelect(option: IOption) {
    this.cluster.categoria.push(option);
    this.validarCategoria = '0';
    this.adminService.getSegmento(this.cluster.sector, this.cluster.familia , this.cluster.categoria).subscribe(resp => {
      this.segmentoModel = resp;
    });
  }

  categoriaDelete(option: IOption) {
    this.cluster.categoria.forEach((item, index) => {
      if (option.value === item.value) {
         this.cluster.categoria.splice(index, 1);
      }
    });
    this.itemSelectCategoria.forEach((item, index) => {
       if (option.value === item) {
         this.itemSelectCategoria.splice(index, 1);
       }
    });
    this.actualizarSegmento();
  }

  segmentoSelect(option: IOption) {
    this.cluster.segmento.push(option);
    this.validarSegmento = '0';
  }

  segmentoDelete(option: IOption) {
    this.cluster.segmento.forEach((item, index) => {
      if (option.value === item.value) {
         this.cluster.segmento.splice(index, 1);
      }
    });
    this.itemSelectSegmento.forEach((item, index) => {
       if (option.value === item) {
         this.itemSelectSegmento.splice(index, 1);
       }
    });
    if (this.cluster.segmento.length <= 0) {
      this.validarSegmento = '';
    }
  }
 
  actualizarComboFamilia() {
       // Actualizamos el combo de familias.
      if (this.cluster.familia.length > 0) {
       this.adminService.getFamilia(this.cluster.sector).subscribe(resp => {
         this.familiaModel = resp;
         this.cluster.familia.forEach((item , index) => {
          const index2 =  this.familiaModel.find( x => x.value === item.value);
          if (!index2) {
              this.cluster.familia.splice(index, 1);
          }
         });
         this.itemSelectFamilia.forEach( (item, index) => {
          const index2 =  this.familiaModel.find( x => x.value === item);
          if (!index2) {
            this.itemSelectFamilia.splice(index, 1);
          }
         });
       });
      } else {
       this.itemSelectFamilia = [];
       this.familiaModel = [];
       this.cluster.familia = [];
       this.itemSelectCategoria = [];
       this.categoriasModel = [];
       this.cluster.categoria = [];
       this.itemSelectSegmento = [];
       this.segmentoModel = [];
       this.cluster.segmento = [];
       this.validarCategoria = '';
       this.validarSegmento = '';
      }
}
actualizarMunicipio() {
  if ( this.cluster.provincia.length > 0) {
        this.adminService.getMunicipio(this.cluster.provincia).subscribe(resp => {
          this.municipioModel = resp;
          this.cluster.municipio.forEach((item , index) => {
            const index2 =  this.municipioModel.find( x => x.value === item.value);
            if (!index2) {
                this.cluster.municipio.splice(index, 1);
            }
           });
          this.itemSelectMunicipio.forEach( (item, index) => {
            const index2 =  this.municipioModel.find( x => x.value === item);
            if (!index2) {
              this.itemSelectMunicipio.splice(index, 1);
            }
           });
        });
  } else {
    this.itemSelectMunicipio = [];
    this.municipioModel = [];
    this.cluster.municipio = [];
    this.validarProvincia = '';
    this.validarMunicipio = '';
  }
}
actualizarCategorias() {
      if (this.cluster.familia.length > 0) {
        // Actualizamos el como de categorias
       this.adminService.getCategorias(this.cluster.sector, this.cluster.familia).subscribe(resp2 => {
         this.categoriasModel = resp2;
         this.cluster.categoria.forEach((item , index) => {
          const index2 =  this.categoriasModel.find( x => x.value === item.value);
          if (!index2) {
              this.cluster.categoria.splice(index, 1);
          }
         });
         this.itemSelectCategoria.forEach( (item, index) => {
          const index2 =  this.categoriasModel.find( x => x.value === item);
          if (!index2) {
            this.itemSelectCategoria.splice(index, 1);
          }
         });
       });
    } else {
     this.itemSelectCategoria = [];
     this.categoriasModel = [];
     this.cluster.categoria = [];
     this.itemSelectSegmento = [];
     this.segmentoModel = [];
     this.cluster.segmento = [];
     this.validarFamilia = '';
     this.validarCategoria = '';
     this.validarSegmento = '';
    }
}
actualizarSegmento() {
    // Actualizamos el como de segmento
     if (this.cluster.categoria.length > 0) {
        this.adminService.getSegmento(this.cluster.sector, this.cluster.familia , this.cluster.categoria).subscribe(resp => {
          this.segmentoModel = resp;
          this.cluster.segmento.forEach((item , index) => {
           const index2 =  this.segmentoModel.find( x => x.value === item.value);
           if (!index2) {
            this.cluster.segmento.splice(index, 1);
           }
          });
          this.itemSelectSegmento.forEach( (item, index) => {
           const index2 =  this.segmentoModel.find( x => x.value === item);
           if (!index2) {
             this.itemSelectSegmento.splice(index, 1);
           }
          });
       });
     } else {
      this.itemSelectSegmento = [];
      this.segmentoModel = [];
      this.cluster.segmento = [];
      this.validarCategoria = '';
      this.validarSegmento = '';
      }
}
actualizarCluster() {
    if ( this.cluster.ensena.length > 0) {
          this.adminService.getCluster(this.cluster.cadena[0].value, this.cluster.ensena).subscribe(resp => {
            this.clusterModel = resp;
            this.cluster.cluster.forEach((item , index) => {
              const index2 =  this.clusterModel.find( x => x.value === item.value);
              if (!index2) {
               this.cluster.cluster.splice(index, 1);
              }
             });

            this.itemSelectCluster.forEach( (item, index) => {
              const index2 =  this.clusterModel.find( x => x.value === item);
              if (!index2) {
                this.itemSelectCluster.splice(index, 1);
              }
             });
          });
     } else {
      this.itemSelectCluster = [];
      this.clusterModel = [];
      this.cluster.cluster = [];
      this.validarCluster = '';
    }
}

  guardar(forma: NgForm) {

    if (forma.invalid) {
      return;
    }
    Swal.fire({
      title: 'Espere',
      text: 'Guardando información',
      type: 'info',
      allowOutsideClick: false,
    });
    Swal.showLoading();

    const data: AsignarClusterModel = new AsignarClusterModel();
    data.canal = this.itemSelectCanal.toString();
    data.cadena = this.itemSelectCadenas.toString();

    this.cluster.ensena.forEach((item , index) => {
        data.ensena.push(Number(item.value));
    });
    data.provincia = this.itemSelectProvincia.toString();
    data.poblacion = this.itemSelectMunicipio.toString();
    this.cluster.sector.forEach((item , index) => {
      data.sector.push(Number(item.value));
    });
    this.cluster.familia.forEach((item , index) => {
      data.familia.push(Number(item.value));
    });
    this.cluster.categoria.forEach((item , index) => {
      data.categoria.push(Number(item.value));
    });
    this.cluster.segmento.forEach((item , index) => {
      data.segmento.push(Number(item.value));
    });
    data.cluster = this.itemSelectCluster.toString();

    let peticionUpdate: Observable<any>;
    peticionUpdate = this.clusterService.asignarTiendaConfig(data);

    peticionUpdate.subscribe(resp => {
      Swal.fire({
        title : '',
        text : 'Se Guardado correctamente',
        type: 'success'
      }).then((result) => {
        forma.reset();
        this.cluster = new ClusterModel();
      });
    }, (error) => {
      Swal.fire({
        title : '',
        text : 'No se ha podido realizar la operación',
        type: 'error'
      });
    });
 }
}
