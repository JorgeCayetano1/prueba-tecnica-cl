import {
  AfterViewInit,
  Component,
  EventEmitter,
  Input,
  OnInit,
  Output,
  ViewChild,
} from '@angular/core';

import { MatTableDataSource } from '@angular/material/table';
import { MatTableModule } from '@angular/material/table';
import { MatPaginator, MatPaginatorModule } from '@angular/material/paginator';

import { Client } from '@/app/client/interfaces/client';
import { PhoneFormatPipe } from '@/app/client/pipes/phone-format.pipe';

@Component({
  selector: 'client-table',
  imports: [PhoneFormatPipe, MatTableModule, MatPaginatorModule],
  templateUrl: './client-table.component.html',
  styleUrl: './client-table.component.css',
})
export class ClientTableComponent implements OnInit, AfterViewInit {
  public displayedColumns: string[] = ['id', 'name', 'country', 'phone'];

  @ViewChild(MatPaginator)
  public paginator!: MatPaginator;

  @Input({ required: true })
  public dataSource: MatTableDataSource<Client> =
    new MatTableDataSource<Client>();

  @Input({ required: true })
  public totalItems = 0;

  @Output()
  public pageChange = new EventEmitter<{ page: number; pageSize: number }>();

  ngOnInit(): void {
    this.pageChange.emit({
      page: 1,
      pageSize: 5,
    });
  }

  public ngAfterViewInit() {
    this.paginator.page.subscribe(() => {
      this.pageChange.emit({
        page: this.paginator.pageIndex + 1,
        pageSize: this.paginator.pageSize,
      });
    });
  }
}
