import {Component, OnInit, Input, Injectable} from '@angular/core';
import ServiceCenter from '../../models/service-center';
import {CategoriesComponent} from '../categories/categories.component';
import {OverlayService} from '../../services/overlay.service';
import Service from '../../models/service';

@Component({
  selector: 'app-service-centers-list',
  templateUrl: './service-centers-list.component.html',
  styleUrls: ['./service-centers-list.component.scss']
})
export class ServiceCentersListComponent implements OnInit {
  @Input() selectedFilters: Service[];
  @Input() serviceCentersList: ServiceCenter[];

  constructor(private overlayService: OverlayService) { }

  ngOnInit() {
  }

  showFilters(): void {
    this.overlayService.openOverlay(CategoriesComponent);
  }

}
