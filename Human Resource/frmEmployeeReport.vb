﻿Imports System.Data.OleDb
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frmEmployeeReport

    Private Sub frmEmployeeReport_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        frmMainMenu.Show()
    End Sub

    Private Sub frmEmployeeReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Cursor = Cursors.WaitCursor
            Timer1.Enabled = True
            Dim rpt As New rptEmployee() 'The report you created.
            Dim myConnection As oledbConnection
            Dim MyCommand As New oledbCommand()
            Dim myDA As New oledbDataAdapter()
            Dim myDS As New HMS_DBDataSet 'The DataSet you created.
            myConnection = New oledbConnection(cs)
            MyCommand.Connection = myConnection
            MyCommand.CommandText = "select EmployeeID, EmployeeName, Address, MobileNo, Email, Bloodgroup, Department, Designation, DateOfJoining, Salary, BasicWorkingTime from EmployeeRegistration order by EmployeeName"
            MyCommand.CommandType = CommandType.Text
            myDA.SelectCommand = MyCommand
            myDA.Fill(myDS, "EmployeeRegistration")
            rpt.SetDataSource(myDS)
            CrystalReportViewer1.ReportSource = rpt
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Cursor = Cursors.Default
        Timer1.Enabled = False
    End Sub
End Class