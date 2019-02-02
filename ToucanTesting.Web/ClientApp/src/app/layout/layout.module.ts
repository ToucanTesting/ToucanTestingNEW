import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SidenavComponent } from './sidenav/sidenav.component';
import { TopnavComponent } from './topnav/topnav.component';
import { FooterComponent } from './footer/footer.component';

@NgModule({
  imports: [
    CommonModule
  ],
  declarations: [
    SidenavComponent,
    TopnavComponent,
    FooterComponent
  ],
  exports: [
    SidenavComponent,
    TopnavComponent,
    FooterComponent
  ]

})
export class LayoutModule { }
