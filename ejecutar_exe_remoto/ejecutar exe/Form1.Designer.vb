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
        Me.ip = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.port = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.user = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pass = New System.Windows.Forms.TextBox()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.path = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cia = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tpv = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.conn = New System.Windows.Forms.TextBox()
        Me.status = New System.Windows.Forms.RichTextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.comando = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ip
        '
        Me.ip.Location = New System.Drawing.Point(37, 57)
        Me.ip.Name = "ip"
        Me.ip.Size = New System.Drawing.Size(141, 20)
        Me.ip.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "IP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(205, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "PORT"
        '
        'port
        '
        Me.port.Location = New System.Drawing.Point(248, 60)
        Me.port.Name = "port"
        Me.port.Size = New System.Drawing.Size(141, 20)
        Me.port.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(412, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "USER"
        '
        'user
        '
        Me.user.Location = New System.Drawing.Point(455, 60)
        Me.user.Name = "user"
        Me.user.Size = New System.Drawing.Size(141, 20)
        Me.user.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(605, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "PASS"
        '
        'pass
        '
        Me.pass.Location = New System.Drawing.Point(646, 60)
        Me.pass.Name = "pass"
        Me.pass.Size = New System.Drawing.Size(141, 20)
        Me.pass.TabIndex = 18
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(51, 225)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(690, 23)
        Me.btnConnect.TabIndex = 20
        Me.btnConnect.Text = "Iniciar POS"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Ruta SiesaPOS"
        '
        'path
        '
        Me.path.Location = New System.Drawing.Point(112, 116)
        Me.path.Name = "path"
        Me.path.Size = New System.Drawing.Size(395, 20)
        Me.path.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Enabled = False
        Me.Label6.Location = New System.Drawing.Point(591, 159)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "CIA"
        Me.Label6.Visible = False
        '
        'cia
        '
        Me.cia.Enabled = False
        Me.cia.Location = New System.Drawing.Point(620, 156)
        Me.cia.Name = "cia"
        Me.cia.Size = New System.Drawing.Size(141, 20)
        Me.cia.TabIndex = 27
        Me.cia.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(547, 122)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 13)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Nombre archivo:"
        '
        'tpv
        '
        Me.tpv.Location = New System.Drawing.Point(647, 116)
        Me.tpv.Name = "tpv"
        Me.tpv.Size = New System.Drawing.Size(141, 20)
        Me.tpv.TabIndex = 25
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Enabled = False
        Me.Label8.Location = New System.Drawing.Point(58, 159)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 13)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Conexion"
        Me.Label8.Visible = False
        '
        'conn
        '
        Me.conn.Enabled = False
        Me.conn.Location = New System.Drawing.Point(133, 156)
        Me.conn.Name = "conn"
        Me.conn.Size = New System.Drawing.Size(141, 20)
        Me.conn.TabIndex = 23
        Me.conn.Visible = False
        '
        'status
        '
        Me.status.Location = New System.Drawing.Point(28, 285)
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(750, 118)
        Me.status.TabIndex = 29
        Me.status.Text = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(305, 159)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Comando"
        Me.Label9.Visible = False
        '
        'comando
        '
        Me.comando.Location = New System.Drawing.Point(392, 156)
        Me.comando.Name = "comando"
        Me.comando.Size = New System.Drawing.Size(141, 20)
        Me.comando.TabIndex = 30
        Me.comando.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.comando)
        Me.Controls.Add(Me.status)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cia)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tpv)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.conn)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.path)
        Me.Controls.Add(Me.btnConnect)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.pass)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.user)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.port)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ip)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ip As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents port As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents user As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents pass As TextBox
    Friend WithEvents btnConnect As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents path As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cia As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tpv As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents conn As TextBox
    Friend WithEvents status As RichTextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label9 As Label
    Friend WithEvents comando As TextBox
End Class
