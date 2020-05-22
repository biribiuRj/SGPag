import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { ManutencaoAreaComponent } from './area/manutencao/manutencao.area.component';
import { ManutencaoEstadoComponent } from './estado/manutencao/manutencao.estado.component';
import { ManutencaoEmpresaComponent } from './empresa/manutencao/manutencao.empresa.component';
import { ServicoUsuario } from './servicos/usuario/servico.usuario';
import { GuardaRotas } from './autorizacao/guarda.rotas';
import { ServicoArea } from './servicos/area/servico.area';
import { ServicoFornecedor } from './servicos/fornecedor/servico.fornecedor';
import { ServicoEmpresa } from './servicos/empresa/servico.empresa';
import { LoginComponent } from './usuario/login/usuario.login.component';
import { UsuarioComponent } from './usuario/manutencao/usuario.manutencao.component';
import { CadastrarUsuarioComponent } from './usuario/cadastro/usuario.cadastro.component';
import { AreaComponent } from './area/area.component';
import { EmpresaComponent } from './empresa/empresa.component';
import { EstadoComponent } from './estado/estado.component';
import { FornecedorComponent } from './fornecedor/fornecedor.component';


@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    LoginComponent,
    UsuarioComponent,
    CadastrarUsuarioComponent,
    ManutencaoAreaComponent,
    ManutencaoEstadoComponent,
    AreaComponent,
    FornecedorComponent,
    EstadoComponent,
    EmpresaComponent,
    ManutencaoEmpresaComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full', canActivate: [GuardaRotas] },
      { path: 'counter', component: CounterComponent },
      { path: 'entrar', component: LoginComponent },
      { path: 'cadastrar-usuario', component: CadastrarUsuarioComponent },
      //{ path: 'cadastrar-area', component: ManutencaoAreaComponent },
      //{ path: 'cadastrar-estado', component: LoginComponent },
      //{ path: 'cadastrar-empresa', component: LoginComponent },
      //{ path: 'cadastrar-fornecedor', component: LoginComponent },
      { path: 'manutencao-fornecedor', component: FornecedorComponent },
      { path: 'manutencao-usuario', component: UsuarioComponent },
      { path: 'manutencao-area', component: AreaComponent },
      { path: 'manutencao-estado', component: EstadoComponent, canActivate: [GuardaRotas] },
      { path: 'manutencao-empresa', component: EmpresaComponent },
    ])
  ],
  providers: [ServicoUsuario, ServicoArea, ServicoFornecedor, ServicoEmpresa],
  bootstrap: [AppComponent]
})
export class AppModule { }
