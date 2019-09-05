import {Component, OnInit, Input} from '@angular/core';
import Center from '../../../models/center';
import {CategoriesComponent} from '../categories/categories.component';
import {OverlayService} from '../../../services/overlay.service';
import Service from '../../../models/service';
import { CenterService } from '../../../services/center.service';


@Component({
  selector: 'app-centers-list',
  templateUrl: './centers-list.component.html',
  styleUrls: ['./centers-list.component.scss']
})
export class CentersListComponent implements OnInit {
  @Input() selectedFilters: Service[];
  serviceCenters: Center[] = [];
  constructor(
    private overlayService: OverlayService,
    private serviceCentersService: CenterService,
    private centerService: CenterService
  ) {
    this.getCenters();
  }

  ngOnInit() {

  }

  showFilters(): void {
    this.overlayService
      .openOverlay(CategoriesComponent)
      .subscribe(
        data => this.serviceCentersService.getFilteredLServiceCenters(data)
      );
  }

  getCenters(): void {
    this.centerService
      .getAll()
      .subscribe(serviceCenters =>
        this.serviceCenters = serviceCenters
      );
  }
}
