import {Component, OnInit, Input, HostBinding, ComponentFactoryResolver, ViewContainerRef, ViewChild, ComponentRef} from '@angular/core';
import {OverlayService} from '../../services/overlay.service';
import { OverlayParams } from 'src/app/models/overlay-params';

@Component({
  selector: 'app-custom-overlay',
  templateUrl: './custom-overlay.component.html',
  styleUrls: ['./custom-overlay.component.scss']
})
export class CustomOverlayComponent implements OnInit {

  @ViewChild('overlayContent', { read: ViewContainerRef, static: false }) container;
  componentRef: ComponentRef<any>;
  overlayParams: OverlayParams;

  constructor(private overlayService: OverlayService, private resolver: ComponentFactoryResolver) {
    overlayService.overlay.subscribe(overlayParams => {
      this.overlayParams = overlayParams;
      if (this.overlayParams) {
        this.showOverlay(overlayParams.componentType);
      } else {
        this.hideOverlay();
      }
    });
  }

  ngOnInit() {
  }

  public showOverlay(componentType): void {
    const factory = this.resolver.resolveComponentFactory(componentType);
    this.componentRef = this.container.createComponent(factory);
  }

  public hideOverlay(): void {
    if (this.componentRef) {
      this.overlayParams.returnData$.next(this.componentRef.instance.data);
      this.componentRef.destroy();
      this.componentRef = null;
    }
  }
}
