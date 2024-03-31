import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { EventComponent } from './event/event.component';

@NgModule({
    imports: [
        RouterModule.forChild([
            {
                path: '',
                children: [
                    { path: 'event', component: EventComponent},
                    {
                        path: 'dashboard',
                        loadChildren: () => import('./dashboard/dashboard.module').then((m) => m.DashboardModule),
                        data: { permission: 'Pages.Tenant.Dashboard' },
                    },
                    { path: '', redirectTo: 'dashboard', pathMatch: 'full' },
                    { path: '**', redirectTo: 'dashboard' }
                ],
            },
        ]),
    ],
    exports: [RouterModule],
})
export class MainRoutingModule {}
