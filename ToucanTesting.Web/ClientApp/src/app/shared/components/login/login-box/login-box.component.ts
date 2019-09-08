import { Component, OnInit } from '@angular/core';
import { AuthService, SocialUser, GoogleLoginProvider } from 'angularx-social-login';
import { environment } from 'src/environments/environment';
import { Router } from '@angular/router';

@Component({
  selector: 'tt-login-box',
  templateUrl: './login-box.component.html',
  styleUrls: ['./login-box.component.scss']
})
export class LoginBoxComponent {
  private user: SocialUser;
  private loggedIn: boolean;

  constructor(
    private authService: AuthService,
    private router: Router
  ) { }

  signInWithGoogle(): void {
    this.authService.signIn(GoogleLoginProvider.PROVIDER_ID)
      .then(() => this.router.navigate(['/dashboard']));
  }
}
