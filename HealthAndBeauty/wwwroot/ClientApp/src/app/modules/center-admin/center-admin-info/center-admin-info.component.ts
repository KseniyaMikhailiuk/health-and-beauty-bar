import { Component, OnInit, Input } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { CenterService } from 'src/app/services/center.service';
import { CenterTypeService } from 'src/app/services/center-type.service';
import { CenterType } from 'src/app/models/center-type';

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

  @Input()
  centerTypes: CenterType[];

  constructor(
    private centerService: CenterService,
    private centerTypeService: CenterTypeService,
    private formBuilder: FormBuilder
  ) {
    this.centerForm = formBuilder.group(defaultValues);
    centerTypeService.getAll().subscribe(centerTypes => {
      this.centerTypes = centerTypes;
    })
   }

  ngOnInit() {
  }

  add(formValues) {
    this.centerService.create(formValues).subscribe(id => {alert(id);});
    this.centerForm.reset();
  }

}
