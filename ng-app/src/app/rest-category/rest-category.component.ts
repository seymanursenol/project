import { Component, OnInit } from '@angular/core';
import { Kitchen, Model } from '../models/kitchen';
import { KitchenService } from '../Service/kitchen.service';
import { Restorant } from '../models/restorant';
import { RestorantService } from '../Service/restorant.service';

@Component({
  selector: 'rest-category',
  templateUrl: './rest-category.component.html',
  styleUrls: ['./rest-category.component.css']
})
export class RestCategoryComponent implements OnInit {
  kitchens : Kitchen[]=[];

  model = new Model();

  constructor(private kitchenService: KitchenService, private restorantService: RestorantService){

  }
  ngOnInit(): void{
    this.getKitchens();
  }


  getKitchens(){
    this.kitchenService.GetKitchens().subscribe(kitchens =>{
      this.kitchens = kitchens;

      console.log(kitchens);
    })
  }


  selectKitchen( kitchen: Kitchen){

    this.restorantService.GetRestorantById(kitchen.kitchenId).subscribe(restorants => {
      kitchen.restorants= restorants;
    });

  }

}
