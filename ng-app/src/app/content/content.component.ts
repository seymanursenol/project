import { Component, OnInit } from '@angular/core';
import { Product } from '../models/product';
import { ProductService } from '../Service/product.service';
import { Kitchen, Model } from '../models/kitchen';
import { KitchenService } from '../Service/kitchen.service';

@Component({
  selector: 'content',
  templateUrl: './content.component.html',
  styleUrls: ['./content.component.css']
})
export class ContentComponent implements OnInit {

  // products: Product[];
  model = new Model();

  kitchens: Kitchen[];


  constructor( private productsService: ProductService) { }

  ngOnInit(): void {
  }


  // getProduct(){
  //   this.productsService.getProduct().subscribe(products=>{
  //     this.products = products
  //   })
  // }



 // getName(){
 //   return this.model.KitchenAd;
 // }



}
