import { Component } from '@angular/core';

import { MatTableDataSource } from '@angular/material/table';
import { Client } from '@/app/client/interfaces/client';
import { ClientService } from '@/app/client/services/client.service';
import { ClientTableComponent } from '@/app/client/components/client-table/client-table.component';

@Component({
  selector: 'app-ef-view-page',
  imports: [ClientTableComponent],
  templateUrl: './ef-view-page.component.html',
  styleUrl: './ef-view-page.component.css',
})
export default class EfViewPageComponent {
  public dataSource: MatTableDataSource<Client> =
    new MatTableDataSource<Client>();
  public totalItems = 0;

  constructor(private clientService: ClientService) {}

  public loadClientsEfCore(page: number, pageSize: number) {
    const data = this.clientService.getClientsEfCore(page, pageSize);
    data.subscribe((response) => {
      this.dataSource = new MatTableDataSource<Client>(response.output.data);
      this.totalItems = response.output.length;
    });
  }
}
