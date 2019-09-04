import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { IntakeComponent } from './intake.component';

describe('MyIntakeComponent', () => {
  let component: IntakeComponent;
  let fixture: ComponentFixture<IntakeComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MyIntakeComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MyIntakeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
