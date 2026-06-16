import { HttpClient } from '@angular/common/http';
import { inject, Injectable, signal } from '@angular/core';
import { LoginCredentials, RegisterCredentials, User } from '../types/account';
import { tap } from 'rxjs';

@Injectable({
  providedIn: 'root',
})

export class AccountService {

  private http = inject(HttpClient);

  baseUrl = 'http://localhost:5088/api/account';

  currentUser = signal<User | null>(null);

  register(credentials: RegisterCredentials) {

    return this.http.post<User>(`${this.baseUrl}/register`, credentials)
      .pipe(
        tap(user => {
          this.setCurrentUser(user)
        })
    );

  }

  login(credentials: LoginCredentials) {

    return this.http.post<User>(`${this.baseUrl}/login`, credentials)
      .pipe(
        tap(user => {
          this.setCurrentUser(user)
        })
    );

  }

  logout() {

    localStorage.removeItem('user');

    this.currentUser.set(null);

  }

  setCurrentUser(user: User) {

    localStorage.setItem('user', JSON.stringify(user));

    this.currentUser.set(user);

  }

}
