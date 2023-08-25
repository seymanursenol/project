import { Injectable } from '@angular/core';
import { Model, Siparis } from '../models/Siparis';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class SiparisService {

  baseUrl: string = "http://localhost:5132/";

  model = new Model();

  constructor(private http: HttpClient) { }

  getSiparis(): Observable<Siparis[]>{
    return this.http.get<Siparis[]>(this.baseUrl + 'api/siparis');
  }
}
