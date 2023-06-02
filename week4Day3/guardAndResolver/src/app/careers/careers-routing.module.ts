import { Component, NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { JobOpeningsComponent } from './job-openings/job-openings.component';
import { SupportComponent } from './support/support.component';

const routes: Routes = [
  {path:"job-opening", component:JobOpeningsComponent},
  {path:"support", component:SupportComponent} 
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class CareersRoutingModule { }
