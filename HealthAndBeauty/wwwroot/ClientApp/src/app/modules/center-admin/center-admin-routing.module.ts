import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { CenterAdminComponent } from './center-admin/center-admin.component';
import { AdminCenterInfoComponent } from 'src/app/modules/center-admin/center-admin-info/center-admin-info.component';
import { AdminCenterServicesComponent } from 'src/app/modules/center-admin/center-admin-services/center-admin-services.component';

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
          component: AdminCenterInfoComponent,
        },
        {
          path: 'services',
          component: AdminCenterServicesComponent,
        }
      ]
    }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class CenterAdminRoutingModule {}