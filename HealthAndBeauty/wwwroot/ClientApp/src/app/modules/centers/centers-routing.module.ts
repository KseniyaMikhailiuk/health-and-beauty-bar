import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { CentersListComponent } from './centers-list/centers-list.component';

const routes: Routes = [
    {
      path: '',
      component: CentersListComponent
    }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class CentersRoutingModule {}