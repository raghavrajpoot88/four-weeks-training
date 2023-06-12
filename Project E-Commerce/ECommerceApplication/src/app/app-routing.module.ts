import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { SignUpComponent } from './sign-up/sign-up.component';
import { LoginComponent } from './login/login.component';
import { restrictGuard } from './restrict.guard';

const routes: Routes = [
  {path:"home", component:HomeComponent},
  {path:"sign-up",component:SignUpComponent},
  {path:"login",component:LoginComponent,canActivate:[restrictGuard]}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
