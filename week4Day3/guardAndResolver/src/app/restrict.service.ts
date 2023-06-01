import { Injectable } from '@angular/core';
import {  ActivatedRouteSnapshot, CanActivate, Router, RouterStateSnapshot } from '@angular/router';
import { AuthService } from './auth.service';


@Injectable({
  providedIn: 'root'
})
export class RestrictService implements CanActivate{
  constructor(private authservice:AuthService,private router: Router) { }

  canActivate(route:ActivatedRouteSnapshot,state:RouterStateSnapshot):boolean{
    if(this.authservice.isAuthenticated()){
      return true;
    }
    else{
      this.router.navigate(['']);
      return false;
    }
    
  }

}
