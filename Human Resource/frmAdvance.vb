﻿Imports System.Data.OleDb
Public Class frmAdvance

    Dim dtable As New DataTable






  
    Sub fillcombo()

        Try

            Dim CN As New oledbConnection(cs)

            CN.Open()
            adp = New oledbDataAdapter()
            adp.SelectCommand = New oledbCommand("SELECT distinct  (employeeid) FROM employeeregistration", CN)
            ds = New DataSet("ds")

            adp.Fill(ds)
            dtable = ds.Tables(0)
            EmployeeID.Items.Clear()

            For Each drow As DataRow In dtable.Rows
                EmployeeID.Items.Add(drow(0).ToString())

            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub advance_form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillcombo()
        GetData()
        Label2.Width = Me.Width
    End Sub

    Private Sub Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Save.Click

        If Len(Trim(EmployeeID.Text)) = 0 Then
            MessageBox.Show("Please select employee id", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            EmployeeID.Focus()
            Exit Sub
        End If


        If Len(Trim(Amount.Text)) = 0 Then
            MessageBox.Show("Please enter Amount", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Amount.Focus()
            Exit Sub
        End If

        Try
            con = New OleDbConnection(cs)
            con.Open()
            Dim ct As String = "select employeeid,workingdate from AdvanceEntry where employeeid='" & EmployeeID.Text & "' and workingdate= #" & EntryDate.Text & "#"

            cmd = New OleDbCommand(ct)
            cmd.Connection = con

            rdr = cmd.ExecuteReader()

            If rdr.Read Then
                MessageBox.Show("advance is already paid to employee today", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                EmployeeID.Focus()

                If Not rdr Is Nothing Then
                    rdr.Close()
                End If
                Exit Sub
            End If
            con = New OleDbConnection(cs)
            con.Open()
            Dim cb As String = "insert into advanceentry(workingdate,employeeid,amount,deduction) VALUES ('" & EntryDate.Text & "','" & EmployeeID.Text & "'," & Amount.Text & ",0)"
            cmd = New OleDbCommand(cb)
            cmd.Connection = con
            cmd.ExecuteReader()
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Close()
            MessageBox.Show(" Advance Successfully saved", "Entry", MessageBoxButtons.OK, MessageBoxIcon.Information)
            GetData()
            Save.Enabled = False
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub EmployeeID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeID.SelectedIndexChanged
        Try
            Delete.Enabled = True
            con = New oledbConnection(cs)

            con.Open()


            Dim ct As String = "select employeename from employeeregistration where employeeid=@find"


            cmd = New oledbCommand(ct)
            cmd.Connection = con
            cmd.Parameters.Add(New oledbParameter("@find", oledbType.Varchar, 30, "employeeid"))
            cmd.Parameters("@find").Value = Trim(EmployeeID.Text)
            rdr = cmd.ExecuteReader()
            If rdr.Read Then

                EmployeeName.Text = Trim(rdr.GetString(0))

            End If

            If Not rdr Is Nothing Then
                rdr.Close()
            End If
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub GetData()
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("SELECT (EmployeeRegistration.EmployeeName) as [Employee Name],(EmployeeRegistration.EmployeeID) as [Employee ID],sum(Amount)-sum(Deduction) as [Total Advance] FROM EmployeeRegistration left join AdvanceEntry on EmployeeRegistration.EmployeeID=AdvanceEntry.EmployeeID group by EmployeeRegistration.employeename,employeeregistration.employeeid order by EmployeeName", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "AdvanceEntry")
            DataGridView1.DataSource = myDataSet.Tables("AdvanceEntry").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub Reset()
        EmployeeID.Text = ""
        EmployeeName.Text = ""
        Amount.Text = ""
        txtEmployee.Text = ""
        EntryDate.Text = Today
        GetData()
        Delete.Enabled = False
        Save.Enabled = True
    End Sub
    Private Sub NewRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewRecord.Click
        Reset()
    End Sub

    Private Sub Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delete.Click
        Try

            If EmployeeID.Text = "" Then
                MessageBox.Show("Please select employee id", "Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            If EmployeeID.Items.Count > 0 Then
                If MessageBox.Show("Do you really want to delete the records?", "Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                    delete_records()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub delete_records()
        Try

            Dim RowsAffected As Integer = 0

            con = New OleDbConnection(cs)

            con.Open()


            Dim cq As String = "delete from advanceentry where EmployeeID=@DELETE1 and WorkingDate=@DELETE2 and amount > 0 ;"

            cmd = New OleDbCommand(cq)

            cmd.Connection = con

            cmd.Parameters.Add(New oledbParameter("@DELETE1", oledbType.Varchar, 30, "EmployeeID"))

            cmd.Parameters.Add(New oledbParameter("@DELETE2", oledbType.Varchar, 30, "WorkingDate"))

            cmd.Parameters("@DELETE1").Value = Trim(EmployeeID.Text)

            cmd.Parameters("@DELETE2").Value = Trim(EntryDate.Text)
            RowsAffected = cmd.ExecuteNonQuery()
            If RowsAffected > 0 Then

                MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Reset()
                EmployeeID.Focus()
                Delete.Enabled = False
                GetData()
            Else
                MessageBox.Show("No record found", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Reset()
                con.Close()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub Amount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Amount.KeyPress
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then

            e.Handled = True

        End If
    End Sub


    Private Sub DataGridView1_RowHeaderMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseClick
        Try
            Dim dr As DataGridViewRow = DataGridView1.SelectedRows(0)
            Me.EmployeeName.Text = dr.Cells(0).Value.ToString()
            Me.EmployeeID.Text = dr.Cells(1).Value.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtEmployee_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEmployee.TextChanged
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("SELECT (EmployeeRegistration.EmployeeName) as [Employee Name],(EmployeeRegistration.EmployeeID) as [Employee ID],sum(Amount)-sum(Deduction) as [Total Advance] FROM EmployeeRegistration left join AdvanceEntry on EmployeeRegistration.EmployeeID=AdvanceEntry.EmployeeID  where EmployeeName like '" & txtEmployee.Text & "%' group by EmployeeRegistration.employeename,employeeregistration.employeeid order by EmployeeName", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "AdvanceEntry")
            DataGridView1.DataSource = myDataSet.Tables("AdvanceEntry").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Close()
        frmMainMenu.Show()
    End Sub

    Private Sub EntryDate_ValueChanged(sender As Object, e As EventArgs) Handles EntryDate.ValueChanged

    End Sub
End Class