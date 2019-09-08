import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from '@toucan/environment';
import { Observable, BehaviorSubject } from 'rxjs';
import { Credentials, User, TokenResponse } from '@toucan/shared/models';
import { Token } from '@angular/compiler';
import { AuthService as SocialLoginAuthService } from 'angularx-social-login';
import { FacebookLoginProvider, GoogleLoginProvider } from 'angularx-social-login';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  private currentUserSubject: BehaviorSubject<User>;
  public currentUser: Observable<User>;

    constructor(
        private http: HttpClient,
        private socialLoginService: SocialLoginAuthService
    ) {
    this.currentUserSubject = new BehaviorSubject<User>(JSON.parse(localStorage.getItem('currentUser')));
    this.currentUser = this.currentUserSubject.asObservable();
  }

  public login({ email, password }: Credentials): Observable<any> {
    const headers: HttpHeaders = new HttpHeaders()
      .set('Content-Type', 'application/x-www-form-urlencoded')
      .set('AppId', environment.appId);

    /**
     * TODO
     * - Send as form
     */

    const params = new HttpParams()
      .set('username', email)
      .set('password', password)
      .set('grant_type', 'password');

    return this.http.post<any>('/api/token', params, { headers });
  }

  public setAccessToken(tokenResponse: TokenResponse): void {
    localStorage.setItem('token', JSON.stringify(tokenResponse)); // TODO - Don't store in local storage!!
  }

  public isAuthenticated(): boolean {
    const isAuthenticated: TokenResponse = JSON.parse(localStorage.getItem('token'));

    if (!isAuthenticated)
      return false;

    const expiresTime = new Date(isAuthenticated['.expires']).getTime();
    const currentTime = new Date().getTime();

    return expiresTime > currentTime;
  }
}
