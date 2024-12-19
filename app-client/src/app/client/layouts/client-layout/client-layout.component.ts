import { Component } from '@angular/core';
import { RouterModule } from '@angular/router';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatButtonModule } from '@angular/material/button';
import { MatIconModule } from '@angular/material/icon';
import { MatSidenavModule } from '@angular/material/sidenav';
import { MatListModule } from '@angular/material/list';

@Component({
  selector: 'app-client-layout',
  imports: [
    RouterModule,
    MatToolbarModule,
    MatButtonModule,
    MatIconModule,
    MatSidenavModule,
    MatListModule,
  ],
  templateUrl: './client-layout.component.html',
  styleUrl: './client-layout.component.css',
})
export default class ClientLayoutComponent {
  public contentNav = [
    {
      link: 'ef-view',
      isActive: false,
      name: 'Entity Framework Core View',
      icon: 'list',
    },
    {
      link: 'sp-view',
      isActive: false,
      name: 'Stored Procedure View',
      icon: 'list',
    },
  ];
}
