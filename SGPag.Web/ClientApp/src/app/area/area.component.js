/*import { Component, OnInit } from "@angular/core";
import { Router } from "@angular/router"
import { Area } from "../modelo/area";

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
  public usuarioCadastrado: boolean;

  ngOnInit(): void {

  }

  constructor(private servicoUsuario: ServicoArea, private router: Router) {
    this.servicoUsuario.obterTodos().subscribe(
      usuarios => {
        this.usuarios = usuarios;
      },
      e => {
        console.log(e.error);
      }
    )
  }

  public adicionarUsuario() {
    sessionStorage.setItem('usuarioSession', "");
    return this.router.navigate(['/cadastrar-usuario']);
  }

  public deletarUsuario(usuario: Usuario) {
    var retorno = confirm("Deseja realmente deletar o produto?");
    if (retorno == true) {
      this.servicoUsuario.deletar(usuario).subscribe(
        usuario => {
          this.usuarios = usuario;
        },
        e => {

        });
    }
  }
  public editarUsuario(usuario: Usuario) {
    sessionStorage.setItem('usuarioSession', JSON.stringify(usuario));
    this.router.navigate(['/cadastrar-usuario']);
  }
}
*/
//# sourceMappingURL=area.component.js.map