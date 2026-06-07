import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BankHolidayList } from './bank-holiday-list';

describe('BankHolidayList', () => {
  let component: BankHolidayList;
  let fixture: ComponentFixture<BankHolidayList>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [BankHolidayList],
    }).compileComponents();

    fixture = TestBed.createComponent(BankHolidayList);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
