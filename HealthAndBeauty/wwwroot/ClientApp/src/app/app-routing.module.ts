import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import {CentersComponent} from './pages/centers/centers.component';


const routes: Routes = [
  {
    path: '',
    redirectTo: 'service-centers',
    pathMatch: 'full'
  },
  { path: 'service-centers', component: CentersComponent},
  { path: 'admin', loadChildren: './pages/center-admin/center-admin.module#CenterAdminModule'}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
