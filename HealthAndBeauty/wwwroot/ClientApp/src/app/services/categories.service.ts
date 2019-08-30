import { Injectable } from '@angular/core';
import Category from '../models/category';
import { HttpClient } from '@angular/common/http';
import {Observable, of} from 'rxjs';

const routes = {
  getAllCategories: () => 'api/categories/'
}

@Injectable({
  providedIn: 'root'
})
export class CategoriesService {

  constructor(private httpClient: HttpClient) { }

  public getCategories(): Observable<Category[]> {
    return this.httpClient.get<Category[]>(routes.getAllCategories());
  }
}
