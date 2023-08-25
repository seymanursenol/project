export class Model{
  siparisler: Array<Siparis>;
}

export class Siparis{
  siparisId:number;
  urunName: string;
  price: number;
  siparisDurumu: string;

  constructor(Id: number, Name: string, price: number, siparisDurum:string){
    this.urunName = Name ;  //burada sadece adını alıyoruz
    this.siparisId= Id;
    this.price =price;//bu şekilde de yazabiliriz ama buradaki değerleri değiştirebiliriz.
    this.siparisDurumu= siparisDurum;
  }
}
