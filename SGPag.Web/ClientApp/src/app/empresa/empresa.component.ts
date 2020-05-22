import { Component, OnInit } from "@angular/core";
import { Router } from "@angular/router"
import { Empresa } from "../modelo/empresa";
import { ServicoEmpresa } from "../servicos/empresa/servico.empresa";

@Component({
  selector: "app-manutencao-empresa",
  templateUrl: "./empresa.component.html",
  styleUrls: ["./empresa.component.css"]

})

export class EmpresaComponent implements OnInit {

  public empresas: Empresa[];
  public empresa: Empresa;
  public ativar_spinner: boolean;
  public mensagem: string;

  ngOnInit(): void {

  }

  constructor(private ServicoEmpresa: ServicoEmpresa, private router: Router) {
    this.ServicoEmpresa.obterTodos().subscribe(
      empresas => {
        this.empresas = empresas;
      },
      e => {
        console.log(e.error);
      }
    )
  }

  public adicionarEmpresa() {
    sessionStorage.setItem('empresaSession', "");
    return this.router.navigate(['/cadastrar-empresa']);
  }

  public editarEmpresa(empresa: Empresa) {
    sessionStorage.setItem('empresaSession', JSON.stringify(empresa));
    this.router.navigate(['/cadastrar-empresa']);
  }
}

