import { Component, OnInit } from '@angular/core';
import { DataService } from 'src/app/data.service';

@Component({
  selector: 'app-sorteio',
  templateUrl: './sorteio.component.html',
  styleUrls: ['./sorteio.component.css']
})
export class SorteioComponent implements OnInit {

  public sorteioidosos: any = null;
  public sorteiopcds: any = null;
  public sorteiogerais: any = null;
  constructor(
    private service: DataService,
  ) { }

  ngOnInit(): void {
    this.service.getSorteioIdosos().subscribe((data: any) => this.sorteioidosos = data);
    this.service.getSorteioPcds().subscribe((data: any) => this.sorteiopcds = data);
    this.service.getSorteioGerais().subscribe((data: any) => this.sorteiogerais = data);
  }
}
