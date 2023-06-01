import { TestBed } from '@angular/core/testing';

import { AddNumSerService } from './add-num-ser.service';

describe('AddNumSerService', () => {
  let service: AddNumSerService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(AddNumSerService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
