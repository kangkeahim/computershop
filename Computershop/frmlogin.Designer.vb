<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmlogin
    Inherits MetroFramework.Forms.MetroForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmlogin))
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.txtusername = New MetroFramework.Controls.MetroTextBox()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.txtpassword = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.btnexit = New MetroFramework.Controls.MetroButton()
        Me.btnlogin = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(352, 147)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(98, 25)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Username :"
        '
        'txtusername
        '
        '
        '
        '
        Me.txtusername.CustomButton.Image = Nothing
        Me.txtusername.CustomButton.Location = New System.Drawing.Point(180, 2)
        Me.txtusername.CustomButton.Name = ""
        Me.txtusername.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtusername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtusername.CustomButton.TabIndex = 1
        Me.txtusername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtusername.CustomButton.UseSelectable = True
        Me.txtusername.CustomButton.Visible = False
        Me.txtusername.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtusername.Lines = New String(-1) {}
        Me.txtusername.Location = New System.Drawing.Point(477, 147)
        Me.txtusername.MaxLength = 32767
        Me.txtusername.Name = "txtusername"
        Me.txtusername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtusername.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtusername.SelectedText = ""
        Me.txtusername.SelectionLength = 0
        Me.txtusername.SelectionStart = 0
        Me.txtusername.Size = New System.Drawing.Size(208, 30)
        Me.txtusername.TabIndex = 1
        Me.txtusername.UseSelectable = True
        Me.txtusername.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtusername.WaterMarkFont = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroPanel1
        '
        Me.MetroPanel1.BackgroundImage = CType(resources.GetObject("MetroPanel1.BackgroundImage"), System.Drawing.Image)
        Me.MetroPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(25, 73)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(300, 300)
        Me.MetroPanel1.TabIndex = 2
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'txtpassword
        '
        '
        '
        '
        Me.txtpassword.CustomButton.Image = Nothing
        Me.txtpassword.CustomButton.Location = New System.Drawing.Point(180, 2)
        Me.txtpassword.CustomButton.Name = ""
        Me.txtpassword.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtpassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtpassword.CustomButton.TabIndex = 1
        Me.txtpassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtpassword.CustomButton.UseSelectable = True
        Me.txtpassword.CustomButton.Visible = False
        Me.txtpassword.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtpassword.Lines = New String(-1) {}
        Me.txtpassword.Location = New System.Drawing.Point(477, 194)
        Me.txtpassword.MaxLength = 32767
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtpassword.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtpassword.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtpassword.SelectedText = ""
        Me.txtpassword.SelectionLength = 0
        Me.txtpassword.SelectionStart = 0
        Me.txtpassword.Size = New System.Drawing.Size(208, 30)
        Me.txtpassword.TabIndex = 4
        Me.txtpassword.UseSelectable = True
        Me.txtpassword.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtpassword.WaterMarkFont = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel2.Location = New System.Drawing.Point(352, 194)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(91, 25)
        Me.MetroLabel2.TabIndex = 3
        Me.MetroLabel2.Text = "Password :"
        '
        'btnexit
        '
        Me.btnexit.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnexit.FontWeight = MetroFramework.MetroButtonWeight.Light
        Me.btnexit.Location = New System.Drawing.Point(610, 240)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(75, 30)
        Me.btnexit.TabIndex = 5
        Me.btnexit.Text = "E&xit"
        Me.btnexit.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnexit.UseSelectable = True
        '
        'btnlogin
        '
        Me.btnlogin.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnlogin.FontWeight = MetroFramework.MetroButtonWeight.Light
        Me.btnlogin.Location = New System.Drawing.Point(529, 240)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(75, 30)
        Me.btnlogin.TabIndex = 6
        Me.btnlogin.Text = "&Login"
        Me.btnlogin.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnlogin.UseSelectable = True
        '
        'frmlogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(708, 396)
        Me.Controls.Add(Me.btnlogin)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroPanel1)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.MaximizeBox = False
        Me.Name = "frmlogin"
        Me.Padding = New System.Windows.Forms.Padding(33, 83, 33, 28)
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Green
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtusername As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents txtpassword As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnexit As MetroFramework.Controls.MetroButton
    Friend WithEvents btnlogin As MetroFramework.Controls.MetroButton

End Class
