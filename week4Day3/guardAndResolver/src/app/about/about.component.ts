import { Component, OnInit } from '@angular/core';
import { AboutDataService } from '../about-data.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-about',
  templateUrl: './about.component.html',
  styleUrls: ['./about.component.css']
})
export class AboutComponent implements OnInit{
  users:any;
  constructor( private dataServices :AboutDataService,private activatedRoutes:ActivatedRoute){
   }

   ngOnInit(): void {
     this.users=this.activatedRoutes.snapshot.data['result']
   }
}
