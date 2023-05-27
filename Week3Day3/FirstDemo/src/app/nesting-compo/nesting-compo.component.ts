import { Component,Input } from '@angular/core';

@Component({
  selector: 'app-nesting-compo',
  templateUrl: './nesting-compo.component.html',
  styleUrls: ['./nesting-compo.component.css']
})
export class NestingCompoComponent {
  @Input()
  message: string="";

}
