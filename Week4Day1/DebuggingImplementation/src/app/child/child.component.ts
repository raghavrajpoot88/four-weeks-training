import { Component } from '@angular/core';
import { Input,Output,EventEmitter } from '@angular/core';

@Component({
  selector: 'app-child',
  templateUrl: './child.component.html',
  styleUrls: ['./child.component.css']
})
export class ChildComponent {
// @Input()
  // item!: string;
  // @Output() remove = new EventEmitter<string>();

  @Input()
  item!: string;
  @Output() itemClicked = new EventEmitter<string>();

  handleClick() {
    this.itemClicked.emit(this.item);
  }
}
