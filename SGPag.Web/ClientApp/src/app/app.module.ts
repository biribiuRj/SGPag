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
import { ServicoUsuario } from './servicos/usuario/servico.usuario';
import { GuardaRotas } from './autorizacao/guarda.rotas';
import { ServicoArea } from './servicos/area/servico.area';
import { ServicoFornecedor } from './servicos/fornecedor/servico.fornecedor';
import { ServicoEmpresa } from './servicos/empresa/servico.empresa';
import { LoginComponent } from './usuario/login/usuario.login.component';
import { UsuarioManutencaoComponent } from './usuario/manutencao/usuario.manutencao.component';
import { CadastrarUsuarioComponent } from './usuario/cadastro/usuario.cadastro.component';
import { AreaComponent } from './area/area.component';


@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    LoginComponent,
    UsuarioManutencaoComponent,
    CadastrarUsuarioComponent,
    ManutencaoAreaComponent,
    ManutencaoEstadoComponent,
    AreaComponent,
    ManutencaoEmpresaComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full', canActivate: [GuardaRotas] },
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent },
      { path: 'entrar', component: LoginComponent },
      { path: 'cadastrar-usuario', component: CadastrarUsuarioComponent },
      //{ path: 'cadastrar-area', component: ManutencaoAreaComponent },
      //{ path: 'cadastrar-estado', component: LoginComponent },
      //{ path: 'cadastrar-empresa', component: LoginComponent },
      //{ path: 'cadastrar-fornecedor', component: LoginComponent },
      //{ path: 'manutencao-fornecedor', component: UsuarioManutencaoComponent },
      { path: 'manutencao-usuario', component: UsuarioManutencaoComponent },
      { path: 'manutencao-area', component: AreaComponent },
      { path: 'manutencao-estado', component: ManutencaoEstadoComponent, canActivate: [GuardaRotas] },
      { path: 'manutencao-empresa', component: ManutencaoEmpresaComponent },
    ])
  ],
  providers: [ServicoUsuario, ServicoArea, ServicoFornecedor, ServicoEmpresa],
  bootstrap: [AppComponent]
})
export class AppModule { }
