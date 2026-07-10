<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        Label1 = New Label()
        CheckBox5 = New CheckBox()
        CheckBox4 = New CheckBox()
        CheckBox3 = New CheckBox()
        CheckBox2 = New CheckBox()
        CheckBox1 = New CheckBox()
        Button2 = New Button()
        Button1 = New Button()
        TabPage2 = New TabPage()
        Label3 = New Label()
        Label2 = New Label()
        TabPage3 = New TabPage()
        Label4 = New Label()
        TabPage4 = New TabPage()
        Label5 = New Label()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        TabPage3.SuspendLayout()
        TabPage4.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.AccessibleRole = AccessibleRole.None
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Controls.Add(TabPage4)
        TabControl1.ImeMode = ImeMode.NoControl
        TabControl1.Location = New Point(-1, 1)
        TabControl1.Multiline = True
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(370, 448)
        TabControl1.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(Label1)
        TabPage1.Controls.Add(CheckBox5)
        TabPage1.Controls.Add(CheckBox4)
        TabPage1.Controls.Add(CheckBox3)
        TabPage1.Controls.Add(CheckBox2)
        TabPage1.Controls.Add(CheckBox1)
        TabPage1.Controls.Add(Button2)
        TabPage1.Controls.Add(Button1)
        TabPage1.Location = New Point(4, 22)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(362, 422)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Settings"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(3, 406)
        Label1.Name = "Label1"
        Label1.Size = New Size(132, 13)
        Label1.TabIndex = 27
        Label1.Text = "Currently using: QuickLDR"
        ' 
        ' CheckBox5
        ' 
        CheckBox5.AutoSize = True
        CheckBox5.Location = New Point(3, 74)
        CheckBox5.Name = "CheckBox5"
        CheckBox5.Size = New Size(261, 17)
        CheckBox5.TabIndex = 26
        CheckBox5.Text = "Start GDPS on Launch (Incompatible with Geode)"
        CheckBox5.UseVisualStyleBackColor = True
        ' 
        ' CheckBox4
        ' 
        CheckBox4.AutoSize = True
        CheckBox4.Location = New Point(3, 57)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(143, 17)
        CheckBox4.TabIndex = 5
        CheckBox4.Text = "Auto Check For Updates"
        CheckBox4.UseVisualStyleBackColor = True
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Location = New Point(3, 40)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(116, 17)
        CheckBox3.TabIndex = 4
        CheckBox3.Text = "Close After Launch"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(3, 23)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(116, 17)
        CheckBox2.TabIndex = 3
        CheckBox2.Text = "Use Geode Loader"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(3, 6)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(128, 17)
        CheckBox1.TabIndex = 2
        CheckBox1.Text = "Enable Challenge List"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(251, 371)
        Button2.Name = "Button2"
        Button2.Size = New Size(108, 23)
        Button2.TabIndex = 1
        Button2.Text = "Support Us!"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(251, 396)
        Button1.Name = "Button1"
        Button1.Size = New Size(108, 23)
        Button1.TabIndex = 0
        Button1.Text = "Browse GDPS Files"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TabPage2
        ' 
        TabPage2.AccessibleRole = AccessibleRole.OutlineButton
        TabPage2.AutoScroll = True
        TabPage2.Controls.Add(Label3)
        TabPage2.Controls.Add(Label2)
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(362, 420)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Changelogs"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(3, 3)
        Label3.Name = "Label3"
        Label3.Size = New Size(340, 1820)
        Label3.TabIndex = 1
        Label3.Text = resources.GetString("Label3.Text")
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(3, 3)
        Label2.Name = "Label2"
        Label2.Size = New Size(7, 13)
        Label2.TabIndex = 0
        Label2.Text = vbCrLf
        ' 
        ' TabPage3
        ' 
        TabPage3.AutoScroll = True
        TabPage3.Controls.Add(Label4)
        TabPage3.Location = New Point(4, 24)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(362, 420)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Frequently Asked Questions"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(3, 3)
        Label4.Name = "Label4"
        Label4.Size = New Size(327, 455)
        Label4.TabIndex = 0
        Label4.Text = resources.GetString("Label4.Text")
        ' 
        ' TabPage4
        ' 
        TabPage4.Controls.Add(Label5)
        TabPage4.Location = New Point(4, 24)
        TabPage4.Name = "TabPage4"
        TabPage4.Padding = New Padding(3)
        TabPage4.Size = New Size(362, 420)
        TabPage4.TabIndex = 3
        TabPage4.Text = "Credits"
        TabPage4.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(3, 2)
        Label5.Name = "Label5"
        Label5.Size = New Size(354, 416)
        Label5.TabIndex = 0
        Label5.Text = resources.GetString("Label5.Text")
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(6F, 13F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(368, 450)
        Controls.Add(TabControl1)
        Font = New Font("Microsoft Sans Serif", 8.25F)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Settings"
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        TabPage3.ResumeLayout(False)
        TabPage3.PerformLayout()
        TabPage4.ResumeLayout(False)
        TabPage4.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
