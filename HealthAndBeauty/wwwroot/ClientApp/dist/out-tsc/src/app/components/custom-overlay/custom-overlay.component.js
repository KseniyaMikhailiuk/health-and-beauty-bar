import * as tslib_1 from "tslib";
import { Component, ViewContainerRef, ViewChild } from '@angular/core';
let CustomOverlayComponent = class CustomOverlayComponent {
    constructor(overlayService, resolver) {
        this.overlayService = overlayService;
        this.resolver = resolver;
        overlayService.overlay.subscribe(overlayParams => {
            this.overlayParams = overlayParams;
            if (this.overlayParams) {
                this.showOverlay(overlayParams.componentType);
            }
            else {
                this.hideOverlay();
            }
        });
    }
    ngOnInit() {
    }
    showOverlay(componentType) {
        const factory = this.resolver.resolveComponentFactory(componentType);
        this.componentRef = this.container.createComponent(factory);
    }
    hideOverlay() {
        if (this.componentRef) {
            this.overlayParams.returnData$.next(this.componentRef.instance.data);
            this.componentRef.destroy();
            this.componentRef = null;
        }
    }
};
tslib_1.__decorate([
    ViewChild('overlayContent', { read: ViewContainerRef, static: false })
], CustomOverlayComponent.prototype, "container", void 0);
CustomOverlayComponent = tslib_1.__decorate([
    Component({
        selector: 'app-custom-overlay',
        templateUrl: './custom-overlay.component.html',
        styleUrls: ['./custom-overlay.component.scss']
    })
], CustomOverlayComponent);
export { CustomOverlayComponent };
//# sourceMappingURL=custom-overlay.component.js.map