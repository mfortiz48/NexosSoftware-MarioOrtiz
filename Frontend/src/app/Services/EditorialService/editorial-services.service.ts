import { Injectable } from '@angular/core';
import { environment } from '../../../environments/environment';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class EditorialServicesService {
  private controller = 'Editoriales/';
  private ApiUrl = environment.apiUrl + this.controller;

  constructor(private Http: HttpClient) { }



  InsertEditorial(Editorial:any):Observable<any> {
    return this.Http.post(this.ApiUrl,Editorial);
}
}
