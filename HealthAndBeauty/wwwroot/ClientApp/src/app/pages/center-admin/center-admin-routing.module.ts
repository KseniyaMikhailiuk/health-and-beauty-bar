import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { CenterAdminComponent } from './center-admin.component';
import { AdminCenterInfoComponent } from 'src/app/components/admin-center-info/admin-center-info.component';
import { AdminCenterServicesComponent } from 'src/app/components/admin-center-services/admin-center-services.component';

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
        },
        {
          path: '**',
          redirectTo: 'info'
        }
      ]
    }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class CenterAdminRoutingModule {}