import { Component, OnInit } from "@angular/core";
import { ServicoArea } from "../../servicos/area/servico.area";
import { Router } from "@angular/router";
import { Area } from "../../modelo/area";

@Component({
  selector: "app-manutencao-area",
  templateUrl: "./manutencao.area.component.html",
  styleUrls: ["./manutencao.area.component.css"]
})
export class ManutencaoAreaComponent implements OnInit {

  public area: Area;

  ngOnInit(): void {
   
  }
  constructor(private servicoArea: ServicoArea, private router: Router) { }

}
