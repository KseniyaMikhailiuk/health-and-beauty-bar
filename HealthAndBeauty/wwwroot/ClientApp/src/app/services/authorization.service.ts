import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Register } from '../models/register';
import { Login } from '../models/login';

const routes = {
  register: () => 'api/account/register',
  login: () => 'api/account/login'
}

@Injectable({
  providedIn: 'root'
})
export class AuthorizationService {

  constructor(
    private httpClient: HttpClient
  ) { }

  register(registrationInfo: Register): Observable<any> {
    return this.httpClient.post(routes.register(), registrationInfo)
  }

  login(loginInfo: Login): Observable<any> {
    return this.httpClient.post(routes.login(), loginInfo)
  }
}
