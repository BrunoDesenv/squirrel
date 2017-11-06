import { Component, OnInit } from '@angular/core';

import { LoginService } from './../login.service';

@Component({
  selector: 'app-login-new',
  templateUrl: './login-new.component.html',
  styleUrls: ['./login-new.component.css']
})
export class LoginNewComponent implements OnInit {

  constructor(private loginService: LoginService) {  }

  ngOnInit() {
  }

  setLogin(){
    this.loginService.setNovoUsuario(false);
  }

}
