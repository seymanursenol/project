import { Component } from '@angular/core';
import { ProductService } from 'src/app/Service/product.service';
import { Model, Product } from 'src/app/models/product';

@Component({
  selector: 'p-add',
  templateUrl: './p-add.component.html',
  styleUrls: ['./p-add.component.css']
})
export class PAddComponent {

  model = new Model();

  products: Product[];

  price : number = 0;

  constructor(private productService: ProductService)
  { }


  Add(ProductName:string,Aciklama:string, price:number){

    const newProducts: Product={
      productId:0,
      name: ProductName,
      aciklama: Aciklama,
      price: price,
      restorantId: 1
    }

    this.productService.GetProductsAdd(newProducts).subscribe(product => this.products.push(product));

    console.log(newProducts);

  }

}
