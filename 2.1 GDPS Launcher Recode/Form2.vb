Imports System.IO

Public Class Form2

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            Form1.Button6.Text = ("Challenge List")
            My.Settings.challengelist = CheckBox1.Checked
            My.Settings.Save()
        End If
        If Not CheckBox1.Checked Then
            Form1.Button6.Text = ("Demon List")
            My.Settings.challengelist = CheckBox1.Checked
            My.Settings.Save()
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            Label1.Text = ("Currently using: Geode")
            My.Settings.geode = CheckBox1.Checked
            My.Settings.Save()
        Else
            Label1.Text = ("Currently using: QuickLDR")
            My.Settings.geode = CheckBox1.Checked
            My.Settings.Save()
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked Then
            My.Settings.quitlauncher = CheckBox2.Checked
            My.Settings.Save()
        Else
            My.Settings.quitlauncher = CheckBox2.Checked
            My.Settings.Save()
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked Then
            My.Settings.autoupdate = CheckBox3.Checked
            My.Settings.Save()
        Else
            My.Settings.autoupdate = CheckBox3.Checked
            My.Settings.Save()
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked Then
            My.Settings.autostart = CheckBox5.Checked
            My.Settings.Save()
        Else
            My.Settings.autostart = CheckBox5.Checked
            My.Settings.Save()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim appData As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
        Dim myAppFolder As String = Path.Combine(appData, "2.1 GDPS")
        Process.Start("explorer.exe", myAppFolder)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Process.Start(New ProcessStartInfo("https://ko-fi.com/2p1gdps") With {.UseShellExecute = True})
    End Sub
End Class