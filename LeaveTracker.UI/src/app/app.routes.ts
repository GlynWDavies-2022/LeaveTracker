import { Routes } from '@angular/router';
import { BankHolidayList } from './features/bank-holiday/components/bank-holiday-list/bank-holiday-list';
import { Home } from './features/home/components/home/home';

export const routes: Routes = [
  { path: '', component: Home },
  { path: 'admin/bankholidays', component: BankHolidayList },
  { path: '**', component: Home} 
];
