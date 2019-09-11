import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, FormArray } from '@angular/forms';
import { WeekDay } from '@angular/common';
import { NgxMaterialTimepickerTheme } from 'ngx-material-timepicker';
import { CenterService } from 'src/app/services/center.service';
import { ActivatedRoute, ParamMap } from '@angular/router';
import { map, switchMap } from 'rxjs/operators';
import WorkingHours from 'src/app/models/working-hours';
import * as moment from 'moment';

const defaultValues:WorkingHours[] = [
  { startTime: '0.00', endTime: '0.00', weekDayId: 1 }, { startTime: '0.00', endTime: '0.00', weekDayId: 2 },
  { startTime: '0.00', endTime: '0.00', weekDayId: 3 }, { startTime: '0.00', endTime: '0.00', weekDayId: 4 },
  { startTime: '0.00', endTime: '0.00', weekDayId: 5 }, { startTime: '0.00', endTime: '0.00', weekDayId: 6 },
  { startTime: '0.00', endTime: '0.00', weekDayId: 0 }
]


@Component({
  selector: 'app-center-admin-working-hours',
  templateUrl: './center-admin-working-hours.component.html',
  styleUrls: ['./center-admin-working-hours.component.scss']
})
export class CenterAdminWorkingHoursComponent implements OnInit {
  darkTheme: NgxMaterialTimepickerTheme = {
    container: {
        bodyBackgroundColor: '#fff',
        buttonColor: '#000'
    },
    dial: {
        dialBackgroundColor: '#000',
    },
    clockFace: {
        clockFaceBackgroundColor: '#555',
        clockHandColor: '#7c8179',
        clockFaceTimeInactiveColor: '#fff'
    }
  };
  private centerId: number;
  private workingHours: WorkingHours[];
  private workingHoursForm: FormGroup;
  private isCreateMode: boolean = false;

  constructor(
    private formBuilder: FormBuilder,
    private centerService: CenterService,
    private route: ActivatedRoute
  ) {
    this.workingHoursForm = formBuilder.group({
      weekdays: this.formBuilder.array([])
    });

    this.route.parent.paramMap
    .pipe(
      map((params: ParamMap) => params.get('id')),
      switchMap((id) => {
        this.centerId = +id;

        return centerService.getWorkingHours(this.centerId);
      })
    ).subscribe(workingHours => {
      if (workingHours.length){
        this.patch(this.reorderWeekdays(workingHours));
      } else {
        this.isCreateMode = true;
        this.patch(defaultValues);
      }
    });
   }

  ngOnInit() {
  }

  updateWorkingHours(data) {
    this.centerService.updateWorkingHours(this.centerId, data)
      .subscribe(() => {
        this.resetForm();
        this.centerService
          .getWorkingHours(this.centerId)
          .subscribe(workingHours => this.patch(this.reorderWeekdays(workingHours)));
      });
  }

  createWorkingHours(data) {
    this.centerService.createWorkingHours(this.centerId, data)
      .subscribe(() => {
        this.resetForm();
        this.centerService
          .getWorkingHours(this.centerId)
          .subscribe(workingHours => this.patch(this.reorderWeekdays(workingHours)));
      });
  }

  private patch(week: WorkingHours[]) {
    const control = <FormArray>this.workingHoursForm.get('weekdays');
    control.clear();
    week.forEach(weekday => {
      control.push(this.patchValues(weekday))
    })
  }
  private patchValues(weekday) {
    let st = moment(weekday.startTime, "HH:mm:ss").format("HH:mm");
    let end = moment(weekday.endTime, "HH:mm:ss").format("HH:mm");
    return this.formBuilder.group({
      startTime: [st],
      endTime: [end],
      name: [WeekDay[weekday.weekDayId]],
      weekDayId: weekday.weekDayId,
      centerId: this.centerId
    });
  }

  private reorderWeekdays(week: WorkingHours[]) : WorkingHours[] {
    let sunday = week.shift();
    week.push(sunday);
    this.workingHours = week;
    return week;
  }

  private resetForm() {
    this.workingHoursForm = this.formBuilder.group({
      weekdays: this.formBuilder.array([])
    });
    this.workingHours = [];
  }
}
