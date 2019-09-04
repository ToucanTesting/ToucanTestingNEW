import { Component, OnInit } from '@angular/core';
import { AuthService } from '@toucan/services/auth/auth.service';
import { Router } from '@angular/router';

@Component({
  selector: 'tt-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {

  constructor(
    private router: Router,
    private authService: AuthService
  ) { }

  ngOnInit() {
    if (this.authService.isAuthenticated)
      this.router.navigate(['']);
  }
}
