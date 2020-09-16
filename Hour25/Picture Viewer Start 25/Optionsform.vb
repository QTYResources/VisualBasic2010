Public Class Optionsform

    Const c_strKeyName As String = "HKEY_CURRENT_USER\Software\CleverSoftware\PictureViewer\"

    Private Sub Optionsform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ViewerForm.Icon

        txtUserName.Text = CStr(My.Computer.Registry.GetValue _
                (c_strKeyName, "UserName", ""))

        chkPromptOnExit.Checked = CBool(My.Computer.Registry.GetValue _
              (c_strKeyName, "PromptOnExit", "0"))

        If CStr(My.Computer.Registry.GetValue _
                (c_strKeyName, "BackColor", "Gray")) = "Gray" Then
            optBackgroundDefault.Checked = True
        Else
            optBackgroundWhite.Checked = True
        End If

    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        My.Computer.Registry.SetValue _
                (c_strKeyName, "UserName", txtUserName.Text)

        My.Computer.Registry.SetValue _
                (c_strKeyName, "PromptOnExit", chkPromptOnExit.Checked)

        If optBackgroundDefault.Checked Then
            My.Computer.Registry.SetValue _
                    (c_strKeyName, "BackColor", "Gray")
        Else
            My.Computer.Registry.SetValue _
                    (c_strKeyName, "BackColor", "White")
        End If

        ViewerForm.LoadDefaults()

        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class