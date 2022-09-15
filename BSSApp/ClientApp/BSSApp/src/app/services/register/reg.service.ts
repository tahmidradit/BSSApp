import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';

@Injectable({
  providedIn: 'root'
})
export class RegService {

  readonly baseUrl = 'https://localhost:7008/api';

  constructor(private httpClient: HttpClient, public formBuilder: FormBuilder) { }

  public formData = this.formBuilder.group({
    UserName: ['', Validators.required],
    FirstName: ['', Validators.required],
    LastName: ['', Validators.required],
    Email: ['', Validators.required],
    Password: ['', Validators.required]
  });
  
  register() {
    var data = {
      UserName: this.formData.value.UserName,
      FirstName: this.formData.value.FirstName,
      LastName: this.formData.value.LastName,
      Email: this.formData.value.Email,
      Password: this.formData.value.Password
    };
    return this.httpClient.post(this.baseUrl + '/account/Registration', data);
  }
}
