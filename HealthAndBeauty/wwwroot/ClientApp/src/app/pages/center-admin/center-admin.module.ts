import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CenterAdminRoutingModule } from './center-admin-routing.module';
import { CenterAdminComponent } from './center-admin.component';
import { AdminCenterInfoComponent } from 'src/app/components/admin-center-info/admin-center-info.component';
import { AdminCenterServicesComponent } from 'src/app/components/admin-center-services/admin-center-services.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MatSelectModule } from '@angular/material/select';



@NgModule({
  declarations: [
    CenterAdminComponent,
    AdminCenterInfoComponent,
    AdminCenterServicesComponent
  ],
  imports: [
    CommonModule,
    CenterAdminRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    MatSelectModule
  ]
})
export class CenterAdminModule { }
