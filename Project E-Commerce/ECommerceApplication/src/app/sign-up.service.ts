import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'
import { ProductInfo } from './productInfo';
import { BehaviorSubject } from 'rxjs';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class SignUpService {
  isSignedUp=new BehaviorSubject<boolean>(false)
  constructor(private http:HttpClient, private router:Router) { }

  userSignUp(data:ProductInfo){
  this.http.post('http://localhost:3000/sign-up',data,{observe:'response'}).subscribe((res)=>{
    this.isSignedUp.next(true);
    localStorage.setItem('signedItem',JSON.stringify(res.body))
    this.router.navigate(['login'])
    console.log(res);
    
  });
  }
  reloadSigned(){
    if(localStorage.getItem('signedItem')){
      this.isSignedUp.next(true);
      this.router.navigate(['home']);
    }
  }

}
