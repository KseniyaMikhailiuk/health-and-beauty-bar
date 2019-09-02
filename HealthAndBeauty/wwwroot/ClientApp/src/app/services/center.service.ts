import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, of } from 'rxjs';

import ServiceCenter from '../models/center';

const routes = {
  getCenters: () => 'api/centers/'
}


@Injectable({
  providedIn: 'root'
})
export class CenterService {

  constructor(private httpClient: HttpClient) { }

  private serviceCenters: ServiceCenter[] = [
    { id: 11, name: 'Dr Nice', mainImageUrl: 'https://picsum.photos/id/237/500/300', address: 'пр-т. Победителей 84, Минск', distance: 1, rating: 4.5 },
    { id: 12, name: 'Narco', mainImageUrl: 'https://picsum.photos/id/237/500/300', address: 'пр-т. Победителей 84, Минск', distance: 5, rating: 4.5 },
    { id: 13, name: 'Bombasto', mainImageUrl: 'https://picsum.photos/id/237/500/300', address: 'пр-т. Победителей 84, Минск', distance: 5, rating: 4.5 },
    { id: 14, name: 'Celeritas', mainImageUrl: 'https://picsum.photos/id/237/500/300', address: 'пр-т. Победителей 84, Минск', distance: 5, rating: 4.5 },
    { id: 15, name: 'Magneta', mainImageUrl: 'https://picsum.photos/id/237/500/300', address: 'пр-т. Победителей 84, Минск', distance: 5, rating: 4.5 },
    { id: 16, name: 'RubberMan', mainImageUrl: 'https://picsum.photos/id/237/500/300', address: 'пр-т. Победителей 84, Минск', distance: 5, rating: 4.5 },
    { id: 17, name: 'Dynama', mainImageUrl: 'https://picsum.photos/id/237/500/300', address: 'пр-т. Победителей 84, Минск', distance: 5, rating: 4.5 },
    { id: 18, name: 'Dr IQ', mainImageUrl: 'https://picsum.photos/id/237/500/300', address: 'пр-т. Победителей 84, Минск', distance: 5, rating: 4.5 },
    { id: 19, name: 'Magma', mainImageUrl: 'https://picsum.photos/id/237/500/300', address: 'пр-т. Победителей 84, Минск', distance: 5, rating: 4.5 },
    { id: 20, name: 'Tornado', mainImageUrl: 'https://picsum.photos/id/237/500/300', address: 'пр-т. Победителей 84, Минск', distance: 5, rating: 4.5 }
  ];

  getCenters(): Observable<ServiceCenter[]> {
    return this.httpClient.get<ServiceCenter[]>(routes.getCenters());
  }

  getFilteredLServiceCenters(filteres): Observable<ServiceCenter[]> {
    return of(this.serviceCenters);
  }
}
