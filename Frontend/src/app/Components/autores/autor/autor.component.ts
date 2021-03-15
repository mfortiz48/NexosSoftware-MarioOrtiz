import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { AutorService } from '../../../Services/autor.service';
import { AutorServicesService } from '../../../Services/AutorService/autor-services.service';

@Component({
  selector: 'app-autor',
  templateUrl: './autor.component.html',
  styleUrls: ['./autor.component.css'],
})
export class AutorComponent implements OnInit {
  formAutor: FormGroup;
  constructor(private fb: FormBuilder, private toastre: ToastrService, private _autorService:AutorServicesService) {
    this.formAutor = this.fb.group({
      Nombre: ['', Validators.required],
      FechaNacimiento: ['', [Validators.required]],
      Ciudad: ['', Validators.required],
      Email: ['', Validators.required],
    });
  }

  ngOnInit(): void {}

  InsertAutor() {
    const autor: any = {
      Nombre: this.formAutor.get('Nombre')?.value,
      FechaNacimiento: this.formAutor.get('FechaNacimiento')?.value,
      Ciudad: this.formAutor.get('Ciudad')?.value,
      Email: this.formAutor.get('Email')?.value,
    };
this._autorService.InsertAutor(autor).subscribe(autordata => {

  console.log(autor);
  this.toastre.success(
    '¡Regitro creado Exitosamente!',
    'El autor fue registrado'
  );
  this.formAutor.reset();

},error =>{
  this.toastre.error('Ocurrio un error','Error')
console.log(error);
})




}
}
