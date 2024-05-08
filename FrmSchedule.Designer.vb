﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSchedule
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim TimeRuler1 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
        Dim TimeRuler2 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
        Me.SchedulerControl1 = New DevExpress.XtraScheduler.SchedulerControl()
        Me.SchedulerStorage1 = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.SchedulerBarController1 = New DevExpress.XtraScheduler.UI.SchedulerBarController()
        Me.CommonRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.CommonRibbonPageGroup()
        Me.FileRibbonPage1 = New DevExpress.XtraScheduler.UI.FileRibbonPage()
        Me.OpenScheduleItem1 = New DevExpress.XtraScheduler.UI.OpenScheduleItem()
        Me.SaveScheduleItem1 = New DevExpress.XtraScheduler.UI.SaveScheduleItem()
        Me.PrintRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.PrintRibbonPageGroup()
        Me.PrintPreviewItem1 = New DevExpress.XtraScheduler.UI.PrintPreviewItem()
        Me.PrintItem1 = New DevExpress.XtraScheduler.UI.PrintItem()
        Me.PrintPageSetupItem1 = New DevExpress.XtraScheduler.UI.PrintPageSetupItem()
        Me.AppointmentRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.AppointmentRibbonPageGroup()
        Me.HomeRibbonPage1 = New DevExpress.XtraScheduler.UI.HomeRibbonPage()
        Me.NewAppointmentItem1 = New DevExpress.XtraScheduler.UI.NewAppointmentItem()
        Me.NewRecurringAppointmentItem1 = New DevExpress.XtraScheduler.UI.NewRecurringAppointmentItem()
        Me.NavigatorRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.NavigatorRibbonPageGroup()
        Me.NavigateViewBackwardItem1 = New DevExpress.XtraScheduler.UI.NavigateViewBackwardItem()
        Me.NavigateViewForwardItem1 = New DevExpress.XtraScheduler.UI.NavigateViewForwardItem()
        Me.GotoTodayItem1 = New DevExpress.XtraScheduler.UI.GotoTodayItem()
        Me.ViewZoomInItem1 = New DevExpress.XtraScheduler.UI.ViewZoomInItem()
        Me.ViewZoomOutItem1 = New DevExpress.XtraScheduler.UI.ViewZoomOutItem()
        Me.ArrangeRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.ArrangeRibbonPageGroup()
        Me.SwitchToDayViewItem1 = New DevExpress.XtraScheduler.UI.SwitchToDayViewItem()
        Me.SwitchToWorkWeekViewItem1 = New DevExpress.XtraScheduler.UI.SwitchToWorkWeekViewItem()
        Me.SwitchToWeekViewItem1 = New DevExpress.XtraScheduler.UI.SwitchToWeekViewItem()
        Me.SwitchToMonthViewItem1 = New DevExpress.XtraScheduler.UI.SwitchToMonthViewItem()
        Me.SwitchToTimelineViewItem1 = New DevExpress.XtraScheduler.UI.SwitchToTimelineViewItem()
        Me.SwitchToGanttViewItem1 = New DevExpress.XtraScheduler.UI.SwitchToGanttViewItem()
        Me.GroupByRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.GroupByRibbonPageGroup()
        Me.GroupByNoneItem1 = New DevExpress.XtraScheduler.UI.GroupByNoneItem()
        Me.GroupByDateItem1 = New DevExpress.XtraScheduler.UI.GroupByDateItem()
        Me.GroupByResourceItem1 = New DevExpress.XtraScheduler.UI.GroupByResourceItem()
        Me.ActiveViewRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.ActiveViewRibbonPageGroup()
        Me.ViewRibbonPage1 = New DevExpress.XtraScheduler.UI.ViewRibbonPage()
        Me.TimeScaleRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.TimeScaleRibbonPageGroup()
        Me.SwitchTimeScalesItem1 = New DevExpress.XtraScheduler.UI.SwitchTimeScalesItem()
        Me.ChangeScaleWidthItem1 = New DevExpress.XtraScheduler.UI.ChangeScaleWidthItem()
        Me.SwitchTimeScalesCaptionItem1 = New DevExpress.XtraScheduler.UI.SwitchTimeScalesCaptionItem()
        Me.RepositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.LayoutRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.LayoutRibbonPageGroup()
        Me.SwitchCompressWeekendItem1 = New DevExpress.XtraScheduler.UI.SwitchCompressWeekendItem()
        Me.SwitchShowWorkTimeOnlyItem1 = New DevExpress.XtraScheduler.UI.SwitchShowWorkTimeOnlyItem()
        Me.SwitchCellsAutoHeightItem1 = New DevExpress.XtraScheduler.UI.SwitchCellsAutoHeightItem()
        Me.ChangeSnapToCellsUIItem1 = New DevExpress.XtraScheduler.UI.ChangeSnapToCellsUIItem()
        Me.ActionsRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.ActionsRibbonPageGroup()
        Me.AppointmentRibbonPage1 = New DevExpress.XtraScheduler.UI.AppointmentRibbonPage()
        Me.CalendarToolsRibbonPageCategory1 = New DevExpress.XtraScheduler.UI.CalendarToolsRibbonPageCategory()
        Me.EditAppointmentQueryItem1 = New DevExpress.XtraScheduler.UI.EditAppointmentQueryItem()
        Me.EditOccurrenceUICommandItem1 = New DevExpress.XtraScheduler.UI.EditOccurrenceUICommandItem()
        Me.EditSeriesUICommandItem1 = New DevExpress.XtraScheduler.UI.EditSeriesUICommandItem()
        Me.DeleteAppointmentsItem1 = New DevExpress.XtraScheduler.UI.DeleteAppointmentsItem()
        Me.DeleteOccurrenceItem1 = New DevExpress.XtraScheduler.UI.DeleteOccurrenceItem()
        Me.DeleteSeriesItem1 = New DevExpress.XtraScheduler.UI.DeleteSeriesItem()
        Me.SplitAppointmentItem1 = New DevExpress.XtraScheduler.UI.SplitAppointmentItem()
        Me.OptionsRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.OptionsRibbonPageGroup()
        Me.ChangeAppointmentStatusItem1 = New DevExpress.XtraScheduler.UI.ChangeAppointmentStatusItem()
        Me.ChangeAppointmentLabelItem1 = New DevExpress.XtraScheduler.UI.ChangeAppointmentLabelItem()
        Me.ToggleRecurrenceItem1 = New DevExpress.XtraScheduler.UI.ToggleRecurrenceItem()
        Me.ChangeAppointmentReminderItem1 = New DevExpress.XtraScheduler.UI.ChangeAppointmentReminderItem()
        Me.RepositoryItemDuration1 = New DevExpress.XtraScheduler.UI.RepositoryItemDuration()
        CType(Me.SchedulerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SchedulerStorage1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SchedulerBarController1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDuration1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SchedulerControl1
        '
        Me.SchedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SchedulerControl1.Location = New System.Drawing.Point(0, 142)
        Me.SchedulerControl1.MenuManager = Me.RibbonControl1
        Me.SchedulerControl1.Name = "SchedulerControl1"
        Me.SchedulerControl1.Size = New System.Drawing.Size(1297, 443)
        Me.SchedulerControl1.Start = New Date(2015, 6, 6, 0, 0, 0, 0)
        Me.SchedulerControl1.Storage = Me.SchedulerStorage1
        Me.SchedulerControl1.TabIndex = 0
        Me.SchedulerControl1.Text = "SchedulerControl1"
        Me.SchedulerControl1.Views.DayView.TimeRulers.Add(TimeRuler1)
        Me.SchedulerControl1.Views.WorkWeekView.TimeRulers.Add(TimeRuler2)
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.OpenScheduleItem1, Me.SaveScheduleItem1, Me.PrintPreviewItem1, Me.PrintItem1, Me.PrintPageSetupItem1, Me.NewAppointmentItem1, Me.NewRecurringAppointmentItem1, Me.NavigateViewBackwardItem1, Me.NavigateViewForwardItem1, Me.GotoTodayItem1, Me.ViewZoomInItem1, Me.ViewZoomOutItem1, Me.SwitchToDayViewItem1, Me.SwitchToWorkWeekViewItem1, Me.SwitchToWeekViewItem1, Me.SwitchToMonthViewItem1, Me.SwitchToTimelineViewItem1, Me.SwitchToGanttViewItem1, Me.GroupByNoneItem1, Me.GroupByDateItem1, Me.GroupByResourceItem1, Me.SwitchTimeScalesItem1, Me.ChangeScaleWidthItem1, Me.SwitchTimeScalesCaptionItem1, Me.SwitchCompressWeekendItem1, Me.SwitchShowWorkTimeOnlyItem1, Me.SwitchCellsAutoHeightItem1, Me.ChangeSnapToCellsUIItem1, Me.EditAppointmentQueryItem1, Me.EditOccurrenceUICommandItem1, Me.EditSeriesUICommandItem1, Me.DeleteAppointmentsItem1, Me.DeleteOccurrenceItem1, Me.DeleteSeriesItem1, Me.SplitAppointmentItem1, Me.ChangeAppointmentStatusItem1, Me.ChangeAppointmentLabelItem1, Me.ToggleRecurrenceItem1, Me.ChangeAppointmentReminderItem1})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 40
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.PageCategories.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageCategory() {Me.CalendarToolsRibbonPageCategory1})
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.FileRibbonPage1, Me.HomeRibbonPage1, Me.ViewRibbonPage1})
        Me.RibbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemSpinEdit1, Me.RepositoryItemDuration1})
        Me.RibbonControl1.Size = New System.Drawing.Size(1297, 142)
        '
        'SchedulerBarController1
        '
        Me.SchedulerBarController1.BarItems.Add(Me.OpenScheduleItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.SaveScheduleItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.PrintPreviewItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.PrintItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.PrintPageSetupItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.NewAppointmentItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.NewRecurringAppointmentItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.NavigateViewBackwardItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.NavigateViewForwardItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.GotoTodayItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.ViewZoomInItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.ViewZoomOutItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.SwitchToDayViewItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.SwitchToWorkWeekViewItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.SwitchToWeekViewItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.SwitchToMonthViewItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.SwitchToTimelineViewItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.SwitchToGanttViewItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.GroupByNoneItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.GroupByDateItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.GroupByResourceItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.SwitchTimeScalesItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.ChangeScaleWidthItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.SwitchTimeScalesCaptionItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.SwitchCompressWeekendItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.SwitchShowWorkTimeOnlyItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.SwitchCellsAutoHeightItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.ChangeSnapToCellsUIItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.EditAppointmentQueryItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.EditOccurrenceUICommandItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.EditSeriesUICommandItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.DeleteAppointmentsItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.DeleteOccurrenceItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.DeleteSeriesItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.SplitAppointmentItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.ChangeAppointmentStatusItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.ChangeAppointmentLabelItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.ToggleRecurrenceItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.ChangeAppointmentReminderItem1)
        Me.SchedulerBarController1.Control = Me.SchedulerControl1
        '
        'CommonRibbonPageGroup1
        '
        Me.CommonRibbonPageGroup1.ItemLinks.Add(Me.OpenScheduleItem1)
        Me.CommonRibbonPageGroup1.ItemLinks.Add(Me.SaveScheduleItem1)
        Me.CommonRibbonPageGroup1.Name = "CommonRibbonPageGroup1"
        '
        'FileRibbonPage1
        '
        Me.FileRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.CommonRibbonPageGroup1, Me.PrintRibbonPageGroup1})
        Me.FileRibbonPage1.Name = "FileRibbonPage1"
        '
        'OpenScheduleItem1
        '
        Me.OpenScheduleItem1.Id = 1
        Me.OpenScheduleItem1.Name = "OpenScheduleItem1"
        '
        'SaveScheduleItem1
        '
        Me.SaveScheduleItem1.Id = 2
        Me.SaveScheduleItem1.Name = "SaveScheduleItem1"
        '
        'PrintRibbonPageGroup1
        '
        Me.PrintRibbonPageGroup1.ItemLinks.Add(Me.PrintPreviewItem1)
        Me.PrintRibbonPageGroup1.ItemLinks.Add(Me.PrintItem1)
        Me.PrintRibbonPageGroup1.ItemLinks.Add(Me.PrintPageSetupItem1)
        Me.PrintRibbonPageGroup1.Name = "PrintRibbonPageGroup1"
        '
        'PrintPreviewItem1
        '
        Me.PrintPreviewItem1.Id = 3
        Me.PrintPreviewItem1.Name = "PrintPreviewItem1"
        '
        'PrintItem1
        '
        Me.PrintItem1.Id = 4
        Me.PrintItem1.Name = "PrintItem1"
        '
        'PrintPageSetupItem1
        '
        Me.PrintPageSetupItem1.Id = 5
        Me.PrintPageSetupItem1.Name = "PrintPageSetupItem1"
        '
        'AppointmentRibbonPageGroup1
        '
        Me.AppointmentRibbonPageGroup1.ItemLinks.Add(Me.NewAppointmentItem1)
        Me.AppointmentRibbonPageGroup1.ItemLinks.Add(Me.NewRecurringAppointmentItem1)
        Me.AppointmentRibbonPageGroup1.Name = "AppointmentRibbonPageGroup1"
        '
        'HomeRibbonPage1
        '
        Me.HomeRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.AppointmentRibbonPageGroup1, Me.NavigatorRibbonPageGroup1, Me.ArrangeRibbonPageGroup1, Me.GroupByRibbonPageGroup1})
        Me.HomeRibbonPage1.Name = "HomeRibbonPage1"
        '
        'NewAppointmentItem1
        '
        Me.NewAppointmentItem1.Id = 6
        Me.NewAppointmentItem1.Name = "NewAppointmentItem1"
        '
        'NewRecurringAppointmentItem1
        '
        Me.NewRecurringAppointmentItem1.Id = 7
        Me.NewRecurringAppointmentItem1.Name = "NewRecurringAppointmentItem1"
        '
        'NavigatorRibbonPageGroup1
        '
        Me.NavigatorRibbonPageGroup1.ItemLinks.Add(Me.NavigateViewBackwardItem1)
        Me.NavigatorRibbonPageGroup1.ItemLinks.Add(Me.NavigateViewForwardItem1)
        Me.NavigatorRibbonPageGroup1.ItemLinks.Add(Me.GotoTodayItem1)
        Me.NavigatorRibbonPageGroup1.ItemLinks.Add(Me.ViewZoomInItem1)
        Me.NavigatorRibbonPageGroup1.ItemLinks.Add(Me.ViewZoomOutItem1)
        Me.NavigatorRibbonPageGroup1.Name = "NavigatorRibbonPageGroup1"
        '
        'NavigateViewBackwardItem1
        '
        Me.NavigateViewBackwardItem1.Id = 8
        Me.NavigateViewBackwardItem1.Name = "NavigateViewBackwardItem1"
        '
        'NavigateViewForwardItem1
        '
        Me.NavigateViewForwardItem1.Id = 9
        Me.NavigateViewForwardItem1.Name = "NavigateViewForwardItem1"
        '
        'GotoTodayItem1
        '
        Me.GotoTodayItem1.Id = 10
        Me.GotoTodayItem1.Name = "GotoTodayItem1"
        '
        'ViewZoomInItem1
        '
        Me.ViewZoomInItem1.Id = 11
        Me.ViewZoomInItem1.Name = "ViewZoomInItem1"
        '
        'ViewZoomOutItem1
        '
        Me.ViewZoomOutItem1.Id = 12
        Me.ViewZoomOutItem1.Name = "ViewZoomOutItem1"
        '
        'ArrangeRibbonPageGroup1
        '
        Me.ArrangeRibbonPageGroup1.ItemLinks.Add(Me.SwitchToDayViewItem1)
        Me.ArrangeRibbonPageGroup1.ItemLinks.Add(Me.SwitchToWorkWeekViewItem1)
        Me.ArrangeRibbonPageGroup1.ItemLinks.Add(Me.SwitchToWeekViewItem1)
        Me.ArrangeRibbonPageGroup1.ItemLinks.Add(Me.SwitchToMonthViewItem1)
        Me.ArrangeRibbonPageGroup1.ItemLinks.Add(Me.SwitchToTimelineViewItem1)
        Me.ArrangeRibbonPageGroup1.ItemLinks.Add(Me.SwitchToGanttViewItem1)
        Me.ArrangeRibbonPageGroup1.Name = "ArrangeRibbonPageGroup1"
        '
        'SwitchToDayViewItem1
        '
        Me.SwitchToDayViewItem1.Id = 13
        Me.SwitchToDayViewItem1.Name = "SwitchToDayViewItem1"
        '
        'SwitchToWorkWeekViewItem1
        '
        Me.SwitchToWorkWeekViewItem1.Id = 14
        Me.SwitchToWorkWeekViewItem1.Name = "SwitchToWorkWeekViewItem1"
        '
        'SwitchToWeekViewItem1
        '
        Me.SwitchToWeekViewItem1.Id = 15
        Me.SwitchToWeekViewItem1.Name = "SwitchToWeekViewItem1"
        '
        'SwitchToMonthViewItem1
        '
        Me.SwitchToMonthViewItem1.Id = 16
        Me.SwitchToMonthViewItem1.Name = "SwitchToMonthViewItem1"
        '
        'SwitchToTimelineViewItem1
        '
        Me.SwitchToTimelineViewItem1.Id = 17
        Me.SwitchToTimelineViewItem1.Name = "SwitchToTimelineViewItem1"
        '
        'SwitchToGanttViewItem1
        '
        Me.SwitchToGanttViewItem1.Id = 18
        Me.SwitchToGanttViewItem1.Name = "SwitchToGanttViewItem1"
        '
        'GroupByRibbonPageGroup1
        '
        Me.GroupByRibbonPageGroup1.ItemLinks.Add(Me.GroupByNoneItem1)
        Me.GroupByRibbonPageGroup1.ItemLinks.Add(Me.GroupByDateItem1)
        Me.GroupByRibbonPageGroup1.ItemLinks.Add(Me.GroupByResourceItem1)
        Me.GroupByRibbonPageGroup1.Name = "GroupByRibbonPageGroup1"
        '
        'GroupByNoneItem1
        '
        Me.GroupByNoneItem1.Id = 19
        Me.GroupByNoneItem1.Name = "GroupByNoneItem1"
        '
        'GroupByDateItem1
        '
        Me.GroupByDateItem1.Id = 20
        Me.GroupByDateItem1.Name = "GroupByDateItem1"
        '
        'GroupByResourceItem1
        '
        Me.GroupByResourceItem1.Id = 21
        Me.GroupByResourceItem1.Name = "GroupByResourceItem1"
        '
        'ActiveViewRibbonPageGroup1
        '
        Me.ActiveViewRibbonPageGroup1.ItemLinks.Add(Me.SwitchToDayViewItem1)
        Me.ActiveViewRibbonPageGroup1.ItemLinks.Add(Me.SwitchToWorkWeekViewItem1)
        Me.ActiveViewRibbonPageGroup1.ItemLinks.Add(Me.SwitchToWeekViewItem1)
        Me.ActiveViewRibbonPageGroup1.ItemLinks.Add(Me.SwitchToMonthViewItem1)
        Me.ActiveViewRibbonPageGroup1.ItemLinks.Add(Me.SwitchToTimelineViewItem1)
        Me.ActiveViewRibbonPageGroup1.ItemLinks.Add(Me.SwitchToGanttViewItem1)
        Me.ActiveViewRibbonPageGroup1.Name = "ActiveViewRibbonPageGroup1"
        '
        'ViewRibbonPage1
        '
        Me.ViewRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ActiveViewRibbonPageGroup1, Me.TimeScaleRibbonPageGroup1, Me.LayoutRibbonPageGroup1})
        Me.ViewRibbonPage1.Name = "ViewRibbonPage1"
        '
        'TimeScaleRibbonPageGroup1
        '
        Me.TimeScaleRibbonPageGroup1.ItemLinks.Add(Me.SwitchTimeScalesItem1)
        Me.TimeScaleRibbonPageGroup1.ItemLinks.Add(Me.ChangeScaleWidthItem1)
        Me.TimeScaleRibbonPageGroup1.ItemLinks.Add(Me.SwitchTimeScalesCaptionItem1)
        Me.TimeScaleRibbonPageGroup1.Name = "TimeScaleRibbonPageGroup1"
        '
        'SwitchTimeScalesItem1
        '
        Me.SwitchTimeScalesItem1.Id = 22
        Me.SwitchTimeScalesItem1.Name = "SwitchTimeScalesItem1"
        '
        'ChangeScaleWidthItem1
        '
        Me.ChangeScaleWidthItem1.Edit = Me.RepositoryItemSpinEdit1
        Me.ChangeScaleWidthItem1.Id = 23
        Me.ChangeScaleWidthItem1.Name = "ChangeScaleWidthItem1"
        Me.ChangeScaleWidthItem1.UseCommandCaption = True
        '
        'SwitchTimeScalesCaptionItem1
        '
        Me.SwitchTimeScalesCaptionItem1.Id = 24
        Me.SwitchTimeScalesCaptionItem1.Name = "SwitchTimeScalesCaptionItem1"
        '
        'RepositoryItemSpinEdit1
        '
        Me.RepositoryItemSpinEdit1.AutoHeight = False
        Me.RepositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemSpinEdit1.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.RepositoryItemSpinEdit1.MaxValue = New Decimal(New Integer() {200, 0, 0, 0})
        Me.RepositoryItemSpinEdit1.MinValue = New Decimal(New Integer() {10, 0, 0, 0})
        Me.RepositoryItemSpinEdit1.Name = "RepositoryItemSpinEdit1"
        '
        'LayoutRibbonPageGroup1
        '
        Me.LayoutRibbonPageGroup1.ItemLinks.Add(Me.SwitchCompressWeekendItem1)
        Me.LayoutRibbonPageGroup1.ItemLinks.Add(Me.SwitchShowWorkTimeOnlyItem1)
        Me.LayoutRibbonPageGroup1.ItemLinks.Add(Me.SwitchCellsAutoHeightItem1)
        Me.LayoutRibbonPageGroup1.ItemLinks.Add(Me.ChangeSnapToCellsUIItem1)
        Me.LayoutRibbonPageGroup1.Name = "LayoutRibbonPageGroup1"
        '
        'SwitchCompressWeekendItem1
        '
        Me.SwitchCompressWeekendItem1.Id = 25
        Me.SwitchCompressWeekendItem1.Name = "SwitchCompressWeekendItem1"
        '
        'SwitchShowWorkTimeOnlyItem1
        '
        Me.SwitchShowWorkTimeOnlyItem1.Id = 26
        Me.SwitchShowWorkTimeOnlyItem1.Name = "SwitchShowWorkTimeOnlyItem1"
        '
        'SwitchCellsAutoHeightItem1
        '
        Me.SwitchCellsAutoHeightItem1.Id = 27
        Me.SwitchCellsAutoHeightItem1.Name = "SwitchCellsAutoHeightItem1"
        '
        'ChangeSnapToCellsUIItem1
        '
        Me.ChangeSnapToCellsUIItem1.Id = 28
        Me.ChangeSnapToCellsUIItem1.Name = "ChangeSnapToCellsUIItem1"
        '
        'ActionsRibbonPageGroup1
        '
        Me.ActionsRibbonPageGroup1.ItemLinks.Add(Me.EditAppointmentQueryItem1)
        Me.ActionsRibbonPageGroup1.ItemLinks.Add(Me.DeleteAppointmentsItem1)
        Me.ActionsRibbonPageGroup1.ItemLinks.Add(Me.SplitAppointmentItem1)
        Me.ActionsRibbonPageGroup1.Name = "ActionsRibbonPageGroup1"
        '
        'AppointmentRibbonPage1
        '
        Me.AppointmentRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ActionsRibbonPageGroup1, Me.OptionsRibbonPageGroup1})
        Me.AppointmentRibbonPage1.Name = "AppointmentRibbonPage1"
        Me.AppointmentRibbonPage1.Visible = False
        '
        'CalendarToolsRibbonPageCategory1
        '
        Me.CalendarToolsRibbonPageCategory1.Control = Me.SchedulerControl1
        Me.CalendarToolsRibbonPageCategory1.Name = "CalendarToolsRibbonPageCategory1"
        Me.CalendarToolsRibbonPageCategory1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.AppointmentRibbonPage1})
        Me.CalendarToolsRibbonPageCategory1.Visible = False
        '
        'EditAppointmentQueryItem1
        '
        Me.EditAppointmentQueryItem1.Id = 29
        Me.EditAppointmentQueryItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.EditOccurrenceUICommandItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.EditSeriesUICommandItem1)})
        Me.EditAppointmentQueryItem1.Name = "EditAppointmentQueryItem1"
        Me.EditAppointmentQueryItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'EditOccurrenceUICommandItem1
        '
        Me.EditOccurrenceUICommandItem1.Id = 30
        Me.EditOccurrenceUICommandItem1.Name = "EditOccurrenceUICommandItem1"
        '
        'EditSeriesUICommandItem1
        '
        Me.EditSeriesUICommandItem1.Id = 31
        Me.EditSeriesUICommandItem1.Name = "EditSeriesUICommandItem1"
        '
        'DeleteAppointmentsItem1
        '
        Me.DeleteAppointmentsItem1.Id = 32
        Me.DeleteAppointmentsItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.DeleteOccurrenceItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.DeleteSeriesItem1)})
        Me.DeleteAppointmentsItem1.Name = "DeleteAppointmentsItem1"
        Me.DeleteAppointmentsItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'DeleteOccurrenceItem1
        '
        Me.DeleteOccurrenceItem1.Id = 33
        Me.DeleteOccurrenceItem1.Name = "DeleteOccurrenceItem1"
        '
        'DeleteSeriesItem1
        '
        Me.DeleteSeriesItem1.Id = 34
        Me.DeleteSeriesItem1.Name = "DeleteSeriesItem1"
        '
        'SplitAppointmentItem1
        '
        Me.SplitAppointmentItem1.Id = 35
        Me.SplitAppointmentItem1.Name = "SplitAppointmentItem1"
        '
        'OptionsRibbonPageGroup1
        '
        Me.OptionsRibbonPageGroup1.ItemLinks.Add(Me.ChangeAppointmentStatusItem1)
        Me.OptionsRibbonPageGroup1.ItemLinks.Add(Me.ChangeAppointmentLabelItem1)
        Me.OptionsRibbonPageGroup1.ItemLinks.Add(Me.ToggleRecurrenceItem1)
        Me.OptionsRibbonPageGroup1.ItemLinks.Add(Me.ChangeAppointmentReminderItem1)
        Me.OptionsRibbonPageGroup1.Name = "OptionsRibbonPageGroup1"
        '
        'ChangeAppointmentStatusItem1
        '
        Me.ChangeAppointmentStatusItem1.Id = 36
        Me.ChangeAppointmentStatusItem1.Name = "ChangeAppointmentStatusItem1"
        '
        'ChangeAppointmentLabelItem1
        '
        Me.ChangeAppointmentLabelItem1.Id = 37
        Me.ChangeAppointmentLabelItem1.Name = "ChangeAppointmentLabelItem1"
        '
        'ToggleRecurrenceItem1
        '
        Me.ToggleRecurrenceItem1.Id = 38
        Me.ToggleRecurrenceItem1.Name = "ToggleRecurrenceItem1"
        '
        'ChangeAppointmentReminderItem1
        '
        Me.ChangeAppointmentReminderItem1.Edit = Me.RepositoryItemDuration1
        Me.ChangeAppointmentReminderItem1.Id = 39
        Me.ChangeAppointmentReminderItem1.Name = "ChangeAppointmentReminderItem1"
        '
        'RepositoryItemDuration1
        '
        Me.RepositoryItemDuration1.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.RepositoryItemDuration1.AutoHeight = False
        Me.RepositoryItemDuration1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDuration1.Name = "RepositoryItemDuration1"
        Me.RepositoryItemDuration1.NullValuePromptShowForEmptyValue = True
        Me.RepositoryItemDuration1.ShowEmptyItem = True
        Me.RepositoryItemDuration1.ValidateOnEnterKey = True
        '
        'FrmSchedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1297, 585)
        Me.Controls.Add(Me.SchedulerControl1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Name = "FrmSchedule"
        Me.Text = "Schedule"
        CType(Me.SchedulerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SchedulerStorage1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SchedulerBarController1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDuration1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SchedulerControl1 As DevExpress.XtraScheduler.SchedulerControl
    Friend WithEvents SchedulerStorage1 As DevExpress.XtraScheduler.SchedulerStorage
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents OpenScheduleItem1 As DevExpress.XtraScheduler.UI.OpenScheduleItem
    Friend WithEvents SaveScheduleItem1 As DevExpress.XtraScheduler.UI.SaveScheduleItem
    Friend WithEvents PrintPreviewItem1 As DevExpress.XtraScheduler.UI.PrintPreviewItem
    Friend WithEvents PrintItem1 As DevExpress.XtraScheduler.UI.PrintItem
    Friend WithEvents PrintPageSetupItem1 As DevExpress.XtraScheduler.UI.PrintPageSetupItem
    Friend WithEvents NewAppointmentItem1 As DevExpress.XtraScheduler.UI.NewAppointmentItem
    Friend WithEvents NewRecurringAppointmentItem1 As DevExpress.XtraScheduler.UI.NewRecurringAppointmentItem
    Friend WithEvents NavigateViewBackwardItem1 As DevExpress.XtraScheduler.UI.NavigateViewBackwardItem
    Friend WithEvents NavigateViewForwardItem1 As DevExpress.XtraScheduler.UI.NavigateViewForwardItem
    Friend WithEvents GotoTodayItem1 As DevExpress.XtraScheduler.UI.GotoTodayItem
    Friend WithEvents ViewZoomInItem1 As DevExpress.XtraScheduler.UI.ViewZoomInItem
    Friend WithEvents ViewZoomOutItem1 As DevExpress.XtraScheduler.UI.ViewZoomOutItem
    Friend WithEvents SwitchToDayViewItem1 As DevExpress.XtraScheduler.UI.SwitchToDayViewItem
    Friend WithEvents SwitchToWorkWeekViewItem1 As DevExpress.XtraScheduler.UI.SwitchToWorkWeekViewItem
    Friend WithEvents SwitchToWeekViewItem1 As DevExpress.XtraScheduler.UI.SwitchToWeekViewItem
    Friend WithEvents SwitchToMonthViewItem1 As DevExpress.XtraScheduler.UI.SwitchToMonthViewItem
    Friend WithEvents SwitchToTimelineViewItem1 As DevExpress.XtraScheduler.UI.SwitchToTimelineViewItem
    Friend WithEvents SwitchToGanttViewItem1 As DevExpress.XtraScheduler.UI.SwitchToGanttViewItem
    Friend WithEvents GroupByNoneItem1 As DevExpress.XtraScheduler.UI.GroupByNoneItem
    Friend WithEvents GroupByDateItem1 As DevExpress.XtraScheduler.UI.GroupByDateItem
    Friend WithEvents GroupByResourceItem1 As DevExpress.XtraScheduler.UI.GroupByResourceItem
    Friend WithEvents SwitchTimeScalesItem1 As DevExpress.XtraScheduler.UI.SwitchTimeScalesItem
    Friend WithEvents ChangeScaleWidthItem1 As DevExpress.XtraScheduler.UI.ChangeScaleWidthItem
    Friend WithEvents RepositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents SwitchTimeScalesCaptionItem1 As DevExpress.XtraScheduler.UI.SwitchTimeScalesCaptionItem
    Friend WithEvents SwitchCompressWeekendItem1 As DevExpress.XtraScheduler.UI.SwitchCompressWeekendItem
    Friend WithEvents SwitchShowWorkTimeOnlyItem1 As DevExpress.XtraScheduler.UI.SwitchShowWorkTimeOnlyItem
    Friend WithEvents SwitchCellsAutoHeightItem1 As DevExpress.XtraScheduler.UI.SwitchCellsAutoHeightItem
    Friend WithEvents ChangeSnapToCellsUIItem1 As DevExpress.XtraScheduler.UI.ChangeSnapToCellsUIItem
    Friend WithEvents EditAppointmentQueryItem1 As DevExpress.XtraScheduler.UI.EditAppointmentQueryItem
    Friend WithEvents EditOccurrenceUICommandItem1 As DevExpress.XtraScheduler.UI.EditOccurrenceUICommandItem
    Friend WithEvents EditSeriesUICommandItem1 As DevExpress.XtraScheduler.UI.EditSeriesUICommandItem
    Friend WithEvents DeleteAppointmentsItem1 As DevExpress.XtraScheduler.UI.DeleteAppointmentsItem
    Friend WithEvents DeleteOccurrenceItem1 As DevExpress.XtraScheduler.UI.DeleteOccurrenceItem
    Friend WithEvents DeleteSeriesItem1 As DevExpress.XtraScheduler.UI.DeleteSeriesItem
    Friend WithEvents SplitAppointmentItem1 As DevExpress.XtraScheduler.UI.SplitAppointmentItem
    Friend WithEvents ChangeAppointmentStatusItem1 As DevExpress.XtraScheduler.UI.ChangeAppointmentStatusItem
    Friend WithEvents ChangeAppointmentLabelItem1 As DevExpress.XtraScheduler.UI.ChangeAppointmentLabelItem
    Friend WithEvents ToggleRecurrenceItem1 As DevExpress.XtraScheduler.UI.ToggleRecurrenceItem
    Friend WithEvents ChangeAppointmentReminderItem1 As DevExpress.XtraScheduler.UI.ChangeAppointmentReminderItem
    Friend WithEvents RepositoryItemDuration1 As DevExpress.XtraScheduler.UI.RepositoryItemDuration
    Friend WithEvents CalendarToolsRibbonPageCategory1 As DevExpress.XtraScheduler.UI.CalendarToolsRibbonPageCategory
    Friend WithEvents AppointmentRibbonPage1 As DevExpress.XtraScheduler.UI.AppointmentRibbonPage
    Friend WithEvents ActionsRibbonPageGroup1 As DevExpress.XtraScheduler.UI.ActionsRibbonPageGroup
    Friend WithEvents OptionsRibbonPageGroup1 As DevExpress.XtraScheduler.UI.OptionsRibbonPageGroup
    Friend WithEvents FileRibbonPage1 As DevExpress.XtraScheduler.UI.FileRibbonPage
    Friend WithEvents CommonRibbonPageGroup1 As DevExpress.XtraScheduler.UI.CommonRibbonPageGroup
    Friend WithEvents PrintRibbonPageGroup1 As DevExpress.XtraScheduler.UI.PrintRibbonPageGroup
    Friend WithEvents HomeRibbonPage1 As DevExpress.XtraScheduler.UI.HomeRibbonPage
    Friend WithEvents AppointmentRibbonPageGroup1 As DevExpress.XtraScheduler.UI.AppointmentRibbonPageGroup
    Friend WithEvents NavigatorRibbonPageGroup1 As DevExpress.XtraScheduler.UI.NavigatorRibbonPageGroup
    Friend WithEvents ArrangeRibbonPageGroup1 As DevExpress.XtraScheduler.UI.ArrangeRibbonPageGroup
    Friend WithEvents GroupByRibbonPageGroup1 As DevExpress.XtraScheduler.UI.GroupByRibbonPageGroup
    Friend WithEvents ViewRibbonPage1 As DevExpress.XtraScheduler.UI.ViewRibbonPage
    Friend WithEvents ActiveViewRibbonPageGroup1 As DevExpress.XtraScheduler.UI.ActiveViewRibbonPageGroup
    Friend WithEvents TimeScaleRibbonPageGroup1 As DevExpress.XtraScheduler.UI.TimeScaleRibbonPageGroup
    Friend WithEvents LayoutRibbonPageGroup1 As DevExpress.XtraScheduler.UI.LayoutRibbonPageGroup
    Friend WithEvents SchedulerBarController1 As DevExpress.XtraScheduler.UI.SchedulerBarController
End Class
