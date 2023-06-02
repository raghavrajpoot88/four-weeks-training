import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { AboutComponent } from './about/about.component';
import { ContactUsComponent } from './contact-us/contact-us.component';
import { RestrictService } from './restrict.service';
import { AuthService } from './auth.service';
import { HttpClientModule } from '@angular/common/http';
import { AboutDataService } from './about-data.service';
import { aboutRasolverDGuard } from './about-rasolver-d.guard';


@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    AboutComponent,
    ContactUsComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [RestrictService,AuthService, AboutDataService,aboutRasolverDGuard],
  bootstrap: [AppComponent]
})
export class AppModule { }
