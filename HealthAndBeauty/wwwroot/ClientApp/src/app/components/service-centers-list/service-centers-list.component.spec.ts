import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ServicecentersListComponent } from './service-centers-list.component';

describe('ServicecentersListComponent', () => {
  let component: ServicecentersListComponent;
  let fixture: ComponentFixture<ServicecentersListComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ServicecentersListComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ServicecentersListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
