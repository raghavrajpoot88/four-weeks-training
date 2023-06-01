import { TestBed } from '@angular/core/testing';

import { UpatePostService } from './upate-post.service';

describe('UpatePostService', () => {
  let service: UpatePostService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(UpatePostService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
