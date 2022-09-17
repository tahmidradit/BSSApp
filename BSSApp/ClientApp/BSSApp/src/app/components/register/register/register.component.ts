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
    this.isRegisteredSuccessfully = true;
    this.regService.register().subscribe(res => {
      
      var userRegisteredSuccessAlert = document.getElementById('user-registered-success');
      if(userRegisteredSuccessAlert) {
        userRegisteredSuccessAlert.style.display = "block";
      }
      setTimeout(() => {
        if(userRegisteredSuccessAlert) {
          userRegisteredSuccessAlert.style.display = "none";
        }
      }, 4000);
    });
  }
}
