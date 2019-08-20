import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import ServiceCenter from '../models/service-center';

@Injectable({
  providedIn: 'root'
})
export class ServiceCenterService {

  private serviceCenters: ServiceCenter[] = [
    { id: 11, name: 'Dr Nice', imageUrl: 'https://picsum.photos/200', address: '' },
    { id: 12, name: 'Narco', imageUrl: 'https://picsum.photos/200', address: '' },
    { id: 13, name: 'Bombasto', imageUrl: 'https://picsum.photos/200', address: '' },
    { id: 14, name: 'Celeritas', imageUrl: 'https://picsum.photos/200', address: '' },
    { id: 15, name: 'Magneta', imageUrl: 'https://picsum.photos/200', address: '' },
    { id: 16, name: 'RubberMan', imageUrl: 'https://picsum.photos/200', address: '' },
    { id: 17, name: 'Dynama', imageUrl: 'https://picsum.photos/200', address: '' },
    { id: 18, name: 'Dr IQ', imageUrl: 'https://picsum.photos/200', address: '' },
    { id: 19, name: 'Magma', imageUrl: 'https://picsum.photos/200', address: '' },
    { id: 20, name: 'Tornado', imageUrl: 'https://picsum.photos/200', address: '' }
  ];

  getServiceCenters(): Observable<ServiceCenter[]> {
    return of(this.serviceCenters);
  }

  constructor() { }
}
