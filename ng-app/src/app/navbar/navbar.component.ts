import { Component, OnInit } from '@angular/core';
import { RouterModule, Router } from '@angular/router';
import { RestorantListComponent } from '../restorant-list/restorant-list.component';


@Component({
  selector: 'navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css']
})
export class NavbarComponent implements OnInit {

  constructor(private router : Router) {}

  Login(){
    this.router.navigate(['/login-page']);
  }

  ngOnInit(): void {
  }
  restorant(){
    this.router.navigate(["/restorant-list"]);
  };


}
