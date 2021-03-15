import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LibrosComponent } from './Components/libros/libros.component';
import { LibroComponent } from './Components/Libros/libro/libro.component';
import { AutoresComponent } from './Components/autores/autores.component';
import { AutorComponent } from './Components/Autores/autor/autor.component';
import { ListAutoresComponent } from './Components/Autores/list-autores/list-autores.component';
import { EditorialesComponent } from './Components/editoriales/editoriales.component';
import { EditorialComponent } from './Components/Editoriales/editorial/editorial.component';
import { ListEditorialComponent } from './Components/Editoriales/list-editorial/list-editorial.component';
import { ReactiveFormsModule } from '@angular/forms';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ToastrModule ,ToastNoAnimation, ToastNoAnimationModule } from 'ngx-toastr';

import {HttpClientModule} from '@angular/common/http';



@NgModule({
  declarations: [
    AppComponent,
    LibrosComponent,
    LibroComponent,
    AutoresComponent,
    AutorComponent,
    ListAutoresComponent,
    EditorialesComponent,
    EditorialComponent,
    ListEditorialComponent,

  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    BrowserAnimationsModule, // required animations module
    ToastrModule.forRoot(), // ToastrModule added
    ToastNoAnimationModule.forRoot(),
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
