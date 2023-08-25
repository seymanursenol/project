import { Component, OnInit } from '@angular/core';
import { Product } from '../models/product';
import { ProductService } from '../Service/product.service';
@Component({
  selector: 'rest-product',
  templateUrl: './rest-product.component.html',
  styleUrls: ['./rest-product.component.css']
})
export class RestProductComponent implements OnInit {
  products : Product[];

  count:number=0;

  constructor(private productService:ProductService) {
  }

  ngOnInit(): void {
    this.getProducts();
  }

  getProducts(){
    this.productService.getProduct().subscribe(products =>{
      this.products= products;
      console.log(products);
    })

  }

  Ekleme(){
    this.count++;

  }
  Cikarma(){
    if(this.count!=0 && this.count>0)
    this.count--;

  }

}
