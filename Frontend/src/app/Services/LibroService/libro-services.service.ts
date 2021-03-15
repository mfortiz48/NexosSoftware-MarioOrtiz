import { Injectable } from '@angular/core';
import { environment } from '../../../environments/environment';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { Observable } from 'rxjs';


@Injectable({
  providedIn: 'root'
})
export class LibroServicesService {
  private controller = 'Libros/';
  private ApiUrl = environment.apiUrl + this.controller;


  constructor(private Http: HttpClient) { }

  InsertLibro(Libro:any):Observable<any> {
    return this.Http.post(this.ApiUrl,Libro);
}
}
