import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-participante-list',
  templateUrl: './participante-list.component.html',
  styleUrls: ['./participante-list.component.css']
})
export class ParticipanteListComponent implements OnInit {
  @Input() participantes: any = null;
  constructor() { }

  ngOnInit(): void {
  }

}
