import { Component } from '@angular/core';
import { ProductService } from 'src/app/Service/product.service';
import { Product } from 'src/app/models/product';

@Component({
  selector: 'app-p-update',
  templateUrl: './p-update.component.html',
  styleUrls: ['./p-update.component.css']
})
export class PUpdateComponent {

  products:Product[];

  selectedProduct: any ={};

  constructor(private productService: ProductService){}

  ngOnInit(): void{
    this.GetProduct();
  }

  // Update(ProductName:string,Aciklama:string, price:number){

  //   const newProducts: Product={
  //     productId:0,
  //     name: ProductName,
  //     aciklama: Aciklama,
  //     price: price,
  //     restorantId: 1
  //   }

  //   const p = this.productService.GetProductsAdd(newProducts).subscribe(product => this.products.push(product));

  //   console.log(newProducts);

  // }

  GetProduct(){
    this.productService.getProduct().subscribe(product =>{
      this.products = product;
    })
  }

  onSelectProduct(product:any){
    this.selectedProduct = {
      productId: product.productId,
      name: product.name,
      aciklama: product.aciklama,
      price: product.price
    };
    console.log(this.selectedProduct);
  }

  Update(productId:number,name:string,aciklama: string, price:number,restorantId:number){

  const p= new Product(productId,name,aciklama,price,restorantId);

     this.productService.UpdateProduct(p)
     .subscribe(result => this.products
     .splice(this.products
     .findIndex(x=> x.productId==p.productId),1,p));

    console.log(p);

    this.selectedProduct = {
      productId: "",
      name: "",
      aciklama: "",
      price: ""
    };
  }


}
