import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';

import { environment } from '@toucan/environment';
import { TopnavComponent } from './components/topnav/topnav.component';
import { LoginBoxComponent } from './components/login/login-box/login-box.component';
import { BreadcrumbsComponent } from './components/breadcrumbs/breadcrumbs.component';

import { AppRoutingModule } from '../app-routing.module';
import {
  AppFooterModule,
} from '@coreui/angular';

import { SocialLoginModule, AuthServiceConfig } from 'angularx-social-login';
import { GoogleLoginProvider, FacebookLoginProvider } from 'angularx-social-login';
import { PERFECT_SCROLLBAR_CONFIG } from 'ngx-perfect-scrollbar';
import { PerfectScrollbarModule } from 'ngx-perfect-scrollbar';
import { PerfectScrollbarConfigInterface } from 'ngx-perfect-scrollbar';
import { FooterComponent } from './components/footer/footer.component';
import { BsDropdownModule } from 'ngx-bootstrap/dropdown';

const DEFAULT_PERFECT_SCROLLBAR_CONFIG: PerfectScrollbarConfigInterface = {
  suppressScrollX: true
};

const config = new AuthServiceConfig([
  {
    id: GoogleLoginProvider.PROVIDER_ID,
    provider: new GoogleLoginProvider(environment.providerId)
  }
]);

export function provideConfig() {
  return config;
}

@NgModule({
  declarations: [TopnavComponent, LoginBoxComponent, BreadcrumbsComponent, FooterComponent],
  imports: [
    CommonModule,
    FormsModule,
    HttpClientModule,
    AppRoutingModule,
    AppFooterModule,
    PerfectScrollbarModule,
    SocialLoginModule,
    BsDropdownModule.forRoot(),
  ],
  exports: [
    TopnavComponent,
    LoginBoxComponent,
    BreadcrumbsComponent,
    FooterComponent
  ],
  providers: [
    {
      provide: AuthServiceConfig,
      useFactory: provideConfig
    }
  ]
})
export class SharedModule { }
