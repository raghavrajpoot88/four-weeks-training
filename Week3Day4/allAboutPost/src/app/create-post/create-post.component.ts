import { Component, OnInit } from '@angular/core';
import { UpatePostService } from '../upate-post.service';
import { IPostDetails } from '../postDetails';

@Component({
  selector: 'app-create-post',
  templateUrl: './create-post.component.html',
  styleUrls: ['./create-post.component.css'],
  providers: [UpatePostService]
})
export class CreatePostComponent implements OnInit {
posts:any;
constructor(private _service:UpatePostService){}

ngOnInit():void{
  this._service.getPostDetail()
      .subscribe(data =>this.posts = data);
}
updateDetailInfo() {
  const updatedPost:IPostDetails = {
    id: 1,
    userId:'informative',
    title: 'Updated Post',
    body: 'This post has been updated.'
  };
  this._service.updateInfo(updatedPost)
  this._service.updateInfo(updatedPost)
    .subscribe(updatedPost=> {
      console.log(updatedPost);
      
    });
}
deleteDetailInfo(){
  const postIdToDelete = 1;
  this._service.deleteInfo(postIdToDelete)
  this.posts.pop(postIdToDelete) 
    console.log('Post deleted successfully.');
}
}
