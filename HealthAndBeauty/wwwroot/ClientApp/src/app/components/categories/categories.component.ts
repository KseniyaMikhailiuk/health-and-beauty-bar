import { Component, OnInit, Input, OnDestroy } from '@angular/core';
import Category from '../../models/category';
import {CategoriesService} from '../../services/categories.service';
import { ServiceCenterService } from 'src/app/services/service-center.service';
import Service from 'src/app/models/service';

@Component({
  selector: 'app-list-filters',
  templateUrl: './categories.component.html',
  styleUrls: ['./categories.component.scss']
})
export class CategoriesComponent implements OnInit {

  @Input() categories: Category[];
  @Input() services: Service[];

  data: any[] = [];


  constructor(
    private categoriesService: CategoriesService
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

  manageServiceFilter(event: any, id: number) {
    if (event.checked) {
      this.data.push(id);
    } else {
      this.data = this.data.filter(item => item === id);
    }
  }
}
