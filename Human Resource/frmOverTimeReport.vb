﻿Imports System.Data.OleDb
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frmOverTimeReport
    Private Const STR_SelectEmployeeRegistrationEmployeeIDEmployeeName As String = "select EmployeeRegistration.EmployeeID,EmployeeName,WorkingDate,InTime,OutTime,Overtime from EmployeeAttendance,EmployeeRegistration where EmployeeRegistration.EmployeeID=EmployeeAttendance.EmployeeID and WorkingDate between #"
    Private Sub button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button4.Click
        Try
            Cursor = Cursors.WaitCursor
            Timer1.Enabled = True
            Dim rpt As New rptOverTime() 'The report you created.
            Dim myConnection As oledbConnection
            Dim MyCommand As New oledbCommand()
            Dim myDA As New oledbDataAdapter()
            Dim myDS As New DataSet 'The DataSet you created.
            myConnection = New oledbConnection(cs)
            MyCommand.Connection = myConnection
            MyCommand.CommandText = STR_SelectEmployeeRegistrationEmployeeIDEmployeeName & DateFrom.Text & "# And #" & DateTo.Text & "# and Status='P' order by EmployeeName "
            MyCommand.CommandType = CommandType.Text
            myDA.SelectCommand = MyCommand
            myDA.Fill(myDS, "EmployeeAttendance")
            myDA.Fill(myDS, "EmployeeRegistration")
            rpt.SetDataSource(myDS)
            CrystalReportViewer1.ReportSource = rpt
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmOverTimeReport_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        frmMainMenu.Show()
    End Sub

    Private Sub button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) 
        CrystalReportViewer1.ReportSource = Nothing
        DateFrom.value = Today
        DateTo.value = Today
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Cursor = Cursors.Default
        Timer1.Enabled = False
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Close()
    End Sub
End Class