import { HttpRequest } from '@/app/shared/interfaces/http-request.interface';

import { HttpClient } from '@angular/common/http';
import { inject, Injectable } from '@angular/core';

import { environment } from '@/environments/environments.dev';
import { Client } from '@/app/client/interfaces/client';
import { Paginator } from '@/app/shared/interfaces/paginator.interface';

@Injectable({
  providedIn: 'root',
})
export class ClientService {
  private readonly baseUrl = environment.baseUrl;
  private http = inject(HttpClient);

  public getClientsEfCore(page: number, pageSize: number) {
    return this.http.get<HttpRequest<Paginator<Client>>>(
      `${this.baseUrl}/api/Client/ef?Page=${page}&PageSize=${pageSize}`
    );
  }

  public getClientsSp(page: number, pageSize: number) {
    return this.http.get<HttpRequest<Paginator<Client>>>(
      `${this.baseUrl}/api/Client/sp?Page=${page}&PageSize=${pageSize}`
    );
  }
}
