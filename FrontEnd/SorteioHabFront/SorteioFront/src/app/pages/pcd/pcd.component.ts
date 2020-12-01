import { Component, OnInit } from '@angular/core';
import { DataService } from 'src/app/data.service';

@Component({
  selector: 'app-pcd',
  templateUrl: './pcd.component.html',
  styleUrls: ['./pcd.component.css']
})
export class PcdComponent implements OnInit {
  public participantes: any = null;
  constructor(
    private service: DataService,
  ) { }

  ngOnInit(): void {
    this.service.getPcdsParticipantes().subscribe((data: any) => this.participantes = data);
  }
}