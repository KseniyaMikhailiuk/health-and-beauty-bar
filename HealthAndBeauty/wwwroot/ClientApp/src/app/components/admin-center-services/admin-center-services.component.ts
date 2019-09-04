import { Component, OnInit, Input } from '@angular/core';
import { CategoriesService } from 'src/app/services/categories.service';
import Category from 'src/app/models/category';
import { CenterService } from 'src/app/services/center.service';
import { ActivatedRoute, ParamMap } from '@angular/router';
import { map, switchMap, takeUntil } from 'rxjs/operators';
import { FormGroup, FormBuilder } from '@angular/forms';
import Service from 'src/app/models/service';

const defaultValues = {
  categoryId: 0,
  serviceId: 0,
  price: 0,
  discount: 0
}

@Component({
  selector: 'app-admin-center-services',
  templateUrl: './admin-center-services.component.html',
  styleUrls: ['./admin-center-services.component.scss']
})
export class AdminCenterServicesComponent implements OnInit {
  centerForm: FormGroup;

  @Input() isFormShown: boolean = false;
  categories: Category[];
  services: Service[];
  groupedServices: CenterService[];
  centerId: number;
  constructor(
    private categoryService: CategoriesService,
    private centerService: CenterService,
    private route: ActivatedRoute,
    private formBuilder: FormBuilder
  ) {
    this.centerForm = formBuilder.group(defaultValues);
    categoryService.getCategories().subscribe(categories => this.categories = categories);
    this.route.parent.paramMap
      .pipe(
        map((params: ParamMap) => params.get('id')),
        switchMap((id) => {
          this.centerId = +id;

          return centerService.getServices(this.centerId);
        })
      ).subscribe(services => this.groupedServices = services)
  }

  onCategorySelect(id) {
    this.services = this.categories.find(c => c.id == id).services;
  }

  add(formValues) {
    formValues = {
      ...formValues,
      centerId: this.centerId
    }
    this.centerService.addService(formValues).subscribe(() =>
      this.centerService
        .getServices(this.centerId)
        .subscribe(services => this.groupedServices = services));
    this.centerForm.reset();
  }

  onAddClick() {
    this.isFormShown = !this.isFormShown;
  }
  ngOnInit() {
  }

}
