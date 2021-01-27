import { Routes, RouterModule, CanActivate } from '@angular/router';
import { NgModule, Component } from '@angular/core';
import { LoginComponent } from './login/login.component';
import { HomeLayoutComponent } from './shared/home-layout/home-layout.component';
import { HomeComponent } from './home/home.component';
import { AuthGuard } from '../guards/auth.guard';
import { LoginLayoutComponent } from './shared/login-layout/login-layout.component';
import { ForgotpasswordComponent } from './forgotpassword/forgotpassword.component';
import { RegisterUserComponent } from './register-user/register-user.component';
import { EditUserComponent } from './edit-user/edit-user.component';
import { UserpageComponent } from './user/userpage/userpage.component';
import { ClusterComponent } from './cluster/cluster.component';
import { CustionariosearchComponent } from './cuestionario/custionariosearch.component';
import { RutassearchComponent } from './rutas/rutassearch.component';
import { SurtidosearchComponent } from './surtido/surtidosearch.component';
import { DuplicadorutasComponent } from './rutas/duplicadorutas/duplicadorutas.component';
import { DuplicarsurtidoComponent } from './surtido/duplicarsurtido/duplicarsurtido.component';
import { SurtidomasivoComponent } from './surtido/surtidomasivo/surtidomasivo.component';
import { VisitasearchComponent } from './visitas/visitasearch.component';
import { RespuestasearchComponent } from './visitas/respuesta/respuestasearch.component';
const routes: Routes = [
    {
        path: '' , component: HomeLayoutComponent, canActivate: [AuthGuard],
        children : [
            {path: 'home' , component: HomeComponent},
            {path: 'UsuariosPaginado' , component: UserpageComponent},
            {path: 'edituser/:id', component: EditUserComponent},
            {path: 'registeruser', component: RegisterUserComponent},
            {path: 'cluster', component: ClusterComponent} ,
            {path: 'cuestionario', component: CustionariosearchComponent} ,
            {path: 'rutas', component: RutassearchComponent} ,
            {path: 'surtido', component: SurtidosearchComponent} ,
            {path: 'duplicadoRutas', component: DuplicadorutasComponent} ,
            {path: 'duplicadoSurtido', component: DuplicarsurtidoComponent} ,
            {path: 'surtidoMasivo', component: SurtidomasivoComponent} ,
            {path: 'visitas', component: VisitasearchComponent} ,
            {path: 'respuestaSearch', component: RespuestasearchComponent} ,
    ]},
    {
        path: '', component: LoginLayoutComponent,
        children: [
            {path: 'login', component: LoginComponent},
            {path: 'forgotpassword', component: ForgotpasswordComponent}
    ]},
    { path: '**', redirectTo: ''},
];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule]
})
export class AppRoutingModule {}
