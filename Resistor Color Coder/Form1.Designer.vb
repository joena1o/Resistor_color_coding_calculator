<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Multiplier = New System.Windows.Forms.ComboBox()
        Me.Tolerance = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tlr_lbl = New System.Windows.Forms.Label()
        Me.Compute = New System.Windows.Forms.Button()
        Me.Nominal = New System.Windows.Forms.Label()
        Me.Actual = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FourColorBandToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FiveColorBandToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreferenceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BgColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GreenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaroonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mul_lbl = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.colorcode1 = New System.Windows.Forms.PictureBox()
        Me.colorcode2 = New System.Windows.Forms.PictureBox()
        Me.colorcode3 = New System.Windows.Forms.PictureBox()
        Me.colorcode4 = New System.Windows.Forms.PictureBox()
        Me.First = New System.Windows.Forms.ComboBox()
        Me.Second = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.trd_color = New System.Windows.Forms.Label()
        Me.trd_colorBox = New System.Windows.Forms.ComboBox()
        Me.color5 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colorcode1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colorcode2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colorcode3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colorcode4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.color5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Multiplier
        '
        Me.Multiplier.FormattingEnabled = True
        Me.Multiplier.Items.AddRange(New Object() {"Black", "Brown", "Red", "Orange", "Yellow", "Green", "Blue", "Violet", "Gray", "White", "Gold", "Silver", "No Color"})
        Me.Multiplier.Location = New System.Drawing.Point(279, 369)
        Me.Multiplier.Name = "Multiplier"
        Me.Multiplier.Size = New System.Drawing.Size(136, 21)
        Me.Multiplier.TabIndex = 4
        '
        'Tolerance
        '
        Me.Tolerance.FormattingEnabled = True
        Me.Tolerance.Items.AddRange(New Object() {"Gold", "Silver", "Red", "Brown"})
        Me.Tolerance.Location = New System.Drawing.Point(279, 396)
        Me.Tolerance.Name = "Tolerance"
        Me.Tolerance.Size = New System.Drawing.Size(136, 21)
        Me.Tolerance.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(126, 367)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Multiplier"
        '
        'tlr_lbl
        '
        Me.tlr_lbl.AutoSize = True
        Me.tlr_lbl.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.tlr_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tlr_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.tlr_lbl.Location = New System.Drawing.Point(126, 396)
        Me.tlr_lbl.Name = "tlr_lbl"
        Me.tlr_lbl.Size = New System.Drawing.Size(79, 20)
        Me.tlr_lbl.TabIndex = 5
        Me.tlr_lbl.Text = "Tolerance"
        '
        'Compute
        '
        Me.Compute.BackColor = System.Drawing.Color.AliceBlue
        Me.Compute.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Compute.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Compute.Location = New System.Drawing.Point(130, 432)
        Me.Compute.Name = "Compute"
        Me.Compute.Size = New System.Drawing.Size(288, 39)
        Me.Compute.TabIndex = 6
        Me.Compute.Text = "Compute"
        Me.Compute.UseVisualStyleBackColor = False
        '
        'Nominal
        '
        Me.Nominal.AutoSize = True
        Me.Nominal.BackColor = System.Drawing.SystemColors.Desktop
        Me.Nominal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nominal.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Nominal.Location = New System.Drawing.Point(38, 76)
        Me.Nominal.Name = "Nominal"
        Me.Nominal.Size = New System.Drawing.Size(144, 24)
        Me.Nominal.TabIndex = 8
        Me.Nominal.Text = "Nominal Value: "
        '
        'Actual
        '
        Me.Actual.AutoSize = True
        Me.Actual.BackColor = System.Drawing.SystemColors.Desktop
        Me.Actual.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Actual.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Actual.Location = New System.Drawing.Point(38, 39)
        Me.Actual.Name = "Actual"
        Me.Actual.Size = New System.Drawing.Size(121, 24)
        Me.Actual.TabIndex = 9
        Me.Actual.Text = "Actual Value:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Honeydew
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModeToolStripMenuItem, Me.PreferenceToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(616, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ModeToolStripMenuItem
        '
        Me.ModeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FourColorBandToolStripMenuItem, Me.FiveColorBandToolStripMenuItem})
        Me.ModeToolStripMenuItem.Name = "ModeToolStripMenuItem"
        Me.ModeToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.ModeToolStripMenuItem.Text = "Mode"
        '
        'FourColorBandToolStripMenuItem
        '
        Me.FourColorBandToolStripMenuItem.Name = "FourColorBandToolStripMenuItem"
        Me.FourColorBandToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.FourColorBandToolStripMenuItem.Text = "Four Color Band"
        '
        'FiveColorBandToolStripMenuItem
        '
        Me.FiveColorBandToolStripMenuItem.Name = "FiveColorBandToolStripMenuItem"
        Me.FiveColorBandToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.FiveColorBandToolStripMenuItem.Text = "Five Color Band"
        '
        'PreferenceToolStripMenuItem
        '
        Me.PreferenceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BgColorToolStripMenuItem})
        Me.PreferenceToolStripMenuItem.Name = "PreferenceToolStripMenuItem"
        Me.PreferenceToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.PreferenceToolStripMenuItem.Text = "Preference"
        '
        'BgColorToolStripMenuItem
        '
        Me.BgColorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RedToolStripMenuItem, Me.BlueToolStripMenuItem, Me.GreenToolStripMenuItem, Me.MaroonToolStripMenuItem})
        Me.BgColorToolStripMenuItem.Name = "BgColorToolStripMenuItem"
        Me.BgColorToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BgColorToolStripMenuItem.Text = "Bg Color"
        '
        'RedToolStripMenuItem
        '
        Me.RedToolStripMenuItem.Name = "RedToolStripMenuItem"
        Me.RedToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.RedToolStripMenuItem.Text = "Red"
        '
        'BlueToolStripMenuItem
        '
        Me.BlueToolStripMenuItem.Name = "BlueToolStripMenuItem"
        Me.BlueToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BlueToolStripMenuItem.Text = "Blue"
        '
        'GreenToolStripMenuItem
        '
        Me.GreenToolStripMenuItem.Name = "GreenToolStripMenuItem"
        Me.GreenToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.GreenToolStripMenuItem.Text = "Green"
        '
        'MaroonToolStripMenuItem
        '
        Me.MaroonToolStripMenuItem.Name = "MaroonToolStripMenuItem"
        Me.MaroonToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MaroonToolStripMenuItem.Text = "Maroon"
        '
        'Mul_lbl
        '
        Me.Mul_lbl.AutoSize = True
        Me.Mul_lbl.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Mul_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mul_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Mul_lbl.Location = New System.Drawing.Point(126, 370)
        Me.Mul_lbl.Name = "Mul_lbl"
        Me.Mul_lbl.Size = New System.Drawing.Size(71, 20)
        Me.Mul_lbl.TabIndex = 5
        Me.Mul_lbl.Text = "Multiplier"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Resistor_Color_Coder.My.Resources.Resources.resistor3
        Me.PictureBox1.Location = New System.Drawing.Point(42, 137)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(525, 118)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'colorcode1
        '
        Me.colorcode1.Location = New System.Drawing.Point(233, 138)
        Me.colorcode1.Name = "colorcode1"
        Me.colorcode1.Size = New System.Drawing.Size(13, 118)
        Me.colorcode1.TabIndex = 3
        Me.colorcode1.TabStop = False
        '
        'colorcode2
        '
        Me.colorcode2.Location = New System.Drawing.Point(268, 137)
        Me.colorcode2.Name = "colorcode2"
        Me.colorcode2.Size = New System.Drawing.Size(13, 118)
        Me.colorcode2.TabIndex = 3
        Me.colorcode2.TabStop = False
        '
        'colorcode3
        '
        Me.colorcode3.Location = New System.Drawing.Point(339, 137)
        Me.colorcode3.Name = "colorcode3"
        Me.colorcode3.Size = New System.Drawing.Size(13, 118)
        Me.colorcode3.TabIndex = 3
        Me.colorcode3.TabStop = False
        '
        'colorcode4
        '
        Me.colorcode4.Location = New System.Drawing.Point(370, 137)
        Me.colorcode4.Name = "colorcode4"
        Me.colorcode4.Size = New System.Drawing.Size(13, 118)
        Me.colorcode4.TabIndex = 3
        Me.colorcode4.TabStop = False
        '
        'First
        '
        Me.First.FormattingEnabled = True
        Me.First.Items.AddRange(New Object() {"Black", "Brown", "Red", "Orange", "Yellow", "Green", "Blue", "Violet", "Gray", "White", "Gold", "Silver", "No Color"})
        Me.First.Location = New System.Drawing.Point(279, 286)
        Me.First.Name = "First"
        Me.First.Size = New System.Drawing.Size(136, 21)
        Me.First.TabIndex = 4
        '
        'Second
        '
        Me.Second.FormattingEnabled = True
        Me.Second.Items.AddRange(New Object() {"Black", "Brown", "Red", "Orange", "Yellow", "Green", "Blue", "Violet", "Gray", "White", "Gold", "Silver", "No Color"})
        Me.Second.Location = New System.Drawing.Point(279, 313)
        Me.Second.Name = "Second"
        Me.Second.Size = New System.Drawing.Size(136, 21)
        Me.Second.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(126, 286)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "First Color Band"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(126, 313)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Second Color Band"
        '
        'trd_color
        '
        Me.trd_color.AutoSize = True
        Me.trd_color.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.trd_color.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.trd_color.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.trd_color.Location = New System.Drawing.Point(126, 341)
        Me.trd_color.Name = "trd_color"
        Me.trd_color.Size = New System.Drawing.Size(127, 20)
        Me.trd_color.TabIndex = 5
        Me.trd_color.Text = "Third Color Band"
        '
        'trd_colorBox
        '
        Me.trd_colorBox.FormattingEnabled = True
        Me.trd_colorBox.Items.AddRange(New Object() {"Black", "Brown", "Red", "Orange", "Yellow", "Green", "Blue", "Violet", "Gray", "White", "Gold", "Silver", "No Color"})
        Me.trd_colorBox.Location = New System.Drawing.Point(279, 340)
        Me.trd_colorBox.Name = "trd_colorBox"
        Me.trd_colorBox.Size = New System.Drawing.Size(137, 21)
        Me.trd_colorBox.TabIndex = 11
        '
        'color5
        '
        Me.color5.Location = New System.Drawing.Point(293, 137)
        Me.color5.Name = "color5"
        Me.color5.Size = New System.Drawing.Size(13, 118)
        Me.color5.TabIndex = 12
        Me.color5.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(616, 511)
        Me.Controls.Add(Me.color5)
        Me.Controls.Add(Me.trd_colorBox)
        Me.Controls.Add(Me.Actual)
        Me.Controls.Add(Me.Nominal)
        Me.Controls.Add(Me.Compute)
        Me.Controls.Add(Me.tlr_lbl)
        Me.Controls.Add(Me.trd_color)
        Me.Controls.Add(Me.Mul_lbl)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Tolerance)
        Me.Controls.Add(Me.Multiplier)
        Me.Controls.Add(Me.Second)
        Me.Controls.Add(Me.First)
        Me.Controls.Add(Me.colorcode4)
        Me.Controls.Add(Me.colorcode3)
        Me.Controls.Add(Me.colorcode2)
        Me.Controls.Add(Me.colorcode1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Resistor Color Coder"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colorcode1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colorcode2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colorcode3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colorcode4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.color5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Multiplier As System.Windows.Forms.ComboBox
    Friend WithEvents Tolerance As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tlr_lbl As System.Windows.Forms.Label
    Friend WithEvents Compute As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Nominal As System.Windows.Forms.Label
    Friend WithEvents Actual As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ModeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FourColorBandToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FiveColorBandToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Mul_lbl As System.Windows.Forms.Label
    Friend WithEvents PreferenceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BgColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BlueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GreenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MaroonToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents colorcode1 As System.Windows.Forms.PictureBox
    Friend WithEvents colorcode2 As System.Windows.Forms.PictureBox
    Friend WithEvents colorcode3 As System.Windows.Forms.PictureBox
    Friend WithEvents colorcode4 As System.Windows.Forms.PictureBox
    Friend WithEvents First As System.Windows.Forms.ComboBox
    Friend WithEvents Second As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents trd_color As System.Windows.Forms.Label
    Friend WithEvents trd_colorBox As System.Windows.Forms.ComboBox
    Friend WithEvents color5 As System.Windows.Forms.PictureBox

End Class
