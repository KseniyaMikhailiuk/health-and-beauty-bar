import { Component, OnInit } from '@angular/core';
import {ComponentPortal} from '@angular/cdk/portal';
import {Overlay} from '@angular/cdk/overlay';
import {ListFiltersComponent} from '../list-filters/list-filters.component';

@Component({
  selector: 'app-list-filters-bar',
  templateUrl: './list-filters-bar.component.html',
  styleUrls: ['./list-filters-bar.component.scss']
})
export class ListFiltersBarComponent implements OnInit {

  constructor( private overlay: Overlay) { }

  ngOnInit() {
  }

  onFilterClick(): void {
    const overlayRef = this.overlay.create();
    const userProfilePortal = new ComponentPortal(ListFiltersComponent);
    overlayRef.attach(userProfilePortal);
  }

}
