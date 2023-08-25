import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { AuthService } from '../Service/auth.service';

@Component({
  selector: 'login-page',
  templateUrl: './login-page.component.html',
  styleUrls: ['./login-page.component.css']
})
export class LoginPageComponent implements OnInit {

  model: any={};
  subscription: any;

  constructor(private authService: AuthService) { }

  ngOnInit(): void {
  }


  Login(){
    this.authService.Login(this.model).subscribe(
      next=> {
        console.log("Login Başarılı");
      }, error => {
        console.log("Başarısız");
      }
    )
  }



}
