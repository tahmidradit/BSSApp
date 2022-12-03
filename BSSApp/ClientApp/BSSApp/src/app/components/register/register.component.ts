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
    this.regService.formData.reset();
  }

  isRegisteredSuccessfully: boolean = false;

  register() {
    this.isRegisteredSuccessfully = true;
    this.regService.register().subscribe((res: any) => {
      if(res.succeeded) {
        this.regService.formData.reset();
      }
    });
  }
}
