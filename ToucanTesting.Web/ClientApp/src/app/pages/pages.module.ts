import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

// Kno2
import { SharedModule } from '@toucan/shared/shared.module';

// Pages
import { DashboardComponent } from './dashboard/dashboard.component';
import { LoginComponent } from './login/login.component';
import { IntakeComponent } from './intake/intake.component';
import { QueryComponent } from './records/query/query.component';
import { RequestComponent } from './records/request/request.component';
import { ReleaseComponent } from './release/release.component';

@NgModule({
  declarations: [DashboardComponent, LoginComponent, IntakeComponent, QueryComponent, RequestComponent, ReleaseComponent],
  imports: [
    CommonModule,
    SharedModule,
    FormsModule
  ],
  exports: [
    LoginComponent,
    DashboardComponent
  ]
})
export class PagesModule { }
