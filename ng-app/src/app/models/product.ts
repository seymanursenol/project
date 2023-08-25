export class Model{
  products: Array<Product>;
}


export class Product{
  productId: number;
  name: string;
  aciklama:string;
  price: number;
  restorantId: number;

  constructor(ProductId: number, ProductName: string,  Aciklama:string,price:number,RestorantId:number){
    this.productId = ProductId ;
    this.name=  ProductName;
    this.aciklama = Aciklama;
    this.price = price;
    this.restorantId= RestorantId;

  }
}
