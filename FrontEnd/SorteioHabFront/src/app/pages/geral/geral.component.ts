import { Component, OnInit, Input } from '@angular/core';
import { DataService } from 'src/app/data.service';

@Component({
  selector: 'app-geral',
  templateUrl: './geral.component.html',
  styleUrls: ['./geral.component.css']
})
export class GeralComponent implements OnInit {
  public participantes: any = null;
  constructor(
    private service: DataService,
  ) { }

  ngOnInit(): void {
    this.service.getGeraisParticipantes().subscribe((data: any) => this.participantes = data);
  }
}
