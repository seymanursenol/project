import { Component, OnInit } from '@angular/core';
import { Model, Restorant } from '../models/restorant';
import { RestorantService } from '../Service/restorant.service';



@Component({
  selector: 'restorant-list',
  templateUrl: './restorant-list.component.html',
  styleUrls: ['./restorant-list.component.css']
})
export class RestorantListComponent implements OnInit {

  restorants : Restorant[];

  model = new Model();

  constructor(private restorantService: RestorantService) {
  }

  ngOnInit(): void {
    this.getRestorants();
  }


  getRestorants(){
    this.restorantService.GetRestorant().subscribe(restorants=>{
      this.restorants = restorants;
      console.log(restorants);
    })
  }

  getRestorantById(id: number){
    this.restorantService.GetRestorantById(id).subscribe(restorants=>{
      this.restorants=restorants;

      console.log(restorants);
    })
  }

}
