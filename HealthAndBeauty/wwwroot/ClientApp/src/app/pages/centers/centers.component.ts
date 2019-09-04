import { Component, OnInit } from '@angular/core';
import { CenterService } from '../../services/center.service';
import Center from '../../models/center';

@Component({
  selector: 'app-service-centers',
  templateUrl: './centers.component.html',
  styleUrls: ['./centers.component.scss']
})
export class CentersComponent implements OnInit {

  serviceCenters: Center[];

  constructor(
    private centersService: CenterService
  ) { }

  ngOnInit() {
    this.getCenters();
  }

  getCenters(): void {
    this.centersService.getAll()
    .subscribe(serviceCenters =>
      this.serviceCenters = serviceCenters
    );
  }

}
