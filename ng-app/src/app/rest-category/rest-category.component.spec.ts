import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RestCategoryComponent } from './rest-category.component';

describe('RestCategoryComponent', () => {
  let component: RestCategoryComponent;
  let fixture: ComponentFixture<RestCategoryComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ RestCategoryComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(RestCategoryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
