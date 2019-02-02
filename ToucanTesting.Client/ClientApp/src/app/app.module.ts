import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

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
    AppRoutingModule
  ],
  declarations: [
    AppComponent,
    DashboardComponent,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
