import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NestingCompoComponent } from './nesting-compo.component';

describe('NestingCompoComponent', () => {
  let component: NestingCompoComponent;
  let fixture: ComponentFixture<NestingCompoComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [NestingCompoComponent]
    });
    fixture = TestBed.createComponent(NestingCompoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
