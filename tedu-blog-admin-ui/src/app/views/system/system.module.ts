import { NgModule } from '@angular/core';
import {CommonModule, DecimalPipe} from '@angular/common';
import { ReactiveFormsModule } from '@angular/forms';

import {
  AvatarModule,
  ButtonGroupModule,
  CardModule,
  FormModule,
  GridModule,
  NavModule,
  ProgressModule, SharedModule,
  TabsModule
} from '@coreui/angular';
import { IconModule } from '@coreui/icons-angular';
import { ChartjsModule } from '@coreui/angular-chartjs';
import {SystemRoutingModule} from "./system-routing.module";
import {UserComponent} from "./users/user.component";
import {RoleComponent} from "./roles/role.component";
import {RolesDetailComponent} from "./roles/roles-detail.component";
import {ProgressSpinnerModule} from "primeng/progressspinner";
import {BlockUIModule} from "primeng/blockui";
import {PaginatorModule} from "primeng/paginator";
import {PanelModule} from "primeng/panel";
import {CheckboxModule} from "primeng/checkbox";
import {InputTextModule} from "primeng/inputtext";
import {KeyFilterModule} from "primeng/keyfilter";
import {TableModule} from "primeng/table";
import {ButtonModule} from "primeng/button";


@NgModule({
  imports: [
    SystemRoutingModule,
    ReactiveFormsModule,
    TableModule,
    ProgressSpinnerModule,
    BlockUIModule,
    PaginatorModule,
    PanelModule,
    CheckboxModule,
    SharedModule,
    ButtonModule,
    InputTextModule,
    KeyFilterModule,
    DecimalPipe,
  ],
  declarations: [
    UserComponent,
    RoleComponent,
    RolesDetailComponent
  ]
})
export class SystemModule {
}
