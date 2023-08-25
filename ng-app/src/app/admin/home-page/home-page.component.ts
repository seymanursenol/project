import { Component } from '@angular/core';
import { ProductService } from 'src/app/Service/product.service';
import { Product } from 'src/app/models/product';

@Component({
  selector: 'home-page',
  templateUrl: './home-page.component.html',
  styleUrls: ['./home-page.component.css']
})
export class HomePageComponent {

  products : Product[];

  count:number=0;

  constructor(private productService:ProductService)
  { }

  ngOnInit(): void {
    this.getProducts();
  }


  getProducts(){
    this.productService.getProduct().subscribe(products =>{
      this.products= products;
      console.log(products);
    })

  }

}
