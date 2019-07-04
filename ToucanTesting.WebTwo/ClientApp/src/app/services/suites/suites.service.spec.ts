import { TestBed } from '@angular/core/testing';

import { SuitesService } from './suites.service';

describe('SuitesService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: SuitesService = TestBed.get(SuitesService);
    expect(service).toBeTruthy();
  });
});
