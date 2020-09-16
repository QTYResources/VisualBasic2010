Public Class MainForm

    Private m_cn As New SqlConnection()
    Private m_DA As SqlDataAdapter
    Private m_CB As SqlCommandBuilder
    Private m_DataTable As New DataTable
    Private m_rowPosition As Integer = 0

    Private Sub MainForm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        m_cn.Close()
        m_cn.Dispose()
    End Sub

    Private Sub ShowCurrentRecord()
        If m_DataTable.Rows.Count = 0 Then
            txtContactName.Text = ""
            txtState.Text = ""
            Exit Sub
        End If

        txtContactName.Text = _
           m_DataTable.Rows(m_rowPosition)("ContactName").ToString()
        txtState.Text = _
           m_DataTable.Rows(m_rowPosition)("State").ToString()
    End Sub

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        m_cn.ConnectionString = "Data Source=.\SQLEXPRESS; AttachDbFilename = " & _
                "C:\Temp\Test.mdf;Integrated Security=True;Connect Timeout=30;" & _
                "User Instance=True"
        m_cn.Open()

        m_DA = New SqlDataAdapter("Select * From Contacts", m_cn)
        m_CB = New SqlCommandBuilder(m_DA)

        m_DA.Fill(m_DataTable)

        Me.ShowCurrentRecord()

    End Sub

    Private Sub btnMoveFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMoveFirst.Click
        ' Move to the first row and show the data.
        m_rowPosition = 0
        Me.ShowCurrentRecord()

    End Sub

    Private Sub btnMovePrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMovePrevious.Click
        ' If not at the first row, go back one row and show the record.
        If m_rowPosition > 0 Then
            m_rowPosition = m_rowPosition - 1
            Me.ShowCurrentRecord()
        End If

    End Sub

    Private Sub btnMoveNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMoveNext.Click
        ' If not on the last row, advance one row and show the record.
        If m_rowPosition < (m_DataTable.Rows.Count - 1) Then
            m_rowPosition = m_rowPosition + 1
            Me.ShowCurrentRecord()
        End If

    End Sub

    Private Sub btnMoveLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMoveLast.Click
        ' If there are any rows in the data table, move to the last and show
        ' the record.
        If m_DataTable.Rows.Count > 0 Then
            m_rowPosition = m_DataTable.Rows.Count - 1
            Me.ShowCurrentRecord()
        End If

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        ' If there is existing data, update it.
        If m_DataTable.Rows.Count <> 0 Then
            m_DataTable.Rows(m_rowPosition)("ContactName") = txtContactName.Text
            m_DataTable.Rows(m_rowPosition)("State") = txtState.Text
            m_DA.Update(m_DataTable)
        End If

    End Sub

    Private Sub btnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNew.Click
        Dim drNewRow As DataRow = m_DataTable.NewRow()

        drNewRow("ContactName") = txtNewContactName.Text
        drNewRow("State") = txtNewState.Text
        m_DataTable.Rows.Add(drNewRow)
        m_DA.Update(m_DataTable)
        m_rowPosition = m_DataTable.Rows.Count - 1
        Me.ShowCurrentRecord()

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        ' If there is data, delete the current row.
        If m_DataTable.Rows.Count <> 0 Then
            m_DataTable.Rows(m_rowPosition).Delete()
            m_DA.Update(m_DataTable)
            m_rowPosition = 0
            Me.ShowCurrentRecord()
        End If

    End Sub
End Class
