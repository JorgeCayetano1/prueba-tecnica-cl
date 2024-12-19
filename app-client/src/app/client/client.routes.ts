import { Routes } from '@angular/router';

export const clientRoutes: Routes = [
  {
    path: 'client',
    loadComponent: () =>
      import('@/app/client/layouts/client-layout/client-layout.component'),
    children: [
      {
        path: 'ef-view',
        loadComponent: () =>
          import('@/app/client/pages/ef-view-page/ef-view-page.component'),
      },
      {
        path: 'sp-view',
        loadComponent: () =>
          import('@/app/client/pages/sp-view-page/sp-view-page.component'),
      },
      {
        path: '**',
        redirectTo: 'ef-view',
        pathMatch: 'full',
      },
    ],
  },
  {
    path: '',
    redirectTo: 'client',
    pathMatch: 'full',
  },
];
