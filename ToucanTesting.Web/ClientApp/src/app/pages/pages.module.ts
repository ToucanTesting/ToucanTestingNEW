import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NgScrollbarModule } from 'ngx-scrollbar';
import { DashboardComponent } from './dashboard/dashboard.component';
import { SuitesComponent } from './testing/suites/suites.component';
import { RunsComponent } from './testings/runs/runs.component';

@NgModule({
  imports: [
    CommonModule,
    NgScrollbarModule
  ],
  declarations: [DashboardComponent, SuitesComponent, RunsComponent]
})
export class PagesModule { }
