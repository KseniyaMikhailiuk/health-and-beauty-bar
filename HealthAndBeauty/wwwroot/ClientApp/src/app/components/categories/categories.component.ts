import { Component, OnInit, Input } from '@angular/core';
import ServiceCategory from '../../models/service-category';
import {CategoriesService} from '../../services/categories.service';
import {OverlayService} from '../../services/overlay.service';

@Component({
  selector: 'app-list-filters',
  templateUrl: './categories.component.html',
  styleUrls: ['./categories.component.scss']
})
export class CategoriesComponent implements OnInit {

  @Input() categories: ServiceCategory[];

  constructor(
    private categoriesService: CategoriesService,
    private overlayService: OverlayService
  ) { }

  ngOnInit() {
    this.getCategories();
  }

  getCategories(): void {
    this.categoriesService.getCategories().subscribe(categories => this.categories = categories);
  }
}
