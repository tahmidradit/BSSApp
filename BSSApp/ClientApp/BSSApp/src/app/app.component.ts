import { BookService } from './services/book/book.service';
import { Book } from './models/book';
import { Component } from '@angular/core';
import { RegService } from './reg.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'BSSApp';

  constructor(public regService:RegService, private bookService: BookService) {}

  books: Book[] = [];

  ngOnInit() : void {
    this.getBooks();
  }

  getBooks() {
    this.bookService.getBooks().subscribe((result: Book[]) => (
      this.books = result
    ));
  }
  
  onSubmit() {
    this.regService.register().subscribe();
  }
}
