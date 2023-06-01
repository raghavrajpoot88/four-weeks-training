import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { AuthService } from './auth.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'guardAndResolver';
  constructor(private activatedRoute:ActivatedRoute,private authService:AuthService){}

  login(){
    this.authService.login();
  }
  logout(){
    this.authService.logout();
  }
}
