import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';


const routes: Routes = [
  { path: 'service-centers', loadChildren: './modules/centers/centers.module#CentersModule'},
  { path: 'admin', loadChildren: './modules/center-admin/center-admin.module#CenterAdminModule'},
  { path: 'authorization', loadChildren: './modules/authorization/authorization.module#AuthorizationModule'}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
