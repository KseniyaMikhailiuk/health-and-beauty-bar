import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LogInComponent } from './log-in/log-in.component';
import { RegisterComponent } from './register/register.component';
import { AuthorizationRoutingModule } from './authorization-routing.module';



@NgModule({
  declarations: [
    LogInComponent,
    RegisterComponent
  ],
  imports: [
    CommonModule,
    AuthorizationRoutingModule
  ]
})
export class AuthorizationModule { }
