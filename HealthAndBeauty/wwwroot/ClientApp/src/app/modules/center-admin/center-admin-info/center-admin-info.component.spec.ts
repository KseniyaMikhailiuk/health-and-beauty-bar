import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CenterAdminInfoComponent } from './center-admin-info.component';

describe('CenterAdminInfoComponent', () => {
  let component: CenterAdminInfoComponent;
  let fixture: ComponentFixture<CenterAdminInfoComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CenterAdminInfoComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CenterAdminInfoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
