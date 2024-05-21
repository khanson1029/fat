import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DisplaystringsComponent } from './displaystrings.component';

describe('DisplaystringsComponent', () => {
  let component: DisplaystringsComponent;
  let fixture: ComponentFixture<DisplaystringsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DisplaystringsComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DisplaystringsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
