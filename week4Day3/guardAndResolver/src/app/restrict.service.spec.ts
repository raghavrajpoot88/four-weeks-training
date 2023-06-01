import { TestBed } from '@angular/core/testing';

import { RestrictService } from './restrict.service';

describe('RestrictService', () => {
  let service: RestrictService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(RestrictService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
