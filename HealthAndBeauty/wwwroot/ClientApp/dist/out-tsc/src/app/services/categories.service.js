import * as tslib_1 from "tslib";
import { Injectable } from '@angular/core';
const routes = {
    getAllCategories: () => 'api/categories/'
};
let CategoriesService = class CategoriesService {
    constructor(httpClient) {
        this.httpClient = httpClient;
    }
    getCategories() {
        return this.httpClient.get(routes.getAllCategories());
    }
};
CategoriesService = tslib_1.__decorate([
    Injectable({
        providedIn: 'root'
    })
], CategoriesService);
export { CategoriesService };
//# sourceMappingURL=categories.service.js.map