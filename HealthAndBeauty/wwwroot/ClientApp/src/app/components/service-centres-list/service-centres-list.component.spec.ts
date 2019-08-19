import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ServiceCentresListComponent } from './service-centres-list.component';

describe('ServiceCentresListComponent', () => {
  let component: ServiceCentresListComponent;
  let fixture: ComponentFixture<ServiceCentresListComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ServiceCentresListComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ServiceCentresListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
