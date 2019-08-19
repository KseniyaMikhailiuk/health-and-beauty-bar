import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ServiceCentresComponent } from './service-centres.component';

describe('ServiceCentresComponent', () => {
  let component: ServiceCentresComponent;
  let fixture: ComponentFixture<ServiceCentresComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ServiceCentresComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ServiceCentresComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
