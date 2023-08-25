import { Injectable } from '@angular/core';
import { Model, Restorant } from '../models/restorant';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class RestorantService {

  baseUrl: string='http://localhost:5132/';

  model = new Model();

  constructor(private http: HttpClient) { }

  GetRestorant(): Observable<Restorant[]>{
    return this.http.get<Restorant[]>(this.baseUrl + 'api/restorants');
  }

  AddRestorant(restorant:Restorant): Observable<Restorant>{
    return this.http.post<Restorant>(this.baseUrl+ 'api/restorants', restorant);
  }

  GetRestorantById(id:number): Observable<Restorant[]>{
    return this.http.get<Restorant[]>(this.baseUrl + 'api/restorants/kitchen/{id}');
  }
}
