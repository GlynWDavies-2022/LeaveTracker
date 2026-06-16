import { inject } from '@angular/core';
import { BankHolidayService } from '../../../bank-holiday/services/bank-holiday-service';
import { Component } from '@angular/core';

@Component({
  selector: 'app-bank-holiday-list',
  imports: [],
  templateUrl: './bank-holiday-list.html',
  styleUrl: './bank-holiday-list.css',
})

export class BankHolidayList {

  private bankHolidayService = inject(BankHolidayService);

  private getAllBankHolidays = this.bankHolidayService.getAllBankHolidays();

  isLoading = this.getAllBankHolidays.isLoading;

  isError = this.getAllBankHolidays.error;

  value = this.getAllBankHolidays.value;

}
