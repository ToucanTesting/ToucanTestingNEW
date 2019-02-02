import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { NgScrollbarModule } from 'ngx-scrollbar';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { DashboardComponent } from './pages/dashboard/dashboard.component';
import { LayoutModule } from './layout/layout.module';
import { ServicesModule } from './services/services.module';


@NgModule({
  imports: [
    BrowserModule,
    LayoutModule,
    ServicesModule,
    AppRoutingModule,
    NgScrollbarModule
  ],
  declarations: [
    AppComponent,
    DashboardComponent,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
