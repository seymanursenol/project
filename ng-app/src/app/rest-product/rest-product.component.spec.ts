import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RestProductComponent } from './rest-product.component';

describe('RestProductComponent', () => {
  let component: RestProductComponent;
  let fixture: ComponentFixture<RestProductComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ RestProductComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(RestProductComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
