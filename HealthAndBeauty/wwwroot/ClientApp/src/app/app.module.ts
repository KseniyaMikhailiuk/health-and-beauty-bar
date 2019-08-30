import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ServiceCentersListComponent } from './components/service-centers-list/service-centers-list.component';
import { ServiceCentersComponent } from './pages/service-centers/service-centers.component';
import { HeaderComponent } from './components/header/header.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatIconModule } from '@angular/material';
import { MatCheckboxModule } from '@angular/material/checkbox';
import { CategoriesComponent } from './components/categories/categories.component';
import { ServicesComponent } from './components/services/services.component';
import { CustomOverlayComponent } from './components/custom-overlay/custom-overlay.component';
import { HttpClientModule } from '@angular/common/http';

@NgModule({
  declarations: [
    AppComponent,
    ServiceCentersListComponent,
    ServiceCentersComponent,
    HeaderComponent,
    CategoriesComponent,
    ServicesComponent,
    CustomOverlayComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    MatIconModule,
    MatCheckboxModule,
    BrowserAnimationsModule,
    HttpClientModule
  ],
  entryComponents: [CategoriesComponent],
  bootstrap: [AppComponent]
})
export class AppModule { }
