import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CenterAdminServicesComponent } from './center-admin-services.component';

describe('CenterAdminServicesComponent', () => {
  let component: CenterAdminServicesComponent;
  let fixture: ComponentFixture<CenterAdminServicesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CenterAdminServicesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CenterAdminServicesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
