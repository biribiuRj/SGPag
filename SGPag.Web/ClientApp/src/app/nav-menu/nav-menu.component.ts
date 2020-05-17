import { Component } from '@angular/core';
import { Router, Route } from '@angular/router';
import { ServicoUsuario } from '../servicos/usuario/servico.usuario';


@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent {
  isExpanded = false;

  constructor(private router: Router, private ServicoUsuario: ServicoUsuario) {
  }

  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }

  public usuarioLogado(): boolean {

    return this.ServicoUsuario.usuario_autenticado();

  }

  public sair() {
    this.ServicoUsuario.limpar_sessao();
    this.router.navigate(['/'])
  }
  get usuario() {
    return this.ServicoUsuario.usuario;
  }
}
