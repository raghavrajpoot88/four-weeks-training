import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, Resolve, RouterStateSnapshot} from '@angular/router';
import { AboutDataService } from './about-data.service';

@Injectable  
({ providedIn: 'root' })
export class aboutRasolverDGuard implements Resolve<any>{
  constructor(private userService:AboutDataService){}
  resolve(route: ActivatedRouteSnapshot, state: RouterStateSnapshot) {
    
    return this.userService.getData();
    
  }
  
};
