import { Component, OnInit } from "@angular/core";

declare interface RouteInfo {
  path: string;
  title: string;
  rtlTitle: string;
  icon: string;
  class: string;
}
export const ROUTES: RouteInfo[] = [  
  {
    path: "/dashboard",
    title: "Sổ Giao Dịch",
    rtlTitle: "لوحة القيادة",
    icon: "icon-chart-pie-36",
    class: ""
  },
  {
    path: "/add",
    title: "Thêm Giao Dịch",
    rtlTitle: "",
    icon: "icon-simple-add",
    class: ""
  },
  {
    path: "/tables",
    title: "Thống Kê",
    rtlTitle: "قائمة الجدول",
    icon: "icon-bullet-list-67",
    class: ""
  },
  {
    path: "/ke-hoach",
    title: "Kế Hoạch",
    rtlTitle: "",
    icon: "icon-paper",
    class: ""
  },
  {
    path: "/user",
    title: "Thông Tin Tài Khoản",
    rtlTitle: "ملف تعريفي للمستخدم",
    icon: "icon-single-02",
    class: ""
  },
  {
    path: "/re-pass",
    title: "Đổi mật khẩu",
    rtlTitle: "ملف تعريفي للمستخدم",
    icon: "icon-single-02",
    class: ""
  },
  {
    path: "/icons",
    title: "Icons",
    rtlTitle: "الرموز",
    icon: "icon-atom",
    class: ""
  },
  /*{
    path: "/maps",
    title: "Maps",
    rtlTitle: "خرائط",
    icon: "icon-pin",
    class: "" },*/
  {
    path: "/gioi-thieu",
    title: "Giới Thiệu",
    rtlTitle: "الرموز",
    icon: "icon-pencil",
    class: ""
  },
  {
    path: "/notifications",
    title: "Thông Báo",
    rtlTitle: "إخطارات",
    icon: "icon-bell-55",
    class: ""
  },
  
  /*{
    path: "/typography",
    title: "Setting",
    rtlTitle: "طباعة",
    icon: "icon-settings-gear-63",
    class: ""
  },
  {
    path: "/rtl",
    title: "RTL Support",
    rtlTitle: "ار تي ال",
    icon: "icon-world",
    class: ""
  }*/
];

@Component({
  selector: "app-sidebar",
  templateUrl: "./sidebar.component.html",
  styleUrls: ["./sidebar.component.css"]
})
export class SidebarComponent implements OnInit {
  menuItems: any[];

  constructor() {}

  ngOnInit() {
    this.menuItems = ROUTES.filter(menuItem => menuItem);
  }
  isMobileMenu() {
    if (window.innerWidth > 991) {
      return false;
    }
    return true;
  }
}
