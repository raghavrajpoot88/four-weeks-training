import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { InformativeComponent } from './informative/informative.component';
import { ProductivityComponent } from './productivity/productivity.component';

const routes: Routes = [
  {path:"informative",component:InformativeComponent},
  {path:"productivity", component:ProductivityComponent}
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class PostsRoutingModule { }
