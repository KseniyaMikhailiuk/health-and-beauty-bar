import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { CenterAdminComponent } from './center-admin/center-admin.component';
import { CenterAdminInfoComponent } from 'src/app/modules/center-admin/center-admin-info/center-admin-info.component';
import { CenterAdminServicesComponent } from 'src/app/modules/center-admin/center-admin-services/center-admin-services.component';
import { CenterAdminWorkingHoursComponent } from './center-admin-working-hours/center-admin-working-hours.component';

const routes: Routes = [
    {
      path: 'centers/:id',
      component: CenterAdminComponent,
      children: [
        {
          path: '',
          redirectTo: 'info',
          pathMatch: 'full'
        },
        {
          path: 'info',
          component: CenterAdminInfoComponent,
        },
        {
          path: 'services',
          component: CenterAdminServicesComponent,
        },
        {
          path: 'working-hours',
          component: CenterAdminWorkingHoursComponent,
        }
      ]
    }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class CenterAdminRoutingModule {}