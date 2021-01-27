import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { FormsModule,  ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule} from '@angular/common/http';
import { NgbDatepickerConfig, NgbDateParserFormatter } from '@ng-bootstrap/ng-bootstrap';
import { AppComponent } from './app.component';
import { DecimalPipe } from '@angular/common';
import { AppRoutingModule } from './pages/app-routing.module';
import { LoginComponent } from './pages/login/login.component';
import { HomeLayoutComponent } from './pages/shared/home-layout/home-layout.component';
import { NavbarComponent } from './pages/shared/navbar/navbar.component';
import { HomeComponent } from './pages/home/home.component';
import { LoginLayoutComponent } from './pages/shared/login-layout/login-layout.component';
import { UserComponent } from './pages/user/user.component';
import { ForgotpasswordComponent } from './pages/forgotpassword/forgotpassword.component';
import { RegisterUserComponent } from './pages/register-user/register-user.component';
import { EditUserComponent } from './pages/edit-user/edit-user.component';
import { UserpageComponent } from './pages/user/userpage/userpage.component';
import { SortableDirective } from './pages/user/userpage/sortable.directive';
import { ClusterComponent } from './pages/cluster/cluster.component';
import { LoadingComponent } from './pages/shared/loading/loading.component';
import { SelectModule} from 'ng-select';
import { CustionariosearchComponent} from './pages/cuestionario/custionariosearch.component';
import { RutassearchComponent} from './pages/rutas/rutassearch.component';

import { SurtidosearchComponent} from './pages/surtido/surtidosearch.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { RutaSortableDirective } from './pages/rutas/ruta-sortable.directive';
import { DuplicadorutasComponent } from './pages/rutas/duplicadorutas/duplicadorutas.component';
import { RegistroComponent } from './pages/registro/registro.component';

import {LOCALE_ID} from '@angular/core';
import localeEs from '@angular/common/locales/es';
import { registerLocaleData } from '@angular/common';
import { NgbDateFRParserFormatter } from './helper/date-parser-formatter/NgbDateFRParserFormatter';
import { CuestionarioSortableDirective } from './pages/cuestionario/cuestionario-sortable.directive';
import { SurtidoSortableDirective } from './pages/surtido/surtido-sortable.directive';
import { DuplicarsurtidoComponent } from './pages/surtido/duplicarsurtido/duplicarsurtido.component';
import { SurtidomasivoComponent } from './pages/surtido/surtidomasivo/surtidomasivo.component';
import { NgDropfilesDirective } from './pages/surtido/surtidomasivo/ng-dropfiles.directive';
import { VisitaSortableDirective } from './pages/visitas/visita-sortable.directive';
import { VisitasearchComponent } from './pages/visitas/visitasearch.component';
import {RespuestasearchComponent} from './pages/visitas/respuesta/respuestasearch.component';
import { RespuestaSortableDirective } from './pages/visitas/respuesta/respuesta-sortable.directive';

registerLocaleData(localeEs);


@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    HomeLayoutComponent,
    NavbarComponent,
    HomeComponent,
    LoginLayoutComponent,
    UserComponent,
    ForgotpasswordComponent,
    RegisterUserComponent,
    EditUserComponent,
    UserpageComponent,
    SortableDirective,
    ClusterComponent,
    LoadingComponent,
    CustionariosearchComponent,
    RutassearchComponent,
    SurtidosearchComponent,
    RutaSortableDirective,
    DuplicadorutasComponent,
    RegistroComponent,
    CuestionarioSortableDirective,
    SurtidoSortableDirective,
    DuplicarsurtidoComponent,
    SurtidomasivoComponent,
    NgDropfilesDirective,
    VisitaSortableDirective,
    VisitasearchComponent,
    RespuestasearchComponent,
    RespuestaSortableDirective,

  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule,
    ReactiveFormsModule,
    NgbModule,
    SelectModule,
    BrowserAnimationsModule,
  ],
  providers: [ { provide: NgbDateParserFormatter, useClass: NgbDateFRParserFormatter } , DecimalPipe],
  bootstrap: [AppComponent]
})
export class AppModule { }
