import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'FirstDemo';
  name(nameValue:string):string{
    return nameValue;  
  }
  color="red";
}
