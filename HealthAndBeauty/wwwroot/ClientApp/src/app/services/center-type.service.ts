import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import {Observable, of} from 'rxjs';
import { CenterType } from '../models/center-type';

const routes = {
  getAll: () => 'api/center-types/'
}

@Injectable({
  providedIn: 'root'
})
export class CenterTypeService {

  constructor(private httpClient: HttpClient) { }

  getAll(): Observable<CenterType[]> {
    return this.httpClient.get<CenterType[]>(routes.getAll());
  }
}
