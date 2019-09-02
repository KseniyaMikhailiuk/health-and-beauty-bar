import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CentersListComponent } from './components/centers-list/centers-list.component';
import { CentersComponent } from './pages/centers/centers.component';
import { HeaderComponent } from './components/header/header.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatIconModule } from '@angular/material';
import { MatCheckboxModule } from '@angular/material/checkbox';
import { CategoriesComponent } from './components/categories/categories.component';
import { CustomOverlayComponent } from './components/custom-overlay/custom-overlay.component';
import { HttpClientModule } from '@angular/common/http';
import { MatSidenavModule } from '@angular/material/sidenav';
import { CenterAdminModule } from './pages/center-admin/center-admin.module';

@NgModule({
  declarations: [
    AppComponent,
    CentersListComponent,
    CentersComponent,
    HeaderComponent,
    CategoriesComponent,
    CustomOverlayComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    MatIconModule,
    MatCheckboxModule,
    MatSidenavModule,
    BrowserAnimationsModule,
    HttpClientModule,
    CenterAdminModule
  ],
  entryComponents: [CategoriesComponent],
  bootstrap: [AppComponent]
})
export class AppModule { }
