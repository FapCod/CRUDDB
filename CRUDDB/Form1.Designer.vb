<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CRUDDB
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
        Me.panelIzquierda = New System.Windows.Forms.Panel()
        Me.panelPuntero = New System.Windows.Forms.Panel()
        Me.picMaximizar = New System.Windows.Forms.PictureBox()
        Me.picMinimizar = New System.Windows.Forms.PictureBox()
        Me.picCerrar = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnELIMINAR = New System.Windows.Forms.Button()
        Me.btnBUSCAR = New System.Windows.Forms.Button()
        Me.btnEDITAR = New System.Windows.Forms.Button()
        Me.btnAGREGAR = New System.Windows.Forms.Button()
        Me.panelArriba = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.txtNOMBRE = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtGRADO = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.panelIzquierda.SuspendLayout()
        CType(Me.picMaximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelIzquierda
        '
        Me.panelIzquierda.BackColor = System.Drawing.Color.Crimson
        Me.panelIzquierda.Controls.Add(Me.panelPuntero)
        Me.panelIzquierda.Controls.Add(Me.picMaximizar)
        Me.panelIzquierda.Controls.Add(Me.picMinimizar)
        Me.panelIzquierda.Controls.Add(Me.picCerrar)
        Me.panelIzquierda.Controls.Add(Me.Label1)
        Me.panelIzquierda.Controls.Add(Me.btnELIMINAR)
        Me.panelIzquierda.Controls.Add(Me.btnBUSCAR)
        Me.panelIzquierda.Controls.Add(Me.btnEDITAR)
        Me.panelIzquierda.Controls.Add(Me.btnAGREGAR)
        Me.panelIzquierda.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelIzquierda.Location = New System.Drawing.Point(0, 0)
        Me.panelIzquierda.Name = "panelIzquierda"
        Me.panelIzquierda.Size = New System.Drawing.Size(200, 395)
        Me.panelIzquierda.TabIndex = 0
        '
        'panelPuntero
        '
        Me.panelPuntero.BackColor = System.Drawing.Color.Orange
        Me.panelPuntero.Location = New System.Drawing.Point(0, 93)
        Me.panelPuntero.Name = "panelPuntero"
        Me.panelPuntero.Size = New System.Drawing.Size(15, 52)
        Me.panelPuntero.TabIndex = 2
        '
        'picMaximizar
        '
        Me.picMaximizar.BackgroundImage = Global.CRUDDB.My.Resources.Resources.resize_vertical_24px
        Me.picMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picMaximizar.Location = New System.Drawing.Point(51, 3)
        Me.picMaximizar.Name = "picMaximizar"
        Me.picMaximizar.Size = New System.Drawing.Size(23, 23)
        Me.picMaximizar.TabIndex = 12
        Me.picMaximizar.TabStop = False
        '
        'picMinimizar
        '
        Me.picMinimizar.BackgroundImage = Global.CRUDDB.My.Resources.Resources.compress_24px
        Me.picMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picMinimizar.Location = New System.Drawing.Point(26, 3)
        Me.picMinimizar.Name = "picMinimizar"
        Me.picMinimizar.Size = New System.Drawing.Size(23, 23)
        Me.picMinimizar.TabIndex = 11
        Me.picMinimizar.TabStop = False
        '
        'picCerrar
        '
        Me.picCerrar.BackgroundImage = Global.CRUDDB.My.Resources.Resources.cancel_2_24px
        Me.picCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picCerrar.Location = New System.Drawing.Point(2, 3)
        Me.picCerrar.Name = "picCerrar"
        Me.picCerrar.Size = New System.Drawing.Size(23, 23)
        Me.picCerrar.TabIndex = 10
        Me.picCerrar.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(31, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 33)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "CRUDDB"
        '
        'btnELIMINAR
        '
        Me.btnELIMINAR.FlatAppearance.BorderSize = 0
        Me.btnELIMINAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnELIMINAR.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnELIMINAR.ForeColor = System.Drawing.SystemColors.Control
        Me.btnELIMINAR.Image = Global.CRUDDB.My.Resources.Resources.delete_48px
        Me.btnELIMINAR.Location = New System.Drawing.Point(0, 267)
        Me.btnELIMINAR.Name = "btnELIMINAR"
        Me.btnELIMINAR.Size = New System.Drawing.Size(200, 52)
        Me.btnELIMINAR.TabIndex = 7
        Me.btnELIMINAR.Text = "      Eliminar"
        Me.btnELIMINAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnELIMINAR.UseVisualStyleBackColor = True
        '
        'btnBUSCAR
        '
        Me.btnBUSCAR.FlatAppearance.BorderSize = 0
        Me.btnBUSCAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBUSCAR.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBUSCAR.ForeColor = System.Drawing.SystemColors.Control
        Me.btnBUSCAR.Image = Global.CRUDDB.My.Resources.Resources.find_user_48px
        Me.btnBUSCAR.Location = New System.Drawing.Point(0, 209)
        Me.btnBUSCAR.Name = "btnBUSCAR"
        Me.btnBUSCAR.Size = New System.Drawing.Size(200, 52)
        Me.btnBUSCAR.TabIndex = 5
        Me.btnBUSCAR.Text = "      Buscar"
        Me.btnBUSCAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBUSCAR.UseVisualStyleBackColor = True
        '
        'btnEDITAR
        '
        Me.btnEDITAR.FlatAppearance.BorderSize = 0
        Me.btnEDITAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEDITAR.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEDITAR.ForeColor = System.Drawing.SystemColors.Control
        Me.btnEDITAR.Image = Global.CRUDDB.My.Resources.Resources.edit_48px
        Me.btnEDITAR.Location = New System.Drawing.Point(0, 151)
        Me.btnEDITAR.Name = "btnEDITAR"
        Me.btnEDITAR.Size = New System.Drawing.Size(200, 52)
        Me.btnEDITAR.TabIndex = 3
        Me.btnEDITAR.Text = "      Editar"
        Me.btnEDITAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEDITAR.UseVisualStyleBackColor = True
        '
        'btnAGREGAR
        '
        Me.btnAGREGAR.FlatAppearance.BorderSize = 0
        Me.btnAGREGAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAGREGAR.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAGREGAR.ForeColor = System.Drawing.SystemColors.Control
        Me.btnAGREGAR.Image = Global.CRUDDB.My.Resources.Resources.add_user_48px
        Me.btnAGREGAR.Location = New System.Drawing.Point(0, 93)
        Me.btnAGREGAR.Name = "btnAGREGAR"
        Me.btnAGREGAR.Size = New System.Drawing.Size(200, 52)
        Me.btnAGREGAR.TabIndex = 0
        Me.btnAGREGAR.Text = "      Agregar"
        Me.btnAGREGAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAGREGAR.UseVisualStyleBackColor = True
        '
        'panelArriba
        '
        Me.panelArriba.BackColor = System.Drawing.Color.Orange
        Me.panelArriba.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelArriba.ForeColor = System.Drawing.SystemColors.Control
        Me.panelArriba.Location = New System.Drawing.Point(200, 0)
        Me.panelArriba.Name = "panelArriba"
        Me.panelArriba.Size = New System.Drawing.Size(776, 42)
        Me.panelArriba.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(206, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "DNI"
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(280, 102)
        Me.txtDNI.Multiline = True
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(191, 26)
        Me.txtDNI.TabIndex = 3
        '
        'txtNOMBRE
        '
        Me.txtNOMBRE.Location = New System.Drawing.Point(280, 151)
        Me.txtNOMBRE.Multiline = True
        Me.txtNOMBRE.Name = "txtNOMBRE"
        Me.txtNOMBRE.Size = New System.Drawing.Size(191, 26)
        Me.txtNOMBRE.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(206, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "NOMBRE"
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(280, 209)
        Me.txtApellido.Multiline = True
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(191, 26)
        Me.txtApellido.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(206, 210)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "APELLIDO"
        '
        'txtGRADO
        '
        Me.txtGRADO.Location = New System.Drawing.Point(280, 267)
        Me.txtGRADO.Multiline = True
        Me.txtGRADO.Name = "txtGRADO"
        Me.txtGRADO.Size = New System.Drawing.Size(191, 26)
        Me.txtGRADO.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(206, 268)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "GRADO"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(488, 66)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(422, 293)
        Me.DataGridView1.TabIndex = 10
        '
        'CRUDDB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleVioletRed
        Me.ClientSize = New System.Drawing.Size(976, 395)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtGRADO)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNOMBRE)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDNI)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.panelArriba)
        Me.Controls.Add(Me.panelIzquierda)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "CRUDDB"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.panelIzquierda.ResumeLayout(False)
        Me.panelIzquierda.PerformLayout()
        CType(Me.picMaximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents panelIzquierda As System.Windows.Forms.Panel
    Friend WithEvents panelArriba As System.Windows.Forms.Panel
    Friend WithEvents panelPuntero As System.Windows.Forms.Panel
    Friend WithEvents btnAGREGAR As System.Windows.Forms.Button
    Friend WithEvents btnELIMINAR As System.Windows.Forms.Button
    Friend WithEvents btnBUSCAR As System.Windows.Forms.Button
    Friend WithEvents btnEDITAR As System.Windows.Forms.Button
    Friend WithEvents picCerrar As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents picMaximizar As System.Windows.Forms.PictureBox
    Friend WithEvents picMinimizar As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDNI As System.Windows.Forms.TextBox
    Friend WithEvents txtNOMBRE As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtGRADO As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView

End Class
