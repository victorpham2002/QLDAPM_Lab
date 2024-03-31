import { Component, Injector, ViewEncapsulation } from '@angular/core';
import { AppComponentBase } from '@shared/common/app-component-base';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { EventService } from './event.service';
import { formatDate } from '@angular/common';
@Component({
    templateUrl: './event.component.html',
    styleUrls: ['./event.component.less'],
    animations: [appModuleAnimation()]
})
export class EventComponent extends AppComponentBase{

    data=[];
    constructor(injector: Injector, private event: EventService) {
        super(injector);
    }

    ngOnInit(): void {
        this.getPeople();
    }

    getPeople(): void{
        this.event.getEvents().subscribe((result) => {
            console.log(result);
            this.data = result['result'];
        });
    }

    customDate(day: Date): string{
        return formatDate(day, 'dd-MM-yyyy', 'en-US');
    }
}
