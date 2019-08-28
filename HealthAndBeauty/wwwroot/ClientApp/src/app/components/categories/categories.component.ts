import { Component, OnInit, Input, OnDestroy } from '@angular/core';
import ServiceCategory from '../../models/service-category';
import {CategoriesService} from '../../services/categories.service';
import { ServiceCenterService } from 'src/app/services/service-center.service';
import Service from 'src/app/models/service';

@Component({
  selector: 'app-list-filters',
  templateUrl: './categories.component.html',
  styleUrls: ['./categories.component.scss']
})
export class CategoriesComponent implements OnInit {

  @Input() categories: ServiceCategory[];
  @Input() services: Service[];

  data: any[];


  constructor(
    private categoriesService: CategoriesService,
    private serviceCentersService: ServiceCenterService
  ) { }

  ngOnInit() {
    this.getCategories();
  }

  getCategories(): void {
    this.categoriesService.getCategories().subscribe(categories => this.categories = categories);
  }

  showServices(id: number): void {
    this.services = this.categories.find(category => category.id === id).services;
  }
}
