Imports System.Diagnostics
Imports System.IO
Imports System.Net
Imports System.Reflection.Emit
Imports System.Windows
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports DiscordRPC

Public Class Form1
    Private client As DiscordRpcClient

    Private Async Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        client = New DiscordRpcClient("1107929915946438736")

        AddHandler client.OnReady, Sub(s, ev)
                                       Console.WriteLine("Connected as " & ev.User.Username)
                                   End Sub

        client.Initialize()

        client.SetPresence(New RichPresence() With {
        .Details = "In The Launcher",
        .State = "Ready to play!",
        .Assets = New Assets() With {
            .LargeImageKey = "launcher_logo",
            .LargeImageText = "2.1 GDPS",
            .SmallImageKey = "status_idle"
        },
        .Timestamps = Timestamps.Now
    })
        Form2.CheckBox4.Checked = My.Settings.challengelist
        Form2.CheckBox1.Checked = My.Settings.geode
        Form2.CheckBox2.Checked = My.Settings.quitlauncher
        Form2.CheckBox3.Checked = My.Settings.autoupdate
        Form2.CheckBox5.Checked = My.Settings.autostart
        If My.Settings.autoupdate Then
            If My.Settings.autoupdate Then
                Dim RootFS = AppDomain.CurrentDomain.BaseDirectory
                Dim OutputFileName As String = "setup.exe"
                ServicePointManager.SecurityProtocol = DirectCast(3072, SecurityProtocolType)
                Dim updaterchk As New WebClient
                Dim taskme As Task(Of String) = Task.Run(Async Function() Await updaterchk.DownloadStringTaskAsync("https://two1gdps.ps.fhgdps.com/update.txt"))
                Dim result As String = Await taskme
                Dim ver As String = Application.ProductVersion

                If ver <> result Then
                    Dim x = MsgBox("Update is available! Install it?", vbYesNo + vbInformation, "Auto Updater")
                    If x = vbNo Then
                        Return
                    End If
                    Label3.Text = ("Installing new version...")
                    Dim url As String = "https://github.com/JaharvisXD/2.1-GDPS/releases/latest/download/2.1.GDPS.Installer.exe"
                    If File.Exists(Path.Combine(RootFS, OutputFileName)) Then
                        File.Delete(Path.Combine(RootFS, OutputFileName))
                    End If
                    Dim wc As New WebClient
                    Await wc.DownloadFileTaskAsync(New Uri(url), Path.Combine(RootFS, OutputFileName))
                    Dim Setup As New ProcessStartInfo()
                    Setup.FileName = Path.Combine(RootFS, OutputFileName)
                    Setup.Arguments = "/passive"
                    Dim Exec As New Process()
                    Exec.StartInfo = Setup
                    Exec.Start()
                    Application.Exit()
                End If
            End If
        End If
        If My.Settings.autostart Then
            Process.Start("2.1 GDPS.exe")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If My.Settings.geode Then
            Process.Start("GeodeLoader\2.1 GDPS.exe")
        Else
            Process.Start("2.1 GDPS.exe")
        End If
        If My.Settings.quitlauncher Then
            Application.Exit()
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Process.Start(New ProcessStartInfo("https://discord.gg/N8MX2mZKCF") With {.UseShellExecute = True})
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Process.Start(New ProcessStartInfo("https://www.youtube.com/@2p1GDPS/") With {.UseShellExecute = True})
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Process.Start(New ProcessStartInfo("https://github.com/JaharvisXD/2.1-GDPS") With {.UseShellExecute = True})
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If My.Settings.challengelist Then
            Process.Start(New ProcessStartInfo("https://two1gdpscl.page.gd") With {.UseShellExecute = True})
        Else
            Process.Start(New ProcessStartInfo("https://two1gdpsdl.page.gd") With {.UseShellExecute = True})
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Process.Start(New ProcessStartInfo("https://two1gdps.ps.fhgdps.com/dashboard") With {.UseShellExecute = True})
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Process.Start(New ProcessStartInfo("https://gdpshub.com/gdps/1898") With {.UseShellExecute = True})
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form2.Show()
    End Sub

    Private Async Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim RootFS = AppDomain.CurrentDomain.BaseDirectory
        Dim OutputFileName As String = "setup.exe"
        ServicePointManager.SecurityProtocol = DirectCast(3072, SecurityProtocolType)
        Dim updaterchk As New WebClient
        Dim taskme As Task(Of String) = Task.Run(Async Function() Await updaterchk.DownloadStringTaskAsync("https://two1gdps.ps.fhgdps.com/update.txt"))
        Dim result As String = Await taskme
        Dim ver As String = Application.ProductVersion

        If ver <> result Then
            Dim x = MsgBox("Update is available! Install it?", vbYesNo + vbInformation, "Auto Updater")
            If x = vbNo Then
                Return
            End If
            Label3.Text = ("Installing new version...")
            Dim url As String = "https://github.com/JaharvisXD/2.1-GDPS/releases/latest/download/2.1.GDPS.Installer.exe"
            If File.Exists(Path.Combine(RootFS, OutputFileName)) Then
                File.Delete(Path.Combine(RootFS, OutputFileName))
            End If
            Dim wc As New WebClient
            Await wc.DownloadFileTaskAsync(New Uri(url), Path.Combine(RootFS, OutputFileName))
            Dim Setup As New ProcessStartInfo()
            Setup.FileName = Path.Combine(RootFS, OutputFileName)
            Setup.Arguments = "/passive"
            Dim Exec As New Process()
            Exec.StartInfo = Setup
            Exec.Start()
            Application.Exit()
        Else
            Dim x = MsgBox("There is no update today! :)", vbOKOnly + vbInformation, "Auto Updater")
        End If
    End Sub

End Class
