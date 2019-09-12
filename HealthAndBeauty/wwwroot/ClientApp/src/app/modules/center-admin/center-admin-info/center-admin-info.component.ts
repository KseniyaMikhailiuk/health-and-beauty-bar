import { Component, OnInit, Input } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { CenterService } from 'src/app/services/center.service';
import { CenterTypeService } from 'src/app/services/center-type.service';
import { CenterType } from 'src/app/models/center-type';
import { ActivatedRoute, ParamMap } from '@angular/router';
import { map, switchMap } from 'rxjs/operators';
import Center from 'src/app/models/center';
import { MouseEvent } from '@agm/core';
import { MapMarker } from 'src/app/models/map-marker';

const defaultValues = {
  name: '',
  mainImageUrl: '',
  address: '',
  centerTypeId: 0
}

@Component({
  selector: 'app-admin-center-info',
  templateUrl: './center-admin-info.component.html',
  styleUrls: ['./center-admin-info.component.scss']
})

export class CenterAdminInfoComponent implements OnInit {
  centerForm: FormGroup;
  centerId: number;
  center: Center;
  marker: MapMarker = new MapMarker();
  @Input()
  centerTypes: CenterType[];

  constructor(
    private centerService: CenterService,
    private centerTypeService: CenterTypeService,
    private formBuilder: FormBuilder,
    private route: ActivatedRoute
  ) {
    this.centerForm = formBuilder.group(defaultValues);
    centerTypeService.getAll().subscribe(centerTypes => {
      this.centerTypes = centerTypes;
    });
    this.route.parent.paramMap
      .pipe(
        map((params: ParamMap) => params.get('id')),
        switchMap((id) => {
          this.centerId = +id;

          return centerService.getById(this.centerId);
        })
      ).subscribe(center => {
        this.center = center;
        this.centerForm.patchValue(center);
      });
    if (navigator)
    {
      navigator.geolocation.getCurrentPosition( pos => {
        this.marker.lng = +pos.coords.longitude;
        this.marker.lat = +pos.coords.latitude;
        this.marker.draggable = true;
      });
    }
   }

  ngOnInit() {
  }

  add(formValues) {
    this.centerService.create(formValues).subscribe(id => {alert(id);});
    this.centerForm.reset();
  }

  mapClicked($event: MouseEvent) {
    this.marker = {
      ...this.marker,
      lat: $event.coords.lat,
      lng: $event.coords.lng,
      draggable: true
    };
  }
}
