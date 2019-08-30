import * as tslib_1 from "tslib";
import { Component, Input } from '@angular/core';
let CategoriesComponent = class CategoriesComponent {
    constructor(categoriesService) {
        this.categoriesService = categoriesService;
        this.data = [];
    }
    ngOnInit() {
        this.getCategories();
    }
    getCategories() {
        this.categoriesService.getCategories().subscribe(categories => this.categories = categories);
    }
    showServices(id) {
        this.services = this.categories.find(category => category.id === id).services;
    }
    manageServiceFilter(event, id) {
        if (event.checked) {
            this.data.push(id);
        }
        else {
            this.data = this.data.filter(item => item === id);
        }
    }
};
tslib_1.__decorate([
    Input()
], CategoriesComponent.prototype, "categories", void 0);
tslib_1.__decorate([
    Input()
], CategoriesComponent.prototype, "services", void 0);
CategoriesComponent = tslib_1.__decorate([
    Component({
        selector: 'app-list-filters',
        templateUrl: './categories.component.html',
        styleUrls: ['./categories.component.scss']
    })
], CategoriesComponent);
export { CategoriesComponent };
//# sourceMappingURL=categories.component.js.map