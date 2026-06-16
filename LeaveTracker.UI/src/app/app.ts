import { Component, inject, OnInit } from '@angular/core';
import { Router, RouterOutlet } from '@angular/router';
import { AppHeader } from '../app/shared/components/app-header/app-header';
import { AccountService } from './features/account/services/account-service';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-root',
  imports: [AppHeader, RouterOutlet],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App implements OnInit {

  private accountService = inject(AccountService);

  protected router = inject(Router);

  private http = inject(HttpClient);

  protected readonly title = 'Leave Tracker';

  ngOnInit(): void {

    this.setCurrentUser();

  }

  setCurrentUser() {

    const userString = localStorage.getItem('user');

    if (!userString) return;

    const user = JSON.parse(userString);

    this.accountService.currentUser.set(user);
  }

}
