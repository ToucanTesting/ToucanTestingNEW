import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

// Toucan
import { LoginLayoutComponent } from '@toucan/layouts/login-layout/login-layout.component';
import { HomeLayoutComponent } from '@toucan/layouts/home-layout/home-layout.component';
import { AuthGuard } from './guards/auth.guard';

// Pages
import { DashboardComponent } from '@toucan/pages/dashboard/dashboard.component';
import { LoginComponent } from '@toucan/pages/login/login.component';
import { IntakeComponent } from '@toucan/pages/intake/intake.component';
import { QueryComponent } from '@toucan/pages/records/query/query.component';
import { RequestComponent } from '@toucan/pages/records/request/request.component';
import { ReleaseComponent } from '@toucan/pages/release/release.component';

const routes: Routes = [
  {
    path: '',
    component: HomeLayoutComponent,
    canActivate: [AuthGuard],
    children: [
      {
        path: '',
        pathMatch: 'full',
        redirectTo: 'dashboard'
      },
      {
        path: 'dashboard',
        component: DashboardComponent
      },
      {
        path: 'records/query',
        component: QueryComponent
      },
      {
        path: 'records/request',
        component: RequestComponent
      },
      {
        path: 'intake',
        component: IntakeComponent
      },
      {
        path: 'release',
        component: ReleaseComponent
      },
    ]
  },
  {
    path: '',
    component: LoginLayoutComponent,
    children: [
      {
        path: 'login',
        component: LoginComponent
      }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
  providers: [AuthGuard]
})
export class AppRoutingModule { }
