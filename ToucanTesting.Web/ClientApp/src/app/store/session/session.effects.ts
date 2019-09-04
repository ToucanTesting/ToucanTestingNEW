import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { Actions, ofType, createEffect } from '@ngrx/effects';
import { from, of, throwError } from 'rxjs';
import { switchMap, tap, mergeMap, catchError, map, timeoutWith } from 'rxjs/operators';
import { login, loginSuccess, loginError, loadUser, loadProfile } from './session.actions';
import { AuthService } from '@toucan/services/auth/auth.service';

const TIMEOUT = 60000; // 60 seconds
const TIMEOUT_MESSAGE = 'The login attempt timed out. Please try again.';

@Injectable()
export class SessionEffects {

  constructor(
    private actions$: Actions,
    private authService: AuthService,
    private router: Router
  ) { }

  login$ = createEffect(() => this.actions$.pipe(
    ofType(login),
    mergeMap(x => from(this.authService.login(x)).pipe(
      timeoutWith(TIMEOUT, throwError({ error_description: TIMEOUT_MESSAGE })),
      map(y => loginSuccess(y)),
      catchError(y => of(loginError(y.response && y.response.data || y)).pipe(
        tap(z => z.twofactorauth_status && this.router.navigateByUrl('/login/2fa')))
      )
    ))
  ));

  loginSuccess$ = createEffect(() => this.actions$.pipe(
    ofType(loginSuccess),
    tap((x) => {
      this.authService.setAccessToken(x);
      this.router.navigate(['dashboard']);
    }),
    mergeMap(() => [
      loadUser(),
      loadProfile(),
    ])
  ));
}

