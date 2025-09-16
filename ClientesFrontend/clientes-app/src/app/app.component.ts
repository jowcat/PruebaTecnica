import { Component } from '@angular/core';
//import { RouterOutlet } from '@angular/router';
import { ClienteBuscarComponent } from './components/cliente-buscar/cliente-buscar/cliente-buscar.component';

@Component({
  selector: 'app-root',
  standalone: true,
  //imports: [RouterOutlet],
  imports: [ClienteBuscarComponent],
  template: `<app-cliente-buscar></app-cliente-buscar>`,
})
export class AppComponent {
  title = 'clientes-app';
}
