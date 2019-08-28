import { Injectable, Type } from '@angular/core';
import {BehaviorSubject, Observable, Subject} from 'rxjs';
import { OverlayParams } from '../models/overlay-params';

@Injectable({
  providedIn: 'root'
})
export class OverlayService {

  private currentOverlay = new BehaviorSubject<OverlayParams>(null);

  get overlay() {
    return this.currentOverlay.asObservable();
  }

  constructor() { }

  public openOverlay(componentType: Type<any>): Observable<any> {
    const result$ = new Subject<any>();
    this.currentOverlay.next({ componentType, returnData$: result$ });
    return result$;
  }
}
