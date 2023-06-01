import { Component, OnInit } from '@angular/core';
import { BlogService } from '../blog.service';
import { IBlogPost } from '../blog';


@Component({
  selector: 'app-blog',
  templateUrl: './blog.component.html',
  styleUrls: ['./blog.component.css']
})
export class BlogComponent implements OnInit{
  blogposts:any;
  constructor(private bgpost:BlogService){}
  
  ngOnInit():void{
    this.bgpost.getBlogPost()
      .subscribe((data: any) => this.blogposts=data);
      console.log("inside the init");
      
  }



}
