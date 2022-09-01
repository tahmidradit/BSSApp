import { AccountService } from './service/account/account.service';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import {  HttpClientModule  } from '@angular/common/http'; 
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { AccountComponent } from './component/account/account.component';
import { HomeComponent } from './component/home/home.component';


@NgModule({
  declarations: [
    AppComponent,
    AccountComponent,
    HomeComponent,
    
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [AccountService],
  bootstrap: [AppComponent]
})
export class AppModule { }
