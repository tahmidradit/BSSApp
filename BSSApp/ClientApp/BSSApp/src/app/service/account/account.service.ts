import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class AccountService {

  readonly baseUrl = 'https://localhost:44302/api/account';

  constructor(private httpClient: HttpClient) { }

  register(data: any) {
    return this.httpClient.post(this.baseUrl, data);
  }
}
