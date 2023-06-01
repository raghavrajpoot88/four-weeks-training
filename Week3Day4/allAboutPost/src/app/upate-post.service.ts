import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { IPostDetails } from './postDetails';
import { Observable } from 'rxjs';


@Injectable({
  providedIn: 'root'
})
export class UpatePostService {
  private jsonUrl='https://jsonplaceholder.typicode.com/posts'
  constructor(private http:HttpClient) { }

  getPostDetail():Observable<IPostDetails[]>{
    return this.http.get<IPostDetails[]>(this.jsonUrl);
  }
  updateInfo(postDetail:IPostDetails):Observable<IPostDetails>{
    const url =`${this.jsonUrl}/${postDetail.id}`;
    return this.http.put<IPostDetails>(url ,postDetail);
  }
  deleteInfo(id: number):Observable<void>{
    const url =`${this.jsonUrl}/${id}`;
    return this.http.delete<void>(url);
  }
}
