import { Component } from '@angular/core';
import { NgForm } from '@angular/forms';
import { User } from '../models/user';
import { ActivatedRoute } from '@angular/router';
import { AuthService } from '../Service/auth.service';

@Component({
  selector: 'signup-page',
  templateUrl: './signup-page.component.html',
  styleUrls: ['./signup-page.component.css'],
})
export class SignupPageComponent {

  users: User[];
  model : any = {};

  constructor( private aoutService: AuthService){

  }
  ngOnInit() {

  }


  register(){
    this.aoutService.register(this.model).subscribe(()=>{
      console.log("Kullanıcı oluşturuldu.");
    },error=>{
      console.log(error);
    });
  }


}
