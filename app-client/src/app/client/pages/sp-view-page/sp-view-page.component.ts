import { Component } from '@angular/core';

import { MatTableDataSource } from '@angular/material/table';

import { Client } from '@/app/client/interfaces/client';
import { ClientTableComponent } from '@/app/client/components/client-table/client-table.component';
import { ClientService } from '@/app/client/services/client.service';

@Component({
  selector: 'app-sp-view-page',
  imports: [ClientTableComponent],
  templateUrl: './sp-view-page.component.html',
  styleUrl: './sp-view-page.component.css',
})
export default class SpViewPageComponent {
  public dataSource: MatTableDataSource<Client> =
    new MatTableDataSource<Client>();
  public totalItems = 0;

  constructor(private clientService: ClientService) {}

  public loadClientsSp(page: number, pageSize: number) {
    const data = this.clientService.getClientsSp(page, pageSize);
    data.subscribe((response) => {
      this.dataSource = new MatTableDataSource<Client>(response.output.data);
      this.totalItems = response.output.length;
    });
  }
}
