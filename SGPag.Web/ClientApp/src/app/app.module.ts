import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { ManutencaoAreaComponent } from './area/manutencao/manutencao.area.component';
import { ManutencaoEstadoComponent } from './estado/manutencao/manutencao.estado.component';
import { ManutencaoEmpresaComponent } from './empresa/manutencao/manutencao.empresa.component';
import { UsuarioServico } from './servicos/usuario/servico.usuario';


@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    ManutencaoAreaComponent,
    ManutencaoEstadoComponent,
    ManutencaoEmpresaComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent },
      { path: 'manutencao-area', component: ManutencaoAreaComponent },
      { path: 'manutencao-estado', component: ManutencaoEstadoComponent },
      { path: 'manutencao-empresa', component: ManutencaoEmpresaComponent },
    ])
  ],
  providers: [UsuarioServico],
  bootstrap: [AppComponent]
})
export class AppModule { }
