import { Component, OnInit } from '@angular/core';
import { DataService } from 'src/app/data.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  public participantesvalidos = null;

  constructor(
    private service: DataService,
  ) { }

  ngOnInit(): void {
    this.service.getParticipantesValidos().subscribe((data: any) => this.participantesvalidos = data);
  }
}
