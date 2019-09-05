import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { AuthorizationService } from 'src/app/services/authorization.service';

const defaultValues = {
  firstName: '',
  lastName: '',
  email: '',
  password: ''
}

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.scss']
})
export class RegisterComponent implements OnInit {
  registrationForm: FormGroup;

  constructor(
    private formBuilder: FormBuilder,
    private authorizationService: AuthorizationService
  ) {
    this.registrationForm = formBuilder.group(defaultValues);
  }

  ngOnInit() {
  }

  register(formValues) {
    this.authorizationService.register(formValues);
  }

}
