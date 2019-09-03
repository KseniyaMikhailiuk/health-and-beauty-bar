import { Component, OnInit, Output } from '@angular/core';
import { EventEmitter } from '@angular/core';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.scss']
})
export class HeaderComponent implements OnInit {

  constructor() { }

  @Output() toggleSidenav: EventEmitter<any> = new EventEmitter();

  ngOnInit() {
  }

  onMenuClick(): void {
    this.toggleSidenav.emit();
  }

}
