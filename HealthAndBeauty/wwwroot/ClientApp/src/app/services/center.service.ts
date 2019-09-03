import { Injectable, APP_ID } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, of } from 'rxjs';

import Center from '../models/center';

const routes = {
  getCenters: () => 'api/centers/',
  create: () => 'api/centers/'
}


@Injectable({
  providedIn: 'root'
})
export class CenterService {

  constructor(private httpClient: HttpClient) { }

  private serviceCenters:
  Center[] = [
    // { id: 11, name: 'Dr Nice', mainImageUrl: 'https://picsum.photos/id/237/500/300', address: 'пр-т. Победителей 84, Минск', distance: 1, rating: 4.5 },
    // { id: 12, name: 'Narco', mainImageUrl: 'https://picsum.photos/id/237/500/300', address: 'пр-т. Победителей 84, Минск', distance: 5, rating: 4.5 },
    // { id: 13, name: 'Bombasto', mainImageUrl: 'https://picsum.photos/id/237/500/300', address: 'пр-т. Победителей 84, Минск', distance: 5, rating: 4.5 },
    // { id: 14, name: 'Celeritas', mainImageUrl: 'https://picsum.photos/id/237/500/300', address: 'пр-т. Победителей 84, Минск', distance: 5, rating: 4.5 },
    // { id: 15, name: 'Magneta', mainImageUrl: 'https://picsum.photos/id/237/500/300', address: 'пр-т. Победителей 84, Минск', distance: 5, rating: 4.5 },
    // { id: 16, name: 'RubberMan', mainImageUrl: 'https://picsum.photos/id/237/500/300', address: 'пр-т. Победителей 84, Минск', distance: 5, rating: 4.5 },
    // { id: 17, name: 'Dynama', mainImageUrl: 'https://picsum.photos/id/237/500/300', address: 'пр-т. Победителей 84, Минск', distance: 5, rating: 4.5 },
    // { id: 18, name: 'Dr IQ', mainImageUrl: 'https://picsum.photos/id/237/500/300', address: 'пр-т. Победителей 84, Минск', distance: 5, rating: 4.5 },
    // { id: 19, name: 'Magma', mainImageUrl: 'https://picsum.photos/id/237/500/300', address: 'пр-т. Победителей 84, Минск', distance: 5, rating: 4.5 },
    // { id: 20, name: 'Tornado', mainImageUrl: 'https://picsum.photos/id/237/500/300', address: 'пр-т. Победителей 84, Минск', distance: 5, rating: 4.5 }
  ];

  getCenters(): Observable<
  Center[]> {
    return this.httpClient.get<
    Center[]>(routes.getCenters());
  }

  create(center: Center): Observable<number> {
    return this.httpClient.post<number>(routes.create(), center)
  }

  getFilteredLServiceCenters(filteres): Observable<
  Center[]> {
    return of(this.serviceCenters);
  }
}
