import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { SignUpComponent } from './sign-up/sign-up.component';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { ProductListComponent } from './product-list/product-list.component';
import { LoginComponent } from './login/login.component';
import { restrictGuard } from './restrict.guard';


@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    SignUpComponent,
    ProductListComponent,
    LoginComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule
  ],
  providers: [restrictGuard],
  bootstrap: [AppComponent]
})
export class AppModule { }
