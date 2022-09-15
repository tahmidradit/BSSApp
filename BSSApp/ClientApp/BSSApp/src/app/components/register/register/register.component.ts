import { Component, OnInit } from '@angular/core';
import { RegService } from 'src/app/services/register/reg.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  constructor(public regService:RegService) { }

  ngOnInit(): void {
  }

  isRegisteredSuccessfully: boolean = false;

  register() {
    this.regService.register().subscribe();
    this.isRegisteredSuccessfully = true;
  }

}
