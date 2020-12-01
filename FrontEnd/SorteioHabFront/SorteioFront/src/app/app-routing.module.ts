import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { GeralComponent } from './pages/geral/geral.component';
import { HomeComponent } from './pages/home/home.component';
import { IdosoComponent } from './pages/idoso/idoso.component';
import { PcdComponent } from './pages/pcd/pcd.component';
import { SorteioComponent } from './pages/sorteio/sorteio.component';

const routes: Routes = [
  {

    path: '', component: HomeComponent, children: [
      { path: '', component: IdosoComponent },
      { path: 'pcd', component: PcdComponent },
      { path: 'geral', component: GeralComponent },
    ]
  },
  { path: 'sorteio', component: SorteioComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
