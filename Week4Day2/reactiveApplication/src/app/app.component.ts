import { Component,OnInit } from '@angular/core';
import { FormControl, FormGroup,Validators } from '@angular/forms';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit{
  title = 'reactiveApplication';
  reactiveForm:FormGroup;
  submitted=false;
  ngOnInit(){
    this.reactiveForm=new FormGroup({
      firstName:new FormControl(null,[Validators.required,Validators.pattern('[a-zA-Z ]*')]),
      lastName:new FormControl(null,[Validators.required,Validators.pattern('[a-zA-Z ]*')] ),
      email:new FormControl(null,[Validators.required,Validators.email]),
      password:new FormControl(null,[Validators.required, Validators.pattern('^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9]).{8,}$')])
    });
  }
  bySubmitting(){
    this.submitted = true;
    if (this.reactiveForm.valid) {
      alert('Form Submitted succesfully!!!\n Check the values in browser console.');
      console.table(this.reactiveForm.value);
      this.reactiveForm.reset();
    }
    
  }
}
