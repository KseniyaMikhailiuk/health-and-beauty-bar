import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, ParamMap } from '@angular/router';
import { map, switchMap } from 'rxjs/operators';

@Component({
  selector: 'app-center-admin',
  templateUrl: './center-admin.component.html',
  styleUrls: ['./center-admin.component.scss']
})
export class CenterAdminComponent implements OnInit {
  constructor() { }

  ngOnInit() {
  }

}
