import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';

@Injectable({
  providedIn: 'root'
})
export class LoginService {

  readonly baseUrl = 'https://localhost:7008/api';

  constructor(private httpClient: HttpClient, public formBuilder: FormBuilder) { }

  public formData = this.formBuilder.group({
    UserName: ['', Validators.required],
    Password: ['', Validators.required]
  });

  login() {
    var data = {
      UserName: this.formData.value.UserName,
      Password: this.formData.value.Password
    };
    return this.httpClient.post(this.baseUrl + '/account/Registration', data);
  }
}
