import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { EditorialServicesService } from '../../../Services/EditorialService/editorial-services.service';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-editorial',
  templateUrl: './editorial.component.html',
  styleUrls: ['./editorial.component.css']
})
export class EditorialComponent implements OnInit {

  FormEditorial: FormGroup;
  constructor(private fb: FormBuilder, private toastre: ToastrService ,private _editorialService : EditorialServicesService) {

this.FormEditorial = this.fb.group({

  Nombre:['',Validators.required],
  Direccion :['',Validators.required],
  Telefono :['',Validators.required],
  Email :['',Validators.required],
  LibrosRegistrados : ['',Validators.required]

})

   }

  ngOnInit(): void {
  }
  InsertEditorial()
  {
const Editorial: any ={
  Nombre: this.FormEditorial.get('Nombre')?.value,
  Direccion: this.FormEditorial.get('Direccion')?.value,
  Telefono: this.FormEditorial.get('Telefono')?.value,
  Email: this.FormEditorial.get('Email')?.value,
  LibrosRegistrados: this.FormEditorial.get('LibrosRegistrados')?.value
};

this._editorialService.InsertEditorial(Editorial).subscribe(EditorialData => {

  console.log(EditorialData);
  this.toastre.success(
    '¡Regitro creado Exitosamente!',
    'El autor fue registrado'
  );

  this.FormEditorial.reset();
}, error => {
  this.toastre.error('Ocurrio un error','Error',{positionClass : 'toast-bottom-right' })
  console.log(error);


} )}


}
