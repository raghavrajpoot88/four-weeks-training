import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { CareersRoutingModule } from './careers-routing.module';
import { JobOpeningsComponent } from './job-openings/job-openings.component';
import { SupportComponent } from './support/support.component';


@NgModule({
  declarations: [
    JobOpeningsComponent,
    SupportComponent
  ],
  imports: [
    CommonModule,
    CareersRoutingModule
  ]
})
export class CareersModule { }
