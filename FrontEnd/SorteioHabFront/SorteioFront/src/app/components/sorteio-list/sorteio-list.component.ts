import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-sorteio-list',
  templateUrl: './sorteio-list.component.html',
  styleUrls: ['./sorteio-list.component.css']
})
export class SorteioListComponent implements OnInit {
  @Input() sorteioidosos: any = null;
  @Input() sorteiopcds: any = null;
  @Input() sorteiogerais: any = null;
  constructor() { }

  ngOnInit(): void {
  }

}
