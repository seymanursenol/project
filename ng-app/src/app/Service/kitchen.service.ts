import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Kitchen, Model } from '../models/kitchen';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class KitchenService {
  baseUrl: string= 'http://localhost:5132/';

  model = new Model();

  kitchenList: Kitchen[] = [];


  constructor( private http: HttpClient) {
  }

  GetKitchens(): Observable<Kitchen[]>{
      return this.http.get<Kitchen[]>(this.baseUrl + 'api/kitchens');
  }

  addProduct(kitchen: Kitchen){
    this.model.kitchens.push(kitchen);
  }

  // GetKitchenById(id: number){
  //   return this.model.kitchens.find(i=>i.kitchenId ==id)
  // }
}
