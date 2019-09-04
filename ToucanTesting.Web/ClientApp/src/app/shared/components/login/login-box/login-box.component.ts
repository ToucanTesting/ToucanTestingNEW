import { Component, OnInit } from '@angular/core';
import { login } from '@toucan/store/session/session.actions';
import { AuthService, SocialUser } from "angularx-social-login";
import { FacebookLoginProvider, GoogleLoginProvider } from "angularx-social-login";

@Component({
  selector: 'tt-login-box',
  templateUrl: './login-box.component.html',
  styleUrls: ['./login-box.component.scss']
})
export class LoginBoxComponent {
  private user: SocialUser;
  private loggedIn: boolean;

    constructor(
      private authService: AuthService
    ) { }

    ngOnInit() {
        this.authService.authState.subscribe((user) => {
          console.log(user);
        this.user = user;
        this.loggedIn = (user != null);
      });
    }

    signInWithGoogle(): void {
      this.authService.signIn(GoogleLoginProvider.PROVIDER_ID);
    }
//
//    signInWithFB(): void {
//      this.authService.signIn(FacebookLoginProvider.PROVIDER_ID);
//    }
//
//    signOut(): void {
//      this.authService.signOut();
//    }
}
