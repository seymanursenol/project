import { Restorant } from "./restorant";

export class Model{
  // kitchens : Array<Kitchen>;
  // KitchenAd:string;
  kitchens: Array<Kitchen>;
  // constructor(){
  //   this.kitchens= [

  //     new Kitchen(1, "Pide"),
  //     new Kitchen(2, "Pizza"),
  //     new Kitchen(3, "Lahmacun"),
  //     new Kitchen(4, "Kebap")

  // ]
  // }
}

export class Kitchen{
  kitchenId: number;
  kitchenAd: string;
  images: string;
  restorants: Restorant[];


  constructor (KitchenId:number, KitchenAd: string, İmages: string){

    this.kitchenId= KitchenId;
    this.kitchenAd = KitchenAd;
    this.images=İmages;
    }
    // this.isActive= isActive;



}
