import { Component, inject } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { Router, RouterLink, RouterLinkActive } from '@angular/router';
import { AccountService } from '../../../features/account/services/account-service';

@Component({
  selector: 'app-header',
  imports: [FormsModule,RouterLink,RouterLinkActive],
  templateUrl: './app-header.html',
  styleUrl: './app-header.css',
})

export class AppHeader {

  private router = inject(Router);

  protected accountService = inject(AccountService);

  protected credentials: any = {};

  login(): void {

    this.accountService.login(this.credentials).subscribe({
      next: result => {
        this.router.navigateByUrl('/');
        this.credentials = {};
      },
      error: error => console.log(error)
    });

  }

  logout(): void {
    this.accountService.logout();
    this.router.navigateByUrl('/login');
  }

}
