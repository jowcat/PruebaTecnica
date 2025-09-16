import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

export interface Cliente {
  identificacion: string;
  nombre: string;
  apellido: string;
  email: string;
}

@Injectable({
  providedIn: 'root'
})
export class ClienteService {

  private apiUrl = 'https://localhost:44342/api/Clientes';
  constructor(private http: HttpClient) { }
  getCliente(identificacion: string): Observable<Cliente> {
    return this.http.get<Cliente>(`${this.apiUrl}/${identificacion}`);
  }
}
