import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { CenterService } from 'src/app/services/center.service';

const defaultValues = {
  name: '',
  mainImageUrl: '',
  address: ''
}

@Component({
  selector: 'app-admin-center-info',
  templateUrl: './admin-center-info.component.html',
  styleUrls: ['./admin-center-info.component.scss']
})

export class AdminCenterInfoComponent implements OnInit {
  centerForm: FormGroup;

  constructor(private service: CenterService, private formBuilder: FormBuilder) {
    this.centerForm = formBuilder.group(defaultValues);
   }

  ngOnInit() {
  }

  add(formValues) {
    console.log(formValues);
    this.centerForm.reset();
  }

}
