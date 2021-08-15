<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btncalc = New System.Windows.Forms.Button()
        Me.txtmtr = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.btnew = New System.Windows.Forms.Button()
        Me.txtkm = New System.Windows.Forms.TextBox()
        Me.txthm = New System.Windows.Forms.TextBox()
        Me.txtdm = New System.Windows.Forms.TextBox()
        Me.txtdcm = New System.Windows.Forms.TextBox()
        Me.txtcm = New System.Windows.Forms.TextBox()
        Me.txtml = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(142, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Convertidor de medidas"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btncalc)
        Me.GroupBox1.Controls.Add(Me.txtmtr)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(33, 75)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(376, 84)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Entrada"
        '
        'btncalc
        '
        Me.btncalc.BackColor = System.Drawing.Color.Goldenrod
        Me.btncalc.Cursor = System.Windows.Forms.Cursors.Default
        Me.btncalc.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btncalc.ForeColor = System.Drawing.SystemColors.Window
        Me.btncalc.Location = New System.Drawing.Point(295, 38)
        Me.btncalc.Name = "btncalc"
        Me.btncalc.Size = New System.Drawing.Size(75, 23)
        Me.btncalc.TabIndex = 2
        Me.btncalc.Text = "Calcular"
        Me.btncalc.UseVisualStyleBackColor = False
        '
        'txtmtr
        '
        Me.txtmtr.Location = New System.Drawing.Point(112, 38)
        Me.txtmtr.Name = "txtmtr"
        Me.txtmtr.Size = New System.Drawing.Size(171, 20)
        Me.txtmtr.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Metros"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnexit)
        Me.GroupBox2.Controls.Add(Me.btnew)
        Me.GroupBox2.Controls.Add(Me.txtkm)
        Me.GroupBox2.Controls.Add(Me.txthm)
        Me.GroupBox2.Controls.Add(Me.txtdm)
        Me.GroupBox2.Controls.Add(Me.txtdcm)
        Me.GroupBox2.Controls.Add(Me.txtcm)
        Me.GroupBox2.Controls.Add(Me.txtml)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(33, 188)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(376, 250)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Salida"
        '
        'btnexit
        '
        Me.btnexit.BackColor = System.Drawing.Color.Goldenrod
        Me.btnexit.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnexit.ForeColor = System.Drawing.Color.White
        Me.btnexit.Location = New System.Drawing.Point(199, 203)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(171, 32)
        Me.btnexit.TabIndex = 14
        Me.btnexit.Text = "Salir"
        Me.btnexit.UseVisualStyleBackColor = False
        '
        'btnew
        '
        Me.btnew.BackColor = System.Drawing.Color.Goldenrod
        Me.btnew.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnew.ForeColor = System.Drawing.Color.White
        Me.btnew.Location = New System.Drawing.Point(6, 203)
        Me.btnew.Name = "btnew"
        Me.btnew.Size = New System.Drawing.Size(171, 32)
        Me.btnew.TabIndex = 3
        Me.btnew.Text = "Nuevo"
        Me.btnew.UseVisualStyleBackColor = False
        '
        'txtkm
        '
        Me.txtkm.Location = New System.Drawing.Point(112, 166)
        Me.txtkm.Name = "txtkm"
        Me.txtkm.Size = New System.Drawing.Size(171, 20)
        Me.txtkm.TabIndex = 13
        '
        'txthm
        '
        Me.txthm.Location = New System.Drawing.Point(112, 140)
        Me.txthm.Name = "txthm"
        Me.txthm.Size = New System.Drawing.Size(171, 20)
        Me.txthm.TabIndex = 12
        '
        'txtdm
        '
        Me.txtdm.Location = New System.Drawing.Point(112, 114)
        Me.txtdm.Name = "txtdm"
        Me.txtdm.Size = New System.Drawing.Size(171, 20)
        Me.txtdm.TabIndex = 11
        '
        'txtdcm
        '
        Me.txtdcm.Location = New System.Drawing.Point(112, 88)
        Me.txtdcm.Name = "txtdcm"
        Me.txtdcm.Size = New System.Drawing.Size(171, 20)
        Me.txtdcm.TabIndex = 10
        '
        'txtcm
        '
        Me.txtcm.Location = New System.Drawing.Point(112, 62)
        Me.txtcm.Name = "txtcm"
        Me.txtcm.Size = New System.Drawing.Size(171, 20)
        Me.txtcm.TabIndex = 9
        '
        'txtml
        '
        Me.txtml.Location = New System.Drawing.Point(112, 36)
        Me.txtml.Name = "txtml"
        Me.txtml.Size = New System.Drawing.Size(171, 20)
        Me.txtml.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(23, 173)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Kilometros"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(23, 147)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Hectometros"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 121)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Decametros"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 95)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Decimetros"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Centimetros"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Milimetros"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.calculadoradeber.My.Resources.Resources.gobernantes
        Me.PictureBox1.Location = New System.Drawing.Point(322, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(36, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me
        Me.BunifuDragControl1.Vertical = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(442, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Convertidor de medidas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btncalc As Button
    Friend WithEvents txtmtr As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtkm As TextBox
    Friend WithEvents txthm As TextBox
    Friend WithEvents txtdm As TextBox
    Friend WithEvents txtdcm As TextBox
    Friend WithEvents txtcm As TextBox
    Friend WithEvents txtml As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnexit As Button
    Friend WithEvents btnew As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
End Class
