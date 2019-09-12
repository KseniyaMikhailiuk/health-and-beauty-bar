import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CenterAdminWorkingHoursComponent } from './center-admin-working-hours.component';

describe('CenterAdminWorkingHoursComponent', () => {
  let component: CenterAdminWorkingHoursComponent;
  let fixture: ComponentFixture<CenterAdminWorkingHoursComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CenterAdminWorkingHoursComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CenterAdminWorkingHoursComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
