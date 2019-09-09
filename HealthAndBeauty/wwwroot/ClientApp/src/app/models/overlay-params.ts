import { Subject } from 'rxjs';
import { Type } from '@angular/core';

export class OverlayParams {
  componentType: Type<any>;
  returnData$: Subject<any>;
}