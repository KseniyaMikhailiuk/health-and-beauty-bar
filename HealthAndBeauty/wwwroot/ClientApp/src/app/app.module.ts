import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ServiceCentersListComponent } from './components/service-centers-list/service-centers-list.component';
import { ServiceCenterComponent } from './components/service-center/service-center.component';
import { ServiceCentersComponent } from './pages/service-centers/service-centers.component';

@NgModule({
  declarations: [
    AppComponent,
    ServiceCentersListComponent,
    ServiceCenterComponent,
    ServiceCentersComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
