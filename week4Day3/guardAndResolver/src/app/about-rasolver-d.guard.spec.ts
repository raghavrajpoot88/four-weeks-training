import { TestBed } from '@angular/core/testing';
import { CanActivateFn } from '@angular/router';

import { aboutRasolverDGuard } from './about-rasolver-d.guard';

describe('aboutRasolverDGuard', () => {
  const executeGuard: CanActivateFn = (...guardParameters) => 
      TestBed.runInInjectionContext(() => aboutRasolverDGuard(...guardParameters));

  beforeEach(() => {
    TestBed.configureTestingModule({});
  });

  it('should be created', () => {
    expect(executeGuard).toBeTruthy();
  });
});
