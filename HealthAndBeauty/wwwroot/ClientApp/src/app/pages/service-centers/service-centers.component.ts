import { Component, OnInit } from '@angular/core';
import { ServiceCenterService } from '../../services/service-center.service';
import ServiceCenter from '../../models/service-center';

@Component({
  selector: 'app-service-centers',
  templateUrl: './service-centers.component.html',
  styleUrls: ['./service-centers.component.scss']
})
export class ServiceCentersComponent implements OnInit {

  serviceCenters: ServiceCenter[];

  constructor(private service: ServiceCenterService) { }

  ngOnInit() {
    this.getServiceCenters();
  }

  getServiceCenters(): void {
    this.service.getServiceCenters().subscribe(serviceCenters => this.serviceCenters = serviceCenters);
  }
}
