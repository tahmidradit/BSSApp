import { AccountService } from './../../service/account/account.service';
import { Component, Input, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-account',
  templateUrl: './account.component.html',
  styleUrls: ['./account.component.css']
})
export class AccountComponent implements OnInit {

  constructor(private accountService:AccountService) { }

  ngOnInit(): void {
  }

  
  
  
  register = new FormGroup({
    firstName: new FormControl(""),
    lastName: new FormControl(""),
    userName: new FormControl(""),
    email: new FormControl(""),
    password: new FormControl(""),
    confirmPassword: new FormControl("")
  });
  // registration() {
    
  //   this.accountService.register().subscribe(res => {
  //     console.log(register);
  //   });
  // }
}
