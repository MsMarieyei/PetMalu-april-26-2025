Public Class DashboardPage

    Dim connectionString As String = "Server=localhost;Database=petmalu_reco;User ID=root;Password=;"

    Private Sub DashboardPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LinkLogout_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLogout.LinkClicked
        Dim result As DialogResult = MessageBox.Show("Do you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.No Then
            Return
        End If

        Dim LoginPage As New LoginPage()
        LoginPage.Show()
        Me.Close()
    End Sub

    Private Sub LinkScan_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkScan.LinkClicked
        Dim ScanPage As New ScanPage()
        ScanPage.Show()
        Me.Hide()
    End Sub

    Private Sub LinkClients_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkClients.LinkClicked
        Dim ClientPage As New ClientPage()
        ClientPage.Show()
        Me.Hide()
    End Sub

    Private Sub LinkPetInfo_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkPetInfo.LinkClicked
        Dim OwnerRegistrationPage As New OwnerRegistrationPage()
        OwnerRegistrationPage.Show()
        Me.Hide()
    End Sub
    Private Sub BtnHistory_Click(sender As Object, e As EventArgs) Handles BtnHistory.Click
        Dim History As New HistoryPage()
        History.Show()
        Me.Hide()
    End Sub
End Class
