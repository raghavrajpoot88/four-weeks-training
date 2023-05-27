import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { SayHelloComponent } from './MyComponents/say-hello/say-hello.component';
import { NestingCompoComponent } from './nesting-compo/nesting-compo.component';

@NgModule({
  declarations: [
    AppComponent,
    SayHelloComponent,
    NestingCompoComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
