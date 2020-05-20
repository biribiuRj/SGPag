import { Component, OnInit } from "@angular/core";
import { Router } from "@angular/router"
import { Usuario } from "../../modelo/Usuario";
import { ServicoUsuario } from "../../servicos/usuario/servico.usuario";

@Component({
  selector: "cadastro-usuario",
  templateUrl: "./usuario.cadastro.component.html",
  styleUrls: ["./usuario.cadastro.component.css"]
  })

export class CadastrarUsuarioComponent implements OnInit {


  public usuario: Usuario;
  public ativar_spinner: boolean;
  public mensagemSucesso: string;
  public mensagemErro: string;
  public usuarioCadastrado: boolean;

  ngOnInit(): void {
    var usuarioSession = sessionStorage.getItem('usuarioSession');
    if (usuarioSession) {
      this.usuario = JSON.parse(usuarioSession);
    }
    else {
      this.usuario = new Usuario;
    }
  }

  constructor(private servicoUsuario: ServicoUsuario, private router: Router) {
    
      }

  public ativarEspera() {
    this.ativar_spinner = true;
  }
  public desativarEspera() {
    this.ativar_spinner = false;
  }
  public cadastrar() {
    this.ativarEspera();
    this.servicoUsuario.cadastrarUsuario(this.usuario)
      .subscribe(
        usuarioJson => {
          this.usuarioCadastrado = true;
          this.mensagemSucesso = "";
          this.router.navigate(['/manutencao-usuario']);
        },
        e => {
          this.usuarioCadastrado = false;
          this.mensagemErro = e.error;
          this.router.navigate(['/manutencao-usuario']);
        }
      );
  }
  public voltar() {
    this.router.navigate(['/manutencao-usuario']);
  }


}
