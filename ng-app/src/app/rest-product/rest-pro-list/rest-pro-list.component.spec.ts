import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RestProListComponent } from './rest-pro-list.component';

describe('RestProListComponent', () => {
  let component: RestProListComponent;
  let fixture: ComponentFixture<RestProListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ RestProListComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(RestProListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
