import * as tslib_1 from "tslib";
import { Injectable } from '@angular/core';
import { of } from 'rxjs';
const routes = {
    getCenters: () => 'api/centers/'
};
let ServiceCenterService = class ServiceCenterService {
    constructor(httpClient) {
        this.httpClient = httpClient;
        this.serviceCenters = [
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
    }
    getCenters() {
        return this.httpClient.get(routes.getCenters());
    }
    getFilteredLServiceCenters(filteres) {
        return of(this.serviceCenters);
    }
};
ServiceCenterService = tslib_1.__decorate([
    Injectable({
        providedIn: 'root'
    })
], ServiceCenterService);
export { ServiceCenterService };
//# sourceMappingURL=service-center.service.js.map