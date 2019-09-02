import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AdminCenterInfoComponent } from './admin-center-info.component';

describe('AdminCenterInfoComponent', () => {
  let component: AdminCenterInfoComponent;
  let fixture: ComponentFixture<AdminCenterInfoComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AdminCenterInfoComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AdminCenterInfoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
