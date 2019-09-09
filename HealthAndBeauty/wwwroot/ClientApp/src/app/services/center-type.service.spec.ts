import { TestBed } from '@angular/core/testing';

import { CenterTypeService } from './center-type.service';

describe('CenterTypeService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: CenterTypeService = TestBed.get(CenterTypeService);
    expect(service).toBeTruthy();
  });
});
