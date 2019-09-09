import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { AuthorizationService } from 'src/app/services/authorization.service';

const defaultValues = {
  email: '',
  password: ''
}

@Component({
  selector: 'app-log-in',
  templateUrl: './log-in.component.html',
  styleUrls: ['./log-in.component.scss']
})
export class LogInComponent implements OnInit {
  loginForm: FormGroup;

  constructor(
    private formBuilder: FormBuilder,
    private authorizationService: AuthorizationService
  ) {
    this.loginForm = formBuilder.group(defaultValues);
  }

  login(formValues) {
    this.authorizationService.login(formValues);
  }

  ngOnInit() {
  }

}
