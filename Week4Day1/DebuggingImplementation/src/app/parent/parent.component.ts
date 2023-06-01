import { Component } from '@angular/core';

@Component({
  selector: 'app-parent',
  templateUrl: './parent.component.html',
  styleUrls: ['./parent.component.css'],
  template: `<ul>
    <li *ngFor="let item of items">
      <app-child [item]="item" (itemClicked)="handleItemClick($event)"></app-child>
      <app-child [item]="item" (itemClicked)="removeItem($event)"></app-child>
    </li>
  </ul>`,
})
export class ParentComponent {

  items: string[] = ['Books', 'Playstation', 'Clothes'];

  removeItem(item: string) {
    this.items = this.items.filter((i) => i !== item);
  }
  //   handleItemClick(item: string) {
  //   console.log(`Item clicked: ${item}`);
  // }
  
}
