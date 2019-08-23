import { Component, OnInit, Input } from '@angular/core';
import ServiceCategory from '../../models/service-category';

@Component({
  selector: 'app-list-filters',
  templateUrl: './list-filters.component.html',
  styleUrls: ['./list-filters.component.scss']
})
export class ListFiltersComponent implements OnInit {

  @Input() filterCategories: ServiceCategory[

    ];

  constructor() { }

  ngOnInit() {
  }

}
