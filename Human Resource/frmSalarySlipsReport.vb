﻿Imports System.Data.OleDb
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frmSalarySlipsReport









    Private Sub frmSalarySlipsReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillcombo()
    End Sub

    
    Sub fillcombo()

        Try

            Dim CN As New oledbConnection(cs)

            CN.Open()
            adp = New oledbDataAdapter()
            adp.SelectCommand = New OleDbCommand("SELECT distinct  (employeename) FROM employeeRegistration,EmployeePayment where EmployeeRegistration.EmployeeID=Employeepayment.EmployeeID", CN)
            ds = New DataSet("ds")

            adp.Fill(ds)
            dtable = ds.Tables(0)
            EmployeeName.Items.Clear()

            For Each drow As DataRow In dtable.Rows
                EmployeeName.Items.Add(drow(0).ToString())
                'DocName.SelectedIndex = -1
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try

            Dim rpt As New rptSalarySlips() 'The report you created.
            Dim myConnection As OleDbConnection
            Dim MyCommand As New OleDbCommand()
            Dim myDA As New OleDbDataAdapter()
            Dim myDS As New DataSet 'The DataSet you created.
            myConnection = New OleDbConnection(cs)
            MyCommand.Connection = myConnection
            MyCommand.CommandText = "select PaymentID,Datefrom,dateTo,EmployeeRegistration.employeeid,employeename,designation,department,EmployeePayment.salary,presentdays,advance,deduction,overtime,overtimeamount,paymentdate,modeofpayment,netpay from EmployeePayment,EmployeeRegistration where EmployeeRegistration.EmployeeID=EmployeePayment.EmployeeID and PaymentDate between #" & DateTimePicker2.Text & "# And #" & DateTimePicker1.Text & "# and Employeename='" & EmployeeName.Text & "'"
            MyCommand.CommandType = CommandType.Text
            myDA.SelectCommand = MyCommand
            myDA.Fill(myDS, "EmployeePayment")
            myDA.Fill(myDS, "EmployeeRegistration")
            rpt.SetDataSource(myDS)
            CrystalReportViewer2.ReportSource = rpt
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        EmployeeName.Text = ""
        CrystalReportViewer2.ReportSource = Nothing
        DateTimePicker1.Text = Today
        DateTimePicker2.Text = Today
    End Sub

   

    Private Sub frmSalarySlipsReport_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        frmMainMenu.Show()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Close()
    End Sub
End Class