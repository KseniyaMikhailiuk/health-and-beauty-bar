import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ServiceCentersListComponent } from './components/service-centers-list/service-centers-list.component';
import { ServiceCenterComponent } from './components/service-center/service-center.component';
import { ServiceCentersComponent } from './pages/service-centers/service-centers.component';
import { HeaderComponent } from './components/header/header.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatIconModule } from '@angular/material';
import { BarRatingModule } from "ngx-bar-rating";

@NgModule({
  declarations: [
    AppComponent,
    ServiceCentersListComponent,
    ServiceCenterComponent,
    ServiceCentersComponent,
    HeaderComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    MatIconModule,
    BrowserAnimationsModule,
    BarRatingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
