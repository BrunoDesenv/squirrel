import { Injectable } from '@angular/core';

@Injectable()
export class LoginService{

    novoUsuario: boolean = false;

    setNovoUsuario(isNew : boolean)
    {
        this.novoUsuario = isNew;
    }

    eNovoUsuario()
    {
       return this.novoUsuario;
    }
}