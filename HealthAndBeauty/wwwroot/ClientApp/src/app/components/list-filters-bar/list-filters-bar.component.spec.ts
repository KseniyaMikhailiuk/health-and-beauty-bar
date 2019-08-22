import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ListFiltersBarComponent } from './list-filters-bar.component';

describe('ListFiltersBarComponent', () => {
  let component: ListFiltersBarComponent;
  let fixture: ComponentFixture<ListFiltersBarComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ListFiltersBarComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ListFiltersBarComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
