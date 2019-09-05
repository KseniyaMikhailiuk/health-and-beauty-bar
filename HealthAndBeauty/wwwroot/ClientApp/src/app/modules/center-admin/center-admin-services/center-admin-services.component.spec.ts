import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AdminCenterServicesComponent } from './center-admin-services.component';

describe('AdminCenterServicesComponent', () => {
  let component: AdminCenterServicesComponent;
  let fixture: ComponentFixture<AdminCenterServicesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AdminCenterServicesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AdminCenterServicesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
