import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { PostsRoutingModule } from './posts-routing.module';
import { InformativeComponent } from './informative/informative.component';
import { ProductivityComponent } from './productivity/productivity.component';


@NgModule({
  declarations: [
    InformativeComponent,
    ProductivityComponent
  ],
  imports: [
    CommonModule,
    PostsRoutingModule
  ]
})
export class PostsModule { }
