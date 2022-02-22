import { Routes } from "@angular/router";

import { DashboardComponent } from "../../pages/dashboard/dashboard.component";
import { IconsComponent } from "../../pages/icons/icons.component";
import { MapComponent } from "../../pages/map/map.component";
import { NotificationsComponent } from "../../pages/notifications/notifications.component";
import { UserComponent } from "../../pages/user/user.component";
import { TablesComponent } from "../../pages/tables/tables.component";
import { TypographyComponent } from "../../pages/typography/typography.component";
import { AddComponent} from 'src/app/pages/add/add.component';
import { KehoachComponent } from 'src/app/pages/ke-hoach/kehoach.component';
import { RepassComponent } from 'src/app/pages/re-pass/user.component';
import { GioithieuComponent } from 'src/app/pages/gioi-thieu/gioithieu.component';
import { AboutwebComponent } from 'src/app/pages/about-web/aboutweb.component';
// import { RtlComponent } from "../../pages/rtl/rtl.component";

export const AdminLayoutRoutes: Routes = [
  { path: "dashboard", component: DashboardComponent },
  { path: "icons", component: IconsComponent },
  { path: "maps", component: MapComponent },
  { path: "notifications", component: NotificationsComponent },
  { path: "user", component: UserComponent },
  { path: "tables", component: TablesComponent },
  { path: "typography", component: TypographyComponent },
  { path: "add", component: AddComponent},
  { path: "ke-hoach", component: KehoachComponent},
  { path: "re-pass", component: RepassComponent},
  { path: "gioi-thieu", component: GioithieuComponent},
  { path: "about-web", component: AboutwebComponent},
  // { path: "rtl", component: RtlComponent }
];
