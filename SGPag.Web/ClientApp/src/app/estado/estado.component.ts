import { Component, OnInit } from "@angular/core";
import { Router } from "@angular/router"
import { Estado } from "../modelo/estado";
import { ServicoEstado } from "../servicos/estado/servico.estado";

@Component({
  selector: "app-manutencao-estado",
  templateUrl: "./estado.component.html",
  styleUrls: ["./estado.component.css"]

})

export class EstadoComponent implements OnInit {

  public estados: Estado[];
  public estado: Estado;
  public ativar_spinner: boolean;
  public mensagem: string;

  ngOnInit(): void {

  }

  constructor(private ServicoEstado: ServicoEstado, private router: Router) {
    this.ServicoEstado.obterTodos().subscribe(
      estados => {
        this.estados = estados;
      },
      e => {
        console.log(e.error);
      }
    )
  }

  public adicionarEstado() {
    sessionStorage.setItem('estadoSession', "");
    return this.router.navigate(['/cadastrar-estado']);
  }

  public editarEstado(estado: Estado) {
    sessionStorage.setItem('estadoSession', JSON.stringify(estado));
    this.router.navigate(['/cadastrar-estado']);
  }
}

