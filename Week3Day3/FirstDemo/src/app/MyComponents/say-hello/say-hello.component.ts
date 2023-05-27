import { Component } from '@angular/core';

@Component({
  selector: 'app-say-hello',
  templateUrl: './say-hello.component.html',
  styleUrls: ['./say-hello.component.css']
})
export class SayHelloComponent {
  name1="Raghav";
  value:number=1;
  nameOfColor:string="";
  colorname:string[]=["black","red","blue","aqua","beige","brown","blueviolet"]
  changeColor(){
    console.log(this.value);
    this.nameOfColor=this.colorname[Math.floor(Math.random() * this.value)];
    this.value+=1;
    console.log(this.nameOfColor);
    
    
    
    if(this.value==7){
      this.value=1;
    }
    
    
    
  }
  
  
}
