import { Injectable } from '@angular/core';
import { CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot, Router, Route } from '@angular/router';
import { Observable, of } from 'rxjs';
import { AuthService } from 'angularx-social-login';
import { map, catchError, tap } from 'rxjs/operators';

@Injectable()
export class AuthGuard implements CanActivate {
  private isLoggedIn: boolean;

  constructor(
    private authService: AuthService,
    private router: Router
  ) {
  }

  canActivate(
    next: ActivatedRouteSnapshot,
    state: RouterStateSnapshot): Observable<boolean> | Promise<boolean> | boolean {
    return this.authService.authState.pipe(
      map(user => user !== null),
      catchError(err => of(false)),
      tap((isLoggedIn) => {
        if (!isLoggedIn) {
          this.router.navigate(['/login']);
        }
      })
    );
  }
}
