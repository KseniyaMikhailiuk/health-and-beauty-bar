import { Component, OnInit, Input } from '@angular/core';
import ServiceCenter from '../../models/service-center';

@Component({
  selector: 'app-service-centers-list',
  templateUrl: './service-centers-list.component.html',
  styleUrls: ['./service-centers-list.component.scss']
})
export class ServiceCentersListComponent implements OnInit {

  @Input() serviceCentersList: ServiceCenter[];

  constructor() { }

  ngOnInit() {
  }

}
