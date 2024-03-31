import { Component, Injector, ViewEncapsulation } from '@angular/core';
import { AppComponentBase } from '@shared/common/app-component-base';
import { appModuleAnimation } from '@shared/animations/routerTransition';

@Component({
    templateUrl: './event.component.html',
    styleUrls: ['./event.component.less'],
    animations: [appModuleAnimation()]
})
export class EventComponent extends AppComponentBase {

    constructor(injector: Injector) {
        super(injector);
    }
}
