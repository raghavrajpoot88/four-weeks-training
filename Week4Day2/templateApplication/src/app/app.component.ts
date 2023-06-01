import { Component,ViewChild } from '@angular/core';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'templateApplication';

  @ViewChild('myForm')form?:NgForm; 
  bySubmitting(){
    console.log(this.form);
    
  }
}