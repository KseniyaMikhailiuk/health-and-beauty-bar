import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HttpClientModule } from '@angular/common/http';
import { MatSidenavModule } from '@angular/material/sidenav';
import { CenterAdminModule } from './modules/center-admin/center-admin.module';
import { CentersModule } from './modules/centers/centers.module';
import { CustomOverlayComponent } from './components/custom-overlay/custom-overlay.component';
import { CategoriesComponent } from './modules/centers/categories/categories.component';
import { HeaderComponent } from './components/header/header.component';
import { CommonModule } from '@angular/common';
import { MatIconModule } from '@angular/material';
import { AuthorizationModule } from './modules/authorization/authorization.module';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    CustomOverlayComponent
  ],
  imports: [
    CommonModule,
    BrowserModule,
    AppRoutingModule,
    MatSidenavModule,
    BrowserAnimationsModule,
    HttpClientModule,
    MatIconModule,
    CenterAdminModule,
    CentersModule,
    AuthorizationModule
  ],
  bootstrap: [AppComponent],
  entryComponents: [CategoriesComponent]
})
export class AppModule { }
