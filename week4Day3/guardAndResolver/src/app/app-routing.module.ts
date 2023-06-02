import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ContactUsComponent } from './contact-us/contact-us.component';
import { AboutComponent } from './about/about.component';
import { HomeComponent } from './home/home.component';
import { RestrictService } from './restrict.service';
import { aboutRasolverDGuard } from './about-rasolver-d.guard';

const routes: Routes = [
  {path:"Home",component:HomeComponent},
  {path:"About",component:AboutComponent, canActivate:[RestrictService],resolve:{result:aboutRasolverDGuard}},
  {path:"Contact-Us",component:ContactUsComponent},
  {path:"careers", loadChildren:()=>import('./careers/careers.module').then(mod=>mod.CareersModule)},
  {path:"posts", loadChildren:()=>import('./posts/posts.module').then(mod=>mod.PostsModule)}


];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
