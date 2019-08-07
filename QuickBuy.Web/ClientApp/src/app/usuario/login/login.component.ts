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

  constructor(private router: Router, private activatedRouter: ActivatedRoute, private usuarioServico: UsuarioServico) {
  }

  ngOnInit(): void {
    this.usuario = new Usuario();
    this.returnUrl = this.activatedRouter.snapshot.queryParams['returnUrl'];
  }

  entrar() {

    this.usuarioServico.VerificarUsuario(this.usuario).subscribe(
      data => {

      },
      err => {

      }
    );
    
  }
}
