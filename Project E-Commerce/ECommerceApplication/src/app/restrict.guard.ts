import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, CanActivate, RouterStateSnapshot, UrlTree } from '@angular/router';
import { SignUpService } from './sign-up.service';
import { Observable } from 'rxjs/internal/Observable';

@Injectable({
  providedIn:'root'
})
export class restrictGuard implements CanActivate{
  constructor(private signed:SignUpService){}
  canActivate(route:ActivatedRouteSnapshot, state:RouterStateSnapshot):Observable<boolean | UrlTree> | Promise<boolean | UrlTree> | boolean | UrlTree{
    if(localStorage.getItem('signedItem')){
      return true;
    }
    
    return this.signed.isSignedUp;
  }
 
}
  

