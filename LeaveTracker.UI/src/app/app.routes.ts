import { Routes } from '@angular/router';
import { BankHolidayList } from './features/bank-holiday/components/bank-holiday-list/bank-holiday-list';

export const routes: Routes = [
  { path: 'admin/bankholidays', component: BankHolidayList }
];
