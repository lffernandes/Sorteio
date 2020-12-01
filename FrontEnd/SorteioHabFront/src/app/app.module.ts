import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { ReactiveFormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './pages/home/home.component';
import { CardComponent } from './components/card/card.component';
import { ButtonComponent } from './components/button/button.component';
import { TitleCardComponent } from './components/title-card/title-card.component';
import { ParticipanteListComponent } from './components/participante-list/participante-list.component';
import { TabsComponent } from './components/tabs/tabs.component';
import { IdosoComponent } from './pages/idoso/idoso.component';
import { PcdComponent } from './pages/pcd/pcd.component';
import { GeralComponent } from './pages/geral/geral.component';
import { SorteioComponent } from './pages/sorteio/sorteio.component';
import { SorteioListComponent } from './components/sorteio-list/sorteio-list.component';
import { SorteioTitleCardComponent } from './components/sorteio-title-card/sorteio-title-card.component';
import { TotalInfoComponent } from './components/total-info/total-info.component';




@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    CardComponent,
    ButtonComponent,
    TitleCardComponent,
    ParticipanteListComponent,
    TabsComponent,
    IdosoComponent,
    PcdComponent,
    GeralComponent,
    SorteioComponent,
    SorteioListComponent,
    SorteioTitleCardComponent,
    TotalInfoComponent,


  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    ReactiveFormsModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
