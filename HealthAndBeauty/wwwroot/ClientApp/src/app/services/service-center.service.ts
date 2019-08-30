import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, of } from 'rxjs';

import ServiceCenter from '../models/service-center';

const routes = {
  getCenters: () => 'api/centers/'
}


@Injectable({
  providedIn: 'root'
})
export class ServiceCenterService {

  constructor(private httpClient: HttpClient) { }

  private serviceCenters: ServiceCenter[] = [
    { id: 11, name: 'Dr Nice', imageUrl: 'https://picsum.photos/id/237/500/300', address: 'пр-т. Победителей 84, Минск', distance: 1, rating: 4.5 },
    { id: 12, name: 'Narco', imageUrl: 'https://picsum.photos/id/237/500/300', address: 'пр-т. Победителей 84, Минск', distance: 5, rating: 4.5 },
    { id: 13, name: 'Bombasto', imageUrl: 'https://picsum.photos/id/237/500/300', address: 'пр-т. Победителей 84, Минск', distance: 5, rating: 4.5 },
    { id: 14, name: 'Celeritas', imageUrl: 'https://picsum.photos/id/237/500/300', address: 'пр-т. Победителей 84, Минск', distance: 5, rating: 4.5 },
    { id: 15, name: 'Magneta', imageUrl: 'https://picsum.photos/id/237/500/300', address: 'пр-т. Победителей 84, Минск', distance: 5, rating: 4.5 },
    { id: 16, name: 'RubberMan', imageUrl: 'https://picsum.photos/id/237/500/300', address: 'пр-т. Победителей 84, Минск', distance: 5, rating: 4.5 },
    { id: 17, name: 'Dynama', imageUrl: 'https://picsum.photos/id/237/500/300', address: 'пр-т. Победителей 84, Минск', distance: 5, rating: 4.5 },
    { id: 18, name: 'Dr IQ', imageUrl: 'https://picsum.photos/id/237/500/300', address: 'пр-т. Победителей 84, Минск', distance: 5, rating: 4.5 },
    { id: 19, name: 'Magma', imageUrl: 'https://picsum.photos/id/237/500/300', address: 'пр-т. Победителей 84, Минск', distance: 5, rating: 4.5 },
    { id: 20, name: 'Tornado', imageUrl: 'https://picsum.photos/id/237/500/300', address: 'пр-т. Победителей 84, Минск', distance: 5, rating: 4.5 }
  ];

  getCenters(): Observable<ServiceCenter[]> {
    return this.httpClient.get<ServiceCenter[]>(routes.getCenters());
  }

  getFilteredLServiceCenters(filteres): Observable<ServiceCenter[]> {
    return of(this.serviceCenters);
  }
}
