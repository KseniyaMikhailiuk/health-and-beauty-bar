import * as tslib_1 from "tslib";
import { Injectable } from '@angular/core';
import { BehaviorSubject, Subject } from 'rxjs';
let OverlayService = class OverlayService {
    constructor() {
        this.currentOverlay = new BehaviorSubject(null);
    }
    get overlay() {
        return this.currentOverlay.asObservable();
    }
    openOverlay(componentType) {
        const result$ = new Subject();
        this.currentOverlay.next({ componentType, returnData$: result$ });
        return result$;
    }
};
OverlayService = tslib_1.__decorate([
    Injectable({
        providedIn: 'root'
    })
], OverlayService);
export { OverlayService };
//# sourceMappingURL=overlay.service.js.map