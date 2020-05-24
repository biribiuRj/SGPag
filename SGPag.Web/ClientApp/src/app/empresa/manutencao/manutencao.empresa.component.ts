import { Component, OnInit } from "@angular/core";
import { Router } from "@angular/router";
import { ServicoEmpresa } from "../../servicos/empresa/servico.empresa";
import { Empresa } from "../../modelo/empresa";

@Component({
  selector: "app-manutencao-empresa",
  templateUrl: "./manutencao.empresa.component.html",
  styleUrls: ["./manutencao.empresa.component.css"]
})
export class ManutencaoEmpresaComponent implements OnInit {

  constructor(private servicoEmpresa: ServicoEmpresa, private router: Router) { }

  public ativar_spinner: boolean;
  public empresa: Empresa;

  ngOnInit(): void {
    var empresaSession = sessionStorage.getItem('empresaSession');
    if (empresaSession) {
      this.empresa = JSON.parse(empresaSession);
    }
    else {
      this.empresa = new Empresa;
    }
  }
  public ativarEspera() {
    this.ativar_spinner = true;
  }
  public desativarEspera() {
    this.ativar_spinner = false;
  }

  public cadastrar() {
    this.ativarEspera();
    this.servicoEmpresa.cadastrarEmpresa(this.empresa)
      .subscribe(
        usuarioJson => {
          this.router.navigate(['/manutencao-empresa']);
        },
        e => {
          this.router.navigate(['/manutencao-empresa']);
        }
      );
  }
  public voltar() {
    this.router.navigate(['/manutencao-empresa']);
  }

}
