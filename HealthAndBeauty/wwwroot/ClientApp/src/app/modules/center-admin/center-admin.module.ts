import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CenterAdminRoutingModule } from './center-admin-routing.module';
import { CenterAdminComponent } from './center-admin/center-admin.component';
import { AdminCenterInfoComponent } from 'src/app/modules/center-admin/center-admin-info/center-admin-info.component';
import { AdminCenterServicesComponent } from 'src/app/modules/center-admin/center-admin-services/center-admin-services.component';
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
