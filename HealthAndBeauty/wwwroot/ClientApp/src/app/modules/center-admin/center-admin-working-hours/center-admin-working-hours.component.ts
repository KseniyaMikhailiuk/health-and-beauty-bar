import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, FormArray } from '@angular/forms';
import { WeekDay } from '@angular/common';
import { NgxMaterialTimepickerTheme } from 'ngx-material-timepicker';
import { CenterService } from 'src/app/services/center.service';
import { ActivatedRoute, ParamMap } from '@angular/router';
import { map, switchMap } from 'rxjs/operators';
import WorkingHours from 'src/app/models/working-hours';
import * as moment from 'moment';
import * as datapicker from '../../../components/utils/time-picker-dark-theme'
import { NotificationsService } from 'angular2-notifications';
import { ChangeDetectorRef } from '@angular/core';

const defaultValues:WorkingHours[] = [
  { startTime: '0.00', endTime: '0.00', weekDayId: 1, isClosed: false }, { startTime: '0.00', endTime: '0.00', weekDayId: 2, isClosed: false },
  { startTime: '0.00', endTime: '0.00', weekDayId: 3, isClosed: false }, { startTime: '0.00', endTime: '0.00', weekDayId: 4, isClosed: false },
  { startTime: '0.00', endTime: '0.00', weekDayId: 5, isClosed: false }, { startTime: '0.00', endTime: '0.00', weekDayId: 6, isClosed: false },
  { startTime: '0.00', endTime: '0.00', weekDayId: 0, isClosed: false }
]


@Component({
  selector: 'app-center-admin-working-hours',
  templateUrl: './center-admin-working-hours.component.html',
  styleUrls: ['./center-admin-working-hours.component.scss']
})
export class CenterAdminWorkingHoursComponent implements OnInit {
  darkTheme: NgxMaterialTimepickerTheme = datapicker.getDarkTheme();
  private centerId: number;
  private workingHours: WorkingHours[];
  private workingHoursForm: FormGroup;
  private isCreateMode: boolean = false;

  constructor(
    private formBuilder: FormBuilder,
    private centerService: CenterService,
    private route: ActivatedRoute,
    private notificationService: NotificationsService,
    private cdr: ChangeDetectorRef
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
      .subscribe(
        () => {
          this.notificationService.success('Working hours are successfully apdated')
          this.centerService
            .getWorkingHours(this.centerId)
            .subscribe((workingHours) => this.patch(this.reorderWeekdays(workingHours)))
        },
        () => { this.notificationService.error('Error on update') }
      );
  }

  createWorkingHours(data) {
    this.centerService.createWorkingHours(this.centerId, data)
      .subscribe(() => {
        this.notificationService.success('Working hours are successfully created')
        this.centerService
          .getWorkingHours(this.centerId)
          .subscribe(workingHours => this.patch(this.reorderWeekdays(workingHours)));
        },
        () => { this.notificationService.error('Error on create') }
      );
  }

  manageClosed(weekday: WorkingHours) {
    let vacation = this.workingHours.find(wh => wh.weekDayId === weekday.weekDayId);
    if (vacation) {
      vacation.isClosed = !vacation.isClosed;
    }
    this.patch(this.workingHours);
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
    let weekdayControl = this.formBuilder.group({
      startTime: [st],
      endTime: [end],
      name: [WeekDay[weekday.weekDayId]],
      weekDayId: weekday.weekDayId,
      centerId: this.centerId,
      isClosed: weekday.isClosed
    });
    weekdayControl.controls.isClosed.valueChanges
      .subscribe((value) => {
        this.manageClosed(value.weekDayId);
      })

    return weekdayControl;
  }

  private reorderWeekdays(week: WorkingHours[]) : WorkingHours[] {
    let sunday = week.shift();
    week.push(sunday);
    this.workingHours = week;
    return week;
  }
}
