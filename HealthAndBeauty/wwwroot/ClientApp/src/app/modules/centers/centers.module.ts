import { NgModule } from "@angular/core";
import { CommonModule } from '@angular/common';
import { MatCheckboxModule } from '@angular/material/checkbox';
import { CentersListComponent } from './centers-list/centers-list.component';
import { CategoriesComponent } from './categories/categories.component';
import { CentersRoutingModule } from './centers-routing.module';

@NgModule({
  declarations: [
    CentersListComponent,
    CategoriesComponent
  ],
  imports: [
    CommonModule,
    MatCheckboxModule,
    CentersRoutingModule
  ],
  entryComponents: [CategoriesComponent]
})
export class CentersModule { }