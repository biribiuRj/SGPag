import { Component, OnInit } from "@angular/core";
import { Usuario } from "../../modelo/Usuario";
import { Router, Route, ActivatedRoute } from "@angular/router"
import { UsuarioServico } from "../../servicos/usuario/servico.usuario";

@Component({
  selector: "app-login",
  templateUrl: "./login.component.html",
  styleUrls: ["./login.component.css"/*, bla bla.css, bla*/]
})
export class LoginComponent implements OnInit {
  public usuario;
  //public usuarioAutenticado: boolean;
  public returnUrl: string;
  public mensagem: string;
  private ativar_spinner: boolean;

  //public usuarios = ["usuario1", "usuario2", "usuario3", "usuario4", "usuario5"]

  constructor(private router: Router, private activetedRouter: ActivatedRoute, private usuarioServico: UsuarioServico) {
  }
  ngOnInit(): void {
    this.returnUrl = this.activetedRouter.snapshot.queryParams['returnUrl'];
    this.usuario = new Usuario();
  }

  entrar() {

    this.ativar_spinner = true;

    this.usuarioServico.verificarUsuario(this.usuario).subscribe(
      usuario_json => {
        this.usuarioServico.usuario = usuario_json;

        if (this.returnUrl == null) {
          this.router.navigate(['/']);
        } else {
          this.router.navigate([this.returnUrl]);
        }

      },
      err => {

        console.log(err.error);
        this.mensagem = err.error;
        this.ativar_spinner = false;
      }

    );
  }
  public titulo = "Imagem padrão do Site";
}
