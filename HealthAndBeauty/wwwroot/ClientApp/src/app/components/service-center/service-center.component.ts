import { Component, OnInit, Input } from '@angular/core';
import ServiceCenter from '../../models/service-center';

@Component({
  selector: 'app-service-center',
  templateUrl: './service-center.component.html',
  styleUrls: ['./service-center.component.scss']
})
export class ServiceCenterComponent implements OnInit {

  @Input() serviceCenter: ServiceCenter;

  constructor() { }

  ngOnInit() {
  }

}
