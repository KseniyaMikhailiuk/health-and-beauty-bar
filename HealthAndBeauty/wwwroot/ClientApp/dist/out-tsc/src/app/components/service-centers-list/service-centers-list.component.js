import * as tslib_1 from "tslib";
import { Component, Input } from '@angular/core';
import { CategoriesComponent } from '../categories/categories.component';
let ServiceCentersListComponent = class ServiceCentersListComponent {
    constructor(overlayService, serviceCentersService) {
        this.overlayService = overlayService;
        this.serviceCentersService = serviceCentersService;
    }
    ngOnInit() {
    }
    showFilters() {
        this.overlayService
            .openOverlay(CategoriesComponent)
            .subscribe(data => this.serviceCentersService.getFilteredLServiceCenters(data));
    }
};
tslib_1.__decorate([
    Input()
], ServiceCentersListComponent.prototype, "selectedFilters", void 0);
tslib_1.__decorate([
    Input()
], ServiceCentersListComponent.prototype, "serviceCentersList", void 0);
ServiceCentersListComponent = tslib_1.__decorate([
    Component({
        selector: 'app-service-centers-list',
        templateUrl: './service-centers-list.component.html',
        styleUrls: ['./service-centers-list.component.scss']
    })
], ServiceCentersListComponent);
export { ServiceCentersListComponent };
//# sourceMappingURL=service-centers-list.component.js.map