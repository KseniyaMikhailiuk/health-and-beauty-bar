import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CenterAdminRoutingModule } from './center-admin-routing.module';
import { CenterAdminComponent } from './center-admin/center-admin.component';
import { CenterAdminInfoComponent } from 'src/app/modules/center-admin/center-admin-info/center-admin-info.component';
import { CenterAdminServicesComponent } from 'src/app/modules/center-admin/center-admin-services/center-admin-services.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MatSelectModule } from '@angular/material/select';
import { CenterAdminWorkingHoursComponent } from './center-admin-working-hours/center-admin-working-hours.component';
import { NgxMaterialTimepickerModule } from 'ngx-material-timepicker';

@NgModule({
  declarations: [
    CenterAdminComponent,
    CenterAdminInfoComponent,
    CenterAdminServicesComponent,
    CenterAdminWorkingHoursComponent
  ],
  imports: [
    CommonModule,
    CenterAdminRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    MatSelectModule,
    NgxMaterialTimepickerModule,
  ]
})
export class CenterAdminModule { }
