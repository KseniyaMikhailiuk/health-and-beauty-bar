import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ServiceCentersListComponent } from './components/service-centers-list/service-centers-list.component';
import { ServiceCentersComponent } from './pages/service-centers/service-centers.component';
import { HeaderComponent } from './components/header/header.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatIconModule } from '@angular/material';
import {MatExpansionModule} from '@angular/material/expansion';
import { BarRatingModule } from 'ngx-bar-rating';
import { CategoriesComponent } from './components/categories/categories.component';
import {FullscreenOverlayContainer, OverlayContainer, OverlayModule} from '@angular/cdk/overlay';
import { ServicesComponent } from './components/services/services.component';

@NgModule({
  declarations: [
    AppComponent,
    ServiceCentersListComponent,
    ServiceCentersComponent,
    HeaderComponent,
    CategoriesComponent,
    ServicesComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    MatIconModule,
    MatExpansionModule,
    BrowserAnimationsModule,
    BarRatingModule,
    OverlayModule
  ],
  entryComponents: [CategoriesComponent],
  providers: [{ provide: OverlayContainer, useClass: FullscreenOverlayContainer}],
  bootstrap: [AppComponent]
})
export class AppModule { }
