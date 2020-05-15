import { Component, OnInit } from "@angular/core"
import { Router } from "@angular/router";


@Component({
  selector: "manutencao-area",
  templateUrl: "./manutencao.area.component.html",
  styleUrls: ["./manutencao.area.component.css"]
})

export class ManutencaoAreaComponent implements OnInit {
  public produto: Produto
  public arquivoSelecionado: File;
  public ativar_spinner: boolean;
  public mensagemErro: string;


  constructor(private produtoServico: ProdutoServico, private router: Router) {

  }
