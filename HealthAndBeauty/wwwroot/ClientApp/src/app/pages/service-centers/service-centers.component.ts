import { Component, OnInit } from '@angular/core';
import { ServiceCenterService } from '../../services/service-center.service';
import ServiceCenter from '../../models/service-center';
import {CategoriesService} from '../../services/categories.service';
import ServiceCategory from '../../models/service-category';

@Component({
  selector: 'app-service-centers',
  templateUrl: './service-centers.component.html',
  styleUrls: ['./service-centers.component.scss']
})
export class ServiceCentersComponent implements OnInit {

  serviceCenters: ServiceCenter[];

  constructor(
    private centersService: ServiceCenterService
  ) { }

  ngOnInit() {
    this.getServiceCenters();
  }

  getServiceCenters(): void {
    this.centersService.getServiceCenters().subscribe(serviceCenters => this.serviceCenters = serviceCenters);
  }

}
