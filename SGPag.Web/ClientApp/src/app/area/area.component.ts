import { Component, OnInit } from "@angular/core";
import { Router } from "@angular/router"
import { Area } from "../modelo/area";
import { ServicoArea } from "../servicos/area/servico.area";

@Component({
  selector: "app-manutencao-area",
  templateUrl: "./area.component.html",
  styleUrls: ["./area.component.css"]

})

export class AreaComponent implements OnInit {

  public areas: Area[];
  public area: Area;
  public ativar_spinner: boolean;
  public mensagem: string;

  ngOnInit(): void {

  }

  constructor(private ServicoArea: ServicoArea, private router: Router) {
    this.ServicoArea.obterTodos().subscribe(
      areas => {
        this.areas = areas;
      },
      e => {
        console.log(e.error);
      }
    )
  }

  public adicionarArea() {
    sessionStorage.setItem('areaSession', "");
    return this.router.navigate(['/cadastrar-area']);
  }

  public deletarArea(area: Area) {
    var retorno = confirm("Deseja realmente deletar a Area?");
    if (retorno == true) {
      this.ServicoArea.deletarArea(area).subscribe(
        areas => {
          this.areas = areas;
        },
        e => {

        });
    }
  }
  public editarArea(area: Area) {
    sessionStorage.setItem('areaSession', JSON.stringify(area));
    this.router.navigate(['/cadastrar-area']);
  }
}

