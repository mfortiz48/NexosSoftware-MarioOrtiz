import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { LibroServicesService } from '../../../Services/LibroService/libro-services.service';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-libro',
  templateUrl: './libro.component.html',
  styleUrls: ['./libro.component.css']
})
export class LibroComponent implements OnInit {


  FormLibro: FormGroup;
  constructor(private fb: FormBuilder, private toastre: ToastrService,private _libroService :LibroServicesService) {
this.FormLibro = this.fb.group({

  Titulo:['',Validators.required],
  Año :['',Validators.required],
  Genero :['',Validators.required],
  NumeroPaginas :['',Validators.required],
  Libro_Autor : ['',Validators.required],
  Libro_Editorial : ['',Validators.required]

})


  }

  ngOnInit(): void {
  }

  InsertAutor()
  {
const Libro : any ={

  Titulo: this.FormLibro.get('Titulo')?.value,
  Año: this.FormLibro.get('Año')?.value,
  Genero: this.FormLibro.get('Genero')?.value,
  NumeroPaginas: this.FormLibro.get('NumeroPaginas')?.value,
  Libro_Autor: this.FormLibro.get('Libro_Autor')?.value,
  Libro_Editorial: this.FormLibro.get('Libro_Editorial')?.value
};

this._libroService.InsertLibro(Libro).subscribe(libroData =>{

  console.log(libroData);
  this.toastre.success(
    '¡Regitro creado Exitosamente!',
    'El autor fue registrado'
  );

this.FormLibro.reset();
}, error => {

  this.toastre.error('Ocurrio un error','Error',{positionClass : 'toast-bottom-right' })
  console.log(error);
})}

}
