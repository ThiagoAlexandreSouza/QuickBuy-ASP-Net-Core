import { Component, OnInit } from "@angular/core";
import { Usuario } from "../../modelo/usuario";
import { Router, ActivatedRoute } from "@angular/router";
import { UsuarioServico } from "../../servico/usuario/usuario.servico";

@Component({
  selector: "app-login",
  templateUrl: "./login.component.html",
  styleUrls:["./login.component.css"]
})
export class LoginComponent implements OnInit {
  public usuario;
  public returnUrl: string;
  public mensagem: string;

  constructor(private router: Router, private activatedRouter: ActivatedRoute, private usuarioServico: UsuarioServico) {
  }

  ngOnInit(): void {
    this.usuario = new Usuario();
    this.returnUrl = this.activatedRouter.snapshot.queryParams['returnUrl'];
  }

  entrar() {

    this.usuarioServico.VerificarUsuario(this.usuario).subscribe(
      data => {
        var usuarioRetorno: Usuario;
        usuarioRetorno = data;
        sessionStorage.setItem("usuario-autenticado", "1");
        sessionStorage.setItem("email-usuario", usuarioRetorno.email);

        alert(this.returnUrl);
        if (this.returnUrl == null) {
          this.router.navigate(['/']);
        }
        else {
          this.router.navigate([this.returnUrl]);
        }
        
      },
      err => {
        this.mensagem = err.error;
      }
    );
    
  }
}
