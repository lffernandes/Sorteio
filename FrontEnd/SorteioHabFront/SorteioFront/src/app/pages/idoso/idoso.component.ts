import { Component, OnInit } from '@angular/core';
import { DataService } from 'src/app/data.service';

@Component({
  selector: 'app-idoso',
  templateUrl: './idoso.component.html',
  styleUrls: ['./idoso.component.css']
})
export class IdosoComponent implements OnInit {

  public participantes: any = null;
  constructor(
    private service: DataService,
  ) { }

  ngOnInit(): void {
    this.service.getIdososParticipantes().subscribe((data: any) => this.participantes = data);
  }
}
