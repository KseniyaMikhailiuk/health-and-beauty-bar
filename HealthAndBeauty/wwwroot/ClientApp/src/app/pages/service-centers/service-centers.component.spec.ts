import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ServicecentersComponent } from './service-centers.component';

describe('ServicecentersComponent', () => {
  let component: ServicecentersComponent;
  let fixture: ComponentFixture<ServicecentersComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ServicecentersComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ServicecentersComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
