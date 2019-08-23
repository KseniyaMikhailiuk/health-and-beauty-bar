import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import {ServiceCentersComponent} from './pages/service-centers/service-centers.component';


const routes: Routes = [
  { path: 'service-centers', component: ServiceCentersComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
