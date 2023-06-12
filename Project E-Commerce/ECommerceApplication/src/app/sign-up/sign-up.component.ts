import { Component } from '@angular/core';
import { SignUpService } from '../sign-up.service';
import { Router } from '@angular/router';
import { ProductInfo } from '../productInfo';
// import { NgForm , ViewChild} from '@angular/forms';

@Component({
  selector: 'app-sign-up',
  templateUrl: './sign-up.component.html',
  styleUrls: ['./sign-up.component.css']
})
export class SignUpComponent {
  constructor(private signUp:SignUpService,private router:Router){}

  ngOnInit():void{
    this.signUp.reloadSigned()
  }

  // @ViewChild('myForm')form?:NgForm; 
  bySubmitting(data:ProductInfo):void{
    
     this.signUp.userSignUp(data)
    //.subscribe((res)=>{
    //   if(res){this.router.navigate(['/login'])
    // console.log("inside bySubmit");
    // }
    //   console.log(res);
    // })
    
  }

}
