import { Component } from '@angular/core';
import { ProductService } from 'src/app/Service/product.service';
import { Product } from 'src/app/models/product';

@Component({
  selector: 'p-delete',
  templateUrl: './p-delete.component.html',
  styleUrls: ['./p-delete.component.css']
})
export class PDeleteComponent {

  products:Product[];

  constructor(private productService: ProductService)
  {}

  ngOnInit(): void{
    this.GetProduct();
  }


  GetProduct(){
    this.productService.getProduct().subscribe(product =>{
      this.products = product;
    })
  }

  productDelete(product: Product){
    this.productService.getProductDelete(product).subscribe(p=>{
      this.products.splice(this.products.findIndex(p=>p.productId==product.productId),1);
    });
    console.log(product);
  }

}
