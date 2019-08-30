import * as tslib_1 from "tslib";
import { Component } from '@angular/core';
let ServiceCentersComponent = class ServiceCentersComponent {
    constructor(centersService) {
        this.centersService = centersService;
    }
    ngOnInit() {
        this.getCenters();
    }
    getCenters() {
        this.centersService.getCenters()
            .subscribe(serviceCenters => this.serviceCenters = serviceCenters);
    }
};
ServiceCentersComponent = tslib_1.__decorate([
    Component({
        selector: 'app-service-centers',
        templateUrl: './service-centers.component.html',
        styleUrls: ['./service-centers.component.scss']
    })
], ServiceCentersComponent);
export { ServiceCentersComponent };
//# sourceMappingURL=service-centers.component.js.map