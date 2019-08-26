import { Injectable } from '@angular/core';
import ServiceCategory from '../models/service-category';
import {Observable, of} from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CategoriesService {

  private categories: ServiceCategory[] = [
    { id: 11, name: 'Dr Nice', services: [    { id: 12, name: 'Narco' },
        { id: 13, name: 'Bombasto' },
        { id: 14, name: 'Celeritas' },
        { id: 15, name: 'Magneta' },
        { id: 16, name: 'RubberMan' },
        { id: 17, name: 'Dynama' },
        { id: 18, name: 'Dr IQ' },
        { id: 19, name: 'Magma' },
        { id: 20, name: 'Tornado' }] },
    { id: 12, name: 'Narco', services: [] },
    { id: 13, name: 'Bombasto', services: [] },
    { id: 14, name: 'Celeritas', services: [] },
    { id: 15, name: 'Magneta', services: [] },
    { id: 16, name: 'RubberMan', services: [] },
    { id: 17, name: 'Dynama', services: [] },
    { id: 18, name: 'Dr IQ', services: [] },
    { id: 19, name: 'Magma', services: [] },
    { id: 20, name: 'Tornado', services: [] }
  ];

  constructor() { }

  public getCategories(): Observable<ServiceCategory[]> {
    return of(this.categories);
  }
}
