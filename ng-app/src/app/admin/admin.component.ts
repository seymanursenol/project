import { Component, OnInit } from '@angular/core';
import { Kitchen, Model } from '../models/kitchen';
import { KitchenService } from '../Service/kitchen.service';
import { RestorantService } from '../Service/restorant.service';
import { Restorant } from '../models/restorant';

@Component({
  selector: 'admin',
  templateUrl: './admin.component.html',
  styleUrls: ['./admin.component.css']
})
export class AdminComponent implements OnInit {

  model = new Model();

  kitchens: Kitchen[];

  restorants: Restorant[];

  selectedKitchen:any;

  selectedFile: File | undefined;


  constructor(private RestorantService: RestorantService,private kitchenService: KitchenService){

  }
  ngOnInit(): void{
    this.getKitchens();
  }


  SelectedBasvuru(restorantName:string, restSahibiFullName:string,restSahibiEMail:string, RestEmail:string,restSahibiPhone:string, Sifre:string, restorantAdres:string,selectedKitchen:{kitchenId:number,kitchenAd:string}){

    const newRest: Restorant ={
      restorantId:0,
      restorantName: restorantName,
      restorantAdres: restorantAdres,
      restSahibiFullName: restSahibiFullName,
      restSahibiEMail: restSahibiEMail,
      restSahibiPhone: restSahibiPhone,
      restorantEMail:RestEmail,
      parola:Sifre,
      kitchenId:selectedKitchen.kitchenId,
      kitchenName:selectedKitchen.kitchenAd
    }
     this.RestorantService.AddRestorant(newRest).subscribe(restorant =>this.restorants.push(restorant));
     console.log(newRest);
  };




  getKitchens(){
    this.kitchenService.GetKitchens().subscribe(kitchens =>{
      this.kitchens = kitchens;

      console.log(kitchens);
    })
  }

  GetRestorant(){
    this.RestorantService.GetRestorant().subscribe(rest =>{
      this.restorants = rest;

      console.log(this.restorants);
    })
  }




  // AddRestorant()
}
