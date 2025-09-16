import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { HttpClient } from '@angular/common/http';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatButtonModule } from '@angular/material/button';
import { MatCardModule } from '@angular/material/card';
import { MatProgressSpinnerModule } from '@angular/material/progress-spinner';
import { MatIconModule } from '@angular/material/icon';

@Component({
  selector: 'app-cliente-buscar',
  standalone: true,
  imports: [
    CommonModule,
    FormsModule,
    MatFormFieldModule,
    MatInputModule,
    MatButtonModule,
    MatCardModule,
    MatProgressSpinnerModule,
    MatIconModule
  ],
  templateUrl: './cliente-buscar.component.html',
  styleUrls: ['./cliente-buscar.component.css'],
})
export class ClienteBuscarComponent {
  identificacion: string = '';
  cliente: any = null;
  loading = false;
  errorMessage: string | null = null;

  constructor(private http: HttpClient) {}

  buscarCliente() {
    if (!this.identificacion.trim()) {
      this.errorMessage = 'Por favor ingrese una identificación';
      return;
    }

    this.errorMessage = null;
    this.loading = true;
    this.cliente = null;

    this.http.get(`https://localhost:44342/api/Clientes/${this.identificacion}`)
      .subscribe({
        next: (data) => {
          this.cliente = data;
          this.loading = false;
        },
        error: () => {
          this.errorMessage = 'Cliente no encontrado';
          this.loading = false;
        }
      });
  }
}
