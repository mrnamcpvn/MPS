import { INavData } from '@coreui/angular';

export const navItems: INavData[] = [
  {
    name: 'Dashboard',
    url: '/dashboard',
    icon: 'icon-speedometer',
  },
  {
    name: 'Kanban Program',
    url: '/kanban-program',
    icon: 'icon-screen-desktop',
    children: [
      {
        name: 'Daily Prepared Kanban',
        url: '/kanban-program/daily-prepared-kanban',
        class: 'menu-children'
      },
      {
        name: 'Weekly Prepared Kanban',
        url: '/kanban-program/weekly-prepared-kanban',
        class: 'menu-children'
      },
      {
        name: 'Material Calling List',
        url: '/kanban-program/material-calling-list',
        class: 'menu-children',
        children: [
          {
            name: 'Bottom',
            url: '/kanban-program/material-calling-list/bottom',
            class: 'menu-grand-children'
          },
          {
            name: 'Others',
            url: '/kanban-program/material-calling-list/others',
            class: 'menu-grand-children'
          },
        ]
      },
      {
        name: 'K501 WIP at Processing',
        url: '/kanban-program/k501-wip-at-processing',
        class: 'menu-children'
      },
    ]
  },
  {
    name: 'Query Program',
    url: '/query-program',
    icon: 'fa fa-list-alt',
    children: [
      {
        name: 'PUF Calling Query',
        url: '/query-program/puf-calling-query',
        class: 'menu-children'
      },
      {
        name: 'Q05 Component Query',
        url: '/query-program/q05-component-query',
        class: 'menu-children'
      },
    ]
  },
  {
    name: 'Maintain Program',
    url: '/maintain-program',
    icon: 'fa fa-files-o',
    children: [
      {
        name: '1.1 Full In WH',
        url: '/maintain-program/full-in-wh',
        class: 'menu-children'
      },
      {
        name: '1.2 Full Setting',
        url: '/maintain-program/full-setting',
        class: 'menu-children'
      },
      {
        name: '1.3 Full Ready',
        url: '/maintain-program/full-ready',
        class: 'menu-children'
      },
      {
        name: '1.4 Full Dispatch',
        url: '/maintain-program/full-dispatch',
        class: 'menu-children'
      },
      {
        name: '2.3 Bottom Ready',
        url: '/maintain-program/bottom-ready',
        class: 'menu-children'
      },
      {
        name: '2.4 Bottom Dispatch',
        url: '/maintain-program/bottom-dispatch',
        class: 'menu-children'
      },
      {
        name: '2.5 Bottom Checking',
        url: '/maintain-program/bottom-checking',
        class: 'menu-children'
      },
      {
        name: '2.6 WH Notice Generate',
        url: '/maintain-program/wh-notice-generate',
        class: 'menu-children'
      },
      {
        name: '2.7 Balance Schedule Update',
        url: '/maintain-program/balance-schedule-update',
        class: 'menu-children'
      },
      {
        name: '2.8 Balance Closing',
        url: '/maintain-program/balance-chosing',
        class: 'menu-children'
      },
      {
        name: '3.1 Raw Material Calling',
        url: '/maintain-program/raw-material-calling',
        class: 'menu-children'
      },
      {
        name: '4.0 Replenish Check',
        url: '/maintain-program/replenish-check',
        class: 'menu-children'
      },
      {
        name: '4.0.1 Repl. Cancelation',
        url: '/maintain-program/repl-cancelation',
        class: 'menu-children'
      },
      {
        name: '4.1 Repl. Matl. (Not Ready)',
        url: '/maintain-program/repl-matl-not-ready',
        class: 'menu-children'
      },
      {
        name: '4.2 Repl. Matl (Shift Ready)',
        url: '/maintain-program/repl-malt-shift-ready',
        class: 'menu-children'
      },
      {
        name: '4.3 Repl. Matl (Ready)',
        url: '/maintain-program/repl-matl-ready',
        class: 'menu-children'
      },
      {
        name: '4.4 Collect Repl. to PB107A',
        url: '/maintain-program/collect-repl-to-pb107a',
        class: 'menu-children'
      },
      {
        name: '4.5 Repl. Matl (Dispatch)',
        url: '/maintain-program/repl-matl-dispatch',
        class: 'menu-children'
      },
      {
        name: '4.6 Repl. Matl. Schl. Update',
        url: '/maintain-program/repl-matl-schl-update',
        class: 'menu-children'
      },
      {
        name: '4.7 Collect Repl. Claim',
        url: '/maintain-program/collect-repl-claim',
        class: 'menu-children'
      },
      {
        name: '5.1 Component Basic Setting',
        url: '/maintain-program/component-basic-setting',
        class: 'menu-children'
      },
      {
        name: '5.2 Component Feedback',
        url: '/maintain-program/component-feedback',
        class: 'menu-children'
      },
      {
        name: '5.3 Component Upload Transaction',
        url: '/maintain-program/component-upload-transaction',
        class: 'menu-children'
      },
      {
        name: '5.4 PO Switch',
        url: '/maintain-program/po-switch',
        class: 'menu-children'
      },
    ]
  },
  {
    name: 'Report Program',
    url: '/report-program',
    icon: 'fa fa-newspaper-o',
    children: [
      {
        name: 'R01 Tracking report for Matl. Calling',
        url: '/report-program/r01-tracking-report-for-matl-calling',
        class: 'menu-children'
      },
      {
        name: 'R02 Notice Report',
        url: '/report-program/r02-notice-report',
        class: 'menu-children'
      },
      {
        name: 'R03 Replenishment Report',
        url: '/report-program/r03-replenishment-report',
        class: 'menu-children'
      },
      {
        name: 'R04 Audit Report',
        url: '/report-program/r04-audit-report',
        class: 'menu-children'
      },
      {
        name: 'R05 Component Report',
        url: '/report-program/r05-component-report',
        class: 'menu-children'
      },
    ]
  },
  {
    name: 'Basic Setting',
    url: '/basic-setting',
    icon: 'fa fa-gears',
    children: [
      {
        name: 'Users Management',
        url: '/basic-setting/user-management',
        class: 'menu-children'
      },
      {
        name: 'IP Kanban Management',
        url: '/basic-setting/ip-kanban-management',
        class: 'menu-children'
      },
    ]
  },
  {
    name: 'Centralize',
    url: '/centralize',
    icon: 'fa fa-bullseye',
    children: []
  },
];
