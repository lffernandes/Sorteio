import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-total-info',
  templateUrl: './total-info.component.html',
  styleUrls: ['./total-info.component.css']
})
export class TotalInfoComponent implements OnInit {
  @Input() participantesvalidos: any = null;
  constructor() { }

  ngOnInit(): void {

  }

}
