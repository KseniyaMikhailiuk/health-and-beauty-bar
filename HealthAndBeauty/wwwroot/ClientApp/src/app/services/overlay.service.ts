import { Injectable } from '@angular/core';
import {ComponentType, Overlay, OverlayRef} from '@angular/cdk/overlay';
import {ComponentPortal} from '@angular/cdk/portal';

@Injectable({
  providedIn: 'root'
})
export class OverlayService {

  private currentOverlay: OverlayRef

  constructor(private overlay: Overlay) { }

  public openOverlay(overlayComponent: ComponentType<object>): void {
    this.currentOverlay = this.overlay.create();
    const filtersOverlay = new ComponentPortal(overlayComponent);
    this.currentOverlay.attach(filtersOverlay);
  }

  public closeOverlay() {
    this.currentOverlay.detach();
  }
}
