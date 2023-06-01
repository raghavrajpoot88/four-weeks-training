import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ContactUsComponent } from './contact-us/contact-us.component';
import { AboutComponent } from './about/about.component';
import { HomeComponent } from './home/home.component';
import { RestrictService } from './restrict.service';

const routes: Routes = [
  {path:"Home",component:HomeComponent},
  {path:"About",component:AboutComponent, canActivate:[RestrictService]},
  {path:"Contact-Us",component:ContactUsComponent}

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
