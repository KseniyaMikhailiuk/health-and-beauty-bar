import {Component, OnInit, Input, Injectable, ComponentFactoryResolver} from '@angular/core';
import Center from '../../models/center';
import {CategoriesComponent} from '../categories/categories.component';
import {OverlayService} from '../../services/overlay.service';
import Service from '../../models/service';
import { CenterService } from 'src/app/services/center.service';


@Component({
  selector: 'app-centers-list',
  templateUrl: './centers-list.component.html',
  styleUrls: ['./centers-list.component.scss']
})
export class CentersListComponent implements OnInit {
  @Input() selectedFilters: Service[];
  @Input() serviceCentersList: Center[];
  constructor(private overlayService: OverlayService, private serviceCentersService: CenterService) { }

  ngOnInit() {
  }

  showFilters(): void {
    this.overlayService
      .openOverlay(CategoriesComponent)
      .subscribe(
        data => this.serviceCentersService.getFilteredLServiceCenters(data)
      );
  }
}
