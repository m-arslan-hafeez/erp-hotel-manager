﻿Imports System.Data.OleDb
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frmEmployeePaymentReport









    Private Sub button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button4.Click
        Try
            Dim rpt As New rptEmployeePayment() 'The report you created.
            Dim myConnection As oledbConnection
            Dim MyCommand As New oledbCommand()
            Dim myDA As New oledbDataAdapter()
            Dim myDS As New DataSet 'The DataSet you created.
            myConnection = New OleDbConnection(cs)
            MyCommand.Connection = myConnection
            MyCommand.CommandText = "select Employeename,EmployeeRegistration.EmployeeID,PaymentID,Designation,Department,EmployeePayment.salary,deduction,OvertimeAmount,Paymentdate,NetPay from employeepayment,EmployeeRegistration  where EmployeeRegistration.EmployeeID=EmployeePayment.EmployeeID and paymentdate between #" & DateFrom.Text & "# And #" & DateTo.Text & "#"
            MyCommand.CommandType = CommandType.Text
            myDA.SelectCommand = MyCommand
            myDA.Fill(myDS, "EmployeePayment")
            myDA.Fill(myDS, "EmployeeRegistration")
           
            rpt.SetDataSource(myDS)
            rpt.SetParameterValue("variable1", DateFrom.Value)
            rpt.SetParameterValue("variable2", DateTo.Value)
            CrystalReportViewer1.ReportSource = rpt
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmEmployeePaymentReport_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        frmMainMenu.Show()
    End Sub
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Close()

    End Sub
End Class