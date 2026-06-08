import { HttpClient, httpResource } from '@angular/common/http';
import { inject, Injectable } from '@angular/core';
import { BankHoliday } from '../../../shared/models/BankHoliday';

@Injectable({
  providedIn: 'root',
})

export class BankHolidayService {

  private http = inject(HttpClient);

  private apiBaseUrl = 'http://localhost:5088';

  getAllBankHolidays() {

    return httpResource<BankHoliday[]>(() => `${this.apiBaseUrl}/api/bankholidays`);

  }

}
