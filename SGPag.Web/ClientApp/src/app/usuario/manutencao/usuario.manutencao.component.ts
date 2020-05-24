import { Component, OnInit} from "@angular/core";
import { Router } from "@angular/router"
import { Usuario } from "../../modelo/usuario";
import { ServicoUsuario } from "../../servicos/usuario/servico.usuario";


@Component({
  selector: "app-manutencao-login",
  templateUrl: "./usuario.manutencao.component.html",
  styleUrls: ["./usuario.manutencao.component.css"]

})

export class UsuarioComponent implements OnInit {

  public usuarios: Usuario[];
  public usuario: Usuario;
  public ativar_spinner: boolean;
  public mensagemSucesso: string;
  public usuarioCadastrado: boolean;


  ngOnInit(): void {
    
  }

  constructor(private servicoUsuario: ServicoUsuario, private router: Router) {
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
