import { Component, } from '@angular/core';
import { ReactiveFormsModule,FormGroup,FormControl,FormArray, Validators } from '@angular/forms';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'hobbiesApplication';
  hobby:FormGroup;
  submitted=false;
  i: any;
  ngOnInit(){
    this.hobby=new FormGroup({
      firstName:new FormControl(null,[Validators.required,Validators.pattern('[a-zA-Z ]*')]),
      hobbies:new FormArray([
        new FormControl(null)
      ])
    })
  }
  bySubmitting(){
    this.submitted = true;
    if (this.hobby.valid) {
      alert('Form Submitted succesfully!!!\n Check the values in browser console.');
      console.table(this.hobby.value);
      this.hobby.reset();
    }
    
  }

  addHobby(){
    (<FormArray>this.hobby.get('hobbies')).push(new FormArray([],Validators.required))
    
  }
  removeHobby(i){
    (<FormArray>this.hobby.get('hobbies')).removeAt(i)
  }
}
