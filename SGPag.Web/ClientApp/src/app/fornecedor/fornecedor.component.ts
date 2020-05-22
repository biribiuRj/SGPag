import { Component, OnInit } from "@angular/core";
import { Router } from "@angular/router"
import { Fornecedor } from "../modelo/fornecedor";
import { ServicoFornecedor } from "../servicos/fornecedor/servico.fornecedor";

@Component({
  selector: "app-manutencao-fornecedor",
  templateUrl: "./fornecedor.component.html",
  styleUrls: ["./fornecedor.component.css"]

})

export class FornecedorComponent implements OnInit {

  public fornecedores: Fornecedor[];
  public fornecedor: Fornecedor;
  public ativar_spinner: boolean;
  public mensagem: string;

  ngOnInit(): void {

  }

  constructor(private ServicoFornecedor: ServicoFornecedor, private router: Router) {
    this.ServicoFornecedor.obterTodos().subscribe(
      fornecedor => {
        this.fornecedores = fornecedor;
      },
      e => {
        console.log(e.error);
      }
    )
  }

  public adicionarFornecedor() {
    sessionStorage.setItem('fornecedorSession', "");
    return this.router.navigate(['/cadastrar-fornecedor']);
  }

  public editarFornecedor(fornecedor: Fornecedor) {
    sessionStorage.setItem('fornecedorSession', JSON.stringify(fornecedor));
    this.router.navigate(['/cadastrar-fornecedor']);
  }
}

