import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SiparisComponent } from './siparis.component';

describe('SiparisComponent', () => {
  let component: SiparisComponent;
  let fixture: ComponentFixture<SiparisComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SiparisComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(SiparisComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
