import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { IBlogPost } from './blog';
import { Observable } from 'rxjs'



@Injectable({
  providedIn: 'root'
})
export class BlogService {

  constructor( private http:HttpClient) { 
    
  }
  getBlogPost():Observable<IBlogPost>{
    console.log("inside the property ");
      return this.http.get<IBlogPost>('https://jsonplaceholder.typicode.com/posts')
  }


}
