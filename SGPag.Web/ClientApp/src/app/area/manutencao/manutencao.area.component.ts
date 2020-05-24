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
  public ativar_spinner: boolean;

  ngOnInit(): void {
    var areaSession = sessionStorage.getItem('areaSession');
    if (areaSession) {
      this.area = JSON.parse(areaSession);
    }
    else {
      this.area = new Area;
    }
  }

  constructor(private servicoArea: ServicoArea, private router: Router) {

  }
  public ativarEspera() {
    this.ativar_spinner = true;
  }
  public desativarEspera() {
    this.ativar_spinner = false;
  }

  public cadastrar() {
    this.ativarEspera();
    this.servicoArea.cadastrarArea(this.area)
      .subscribe(
        usuarioJson => {
          this.router.navigate(['/manutencao-area']);
        },
        e => {
          this.router.navigate(['/manutencao-area']);
        }
      );
  }
  public voltar() {
    this.router.navigate(['/manutencao-area']);
  }
}
