import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Book } from 'src/app/models/book';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class BookService {

  url = "Books";
  constructor(private http:HttpClient) { }

  getBooks():Observable<Book[]> {
    return this.http.get<Book[]>(`${environment.baseUrl}/${this.url}`);
  }
}
 