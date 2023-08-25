export class Model{
  restorants: Array<Restorant>;
}

export class Restorant{
  restorantId: number;
  restorantName: string;
  restorantAdres: string;
  restSahibiFullName: string;
  restSahibiEMail: string;
  restSahibiPhone: string;
  restorantEMail:string;
  parola:string;
  kitchenId:number;
  kitchenName: string;



    constructor(Id: number, restname: string, adres:string, SahibiFullName: string, SahibiEMail: string,SahibiPhone: string,RestEmail:string,Sifre:string,Image:string,KitchenId:number,kitchenName:string){
      this.restorantId = Id;
      this.restorantName = restname;
      this.restorantAdres = adres;
      this.restSahibiFullName = SahibiFullName;
      this.restSahibiEMail = SahibiEMail;
      this.restSahibiPhone = SahibiPhone;
      this.restorantEMail= RestEmail;
      this.parola=Sifre;
      this.kitchenId= KitchenId;
      this.kitchenName=kitchenName;
    }
}

// export interface Restaurant{
//   [x: string]: any;
//   id: number;
//   name: string;
//   imageUrl: string;
//   isActive: boolean;
//   dk: string;
//   restorantId: number;
//   restCategoryId: number;

// }
