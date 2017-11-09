import { Component, OnInit } from '@angular/core';

import { LoginService } from '../login.service';

@Component({
  selector: 'app-login-form',
  templateUrl: './login-form.component.html',
  styleUrls: ['./login-form.component.css']
})
export class LoginFormComponent implements OnInit {

  constructor(private loginService: LoginService) {  }

  ngOnInit() {
  }

  setNovoUsuario(){
    console.log(this.loginService.novoUsuario);
    this.loginService.setNovoUsuario(true);
    console.log(this.loginService.novoUsuario);
    console.log(this.loginService.eNovoUsuario());
  }

}
