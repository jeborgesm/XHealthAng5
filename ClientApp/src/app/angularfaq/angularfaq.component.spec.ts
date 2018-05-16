import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AngularfaqComponent } from './angularfaq.component';

describe('AngularfaqComponent', () => {
  let component: AngularfaqComponent;
  let fixture: ComponentFixture<AngularfaqComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AngularfaqComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AngularfaqComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
