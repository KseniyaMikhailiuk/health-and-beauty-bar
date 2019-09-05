import { NgModule } from "@angular/core";
import { CommonModule } from '@angular/common';
import { HeaderComponent } from './header/header.component';
import { MatIconModule } from '@angular/material';
import { CustomOverlayComponent } from './custom-overlay/custom-overlay.component';

@NgModule({
  declarations: [
    HeaderComponent,
    CustomOverlayComponent
  ],
  imports: [
    CommonModule,
    MatIconModule
  ]
})
export class SharedModule { }