import { Injectable } from '@angular/core';
import { Model, Product } from '../models/product';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ProductService {

   baseUrl: string = "http://localhost:5132/";

  model = new Model();
  products: Product[];


  constructor(private http: HttpClient) {
  }

  getProduct(): Observable<Product[]>{
    return this.http.get<Product[]>(this.baseUrl + 'api/products');
  }

  getProductById(id : number){
    return this.model.products.find(i=>i.productId==id)

  }

  GetProductsAdd(product: Product):Observable<Product>{
    return this.http.post<Product>(this.baseUrl + 'api/products', product);
  }

  getProductDelete(product:Product):Observable<Product>{
    return this.http.delete<Product>(this.baseUrl+ 'api/products/'+ product.productId);
  }

  UpdateProduct(product: Product){
    return this.http.put<Product>(this.baseUrl+ 'api/products/' + product.productId,product);
  }

}
