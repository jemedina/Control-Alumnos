<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calif
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
        Me.components = New System.ComponentModel.Container()
        Dim PorcentajeLabel As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim MatriculaLabel As System.Windows.Forms.Label
        Dim CalificacionLabel As System.Windows.Forms.Label
        Dim Numero_de_subLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.MateriasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Control_de_calificaciones_dbDataSet = New Control_de_alumnos.control_de_calificaciones_dbDataSet()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.UnidadesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.SubUnidadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AlumnosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.GrupoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GrupoTableAdapter = New Control_de_alumnos.control_de_calificaciones_dbDataSetTableAdapters.GrupoTableAdapter()
        Me.MateriasTableAdapter = New Control_de_alumnos.control_de_calificaciones_dbDataSetTableAdapters.MateriasTableAdapter()
        Me.Sub_unidadTableAdapter = New Control_de_alumnos.control_de_calificaciones_dbDataSetTableAdapters.Sub_unidadTableAdapter()
        Me.UnidadesTableAdapter = New Control_de_alumnos.control_de_calificaciones_dbDataSetTableAdapters.UnidadesTableAdapter()
        Me.AlumnosTableAdapter = New Control_de_alumnos.control_de_calificaciones_dbDataSetTableAdapters.AlumnosTableAdapter()
        Me.CalificacionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CalificacionesTableAdapter = New Control_de_alumnos.control_de_calificaciones_dbDataSetTableAdapters.CalificacionesTableAdapter()
        Me.TableAdapterManager = New Control_de_alumnos.control_de_calificaciones_dbDataSetTableAdapters.TableAdapterManager()
        Me.PorcentajeTextBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.MatriculaTextBox = New System.Windows.Forms.TextBox()
        Me.PorcentajeTextBox1 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ListaAlumnos = New System.Windows.Forms.ComboBox()
        Me.CalificacionesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.SuperControl = New System.Windows.Forms.TextBox()
        Me.OtherSuperControl = New System.Windows.Forms.TextBox()
        Me.Numero_de_subTextBox = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarCalificacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RevisarCalificacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirMenuPrincipalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        PorcentajeLabel = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        MatriculaLabel = New System.Windows.Forms.Label()
        CalificacionLabel = New System.Windows.Forms.Label()
        Numero_de_subLabel = New System.Windows.Forms.Label()
        CType(Me.MateriasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Control_de_calificaciones_dbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnidadesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubUnidadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlumnosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrupoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CalificacionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CalificacionesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PorcentajeLabel
        '
        PorcentajeLabel.AutoSize = True
        PorcentajeLabel.Location = New System.Drawing.Point(212, 111)
        PorcentajeLabel.Name = "PorcentajeLabel"
        PorcentajeLabel.Size = New System.Drawing.Size(34, 13)
        PorcentajeLabel.TabIndex = 14
        PorcentajeLabel.Text = "Valor:"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(337, 198)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(53, 13)
        Label8.TabIndex = 17
        Label8.Text = "Matricula:"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Location = New System.Drawing.Point(572, 109)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(34, 13)
        Label9.TabIndex = 20
        Label9.Text = "Valor:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(884, 178)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 32
        NombreLabel.Text = "Nombre:"
        '
        'MatriculaLabel
        '
        MatriculaLabel.AutoSize = True
        MatriculaLabel.Location = New System.Drawing.Point(878, 204)
        MatriculaLabel.Name = "MatriculaLabel"
        MatriculaLabel.Size = New System.Drawing.Size(53, 13)
        MatriculaLabel.TabIndex = 33
        MatriculaLabel.Text = "Matricula:"
        '
        'CalificacionLabel
        '
        CalificacionLabel.AutoSize = True
        CalificacionLabel.Location = New System.Drawing.Point(867, 307)
        CalificacionLabel.Name = "CalificacionLabel"
        CalificacionLabel.Size = New System.Drawing.Size(64, 13)
        CalificacionLabel.TabIndex = 35
        CalificacionLabel.Text = "Calificacion:"
        '
        'Numero_de_subLabel
        '
        Numero_de_subLabel.AutoSize = True
        Numero_de_subLabel.Location = New System.Drawing.Point(849, 152)
        Numero_de_subLabel.Name = "Numero_de_subLabel"
        Numero_de_subLabel.Size = New System.Drawing.Size(82, 13)
        Numero_de_subLabel.TabIndex = 36
        Numero_de_subLabel.Text = "Numero de sub:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Grupo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(329, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Materia"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(253, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Unidad"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(558, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Sub unidad"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(329, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Alumno"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(490, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Calificacion"
        '
        'ComboBox2
        '
        Me.ComboBox2.DataSource = Me.MateriasBindingSource
        Me.ComboBox2.DisplayMember = "Materia"
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(125, 39)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(507, 21)
        Me.ComboBox2.TabIndex = 7
        Me.ComboBox2.ValueMember = "Materia"
        '
        'MateriasBindingSource
        '
        Me.MateriasBindingSource.DataMember = "Materias"
        Me.MateriasBindingSource.DataSource = Me.Control_de_calificaciones_dbDataSet
        '
        'Control_de_calificaciones_dbDataSet
        '
        Me.Control_de_calificaciones_dbDataSet.DataSetName = "control_de_calificaciones_dbDataSet"
        Me.Control_de_calificaciones_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ComboBox3
        '
        Me.ComboBox3.DataSource = Me.UnidadesBindingSource
        Me.ComboBox3.DisplayMember = "FullName"
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(125, 86)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(400, 21)
        Me.ComboBox3.TabIndex = 8
        Me.ComboBox3.ValueMember = "FullName"
        '
        'UnidadesBindingSource
        '
        Me.UnidadesBindingSource.DataMember = "Unidades"
        Me.UnidadesBindingSource.DataSource = Me.Control_de_calificaciones_dbDataSet
        '
        'ComboBox4
        '
        Me.ComboBox4.DataSource = Me.SubUnidadBindingSource
        Me.ComboBox4.DisplayMember = "Numero de sub"
        Me.ComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(542, 86)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(90, 21)
        Me.ComboBox4.TabIndex = 9
        Me.ComboBox4.ValueMember = "Numero de sub"
        '
        'SubUnidadBindingSource
        '
        Me.SubUnidadBindingSource.DataMember = "Sub unidad"
        Me.SubUnidadBindingSource.DataSource = Me.Control_de_calificaciones_dbDataSet
        '
        'AlumnosBindingSource
        '
        Me.AlumnosBindingSource.DataMember = "Alumnos"
        Me.AlumnosBindingSource.DataSource = Me.Control_de_calificaciones_dbDataSet
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(486, 175)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(71, 20)
        Me.TextBox1.TabIndex = 11
        '
        'ListBox1
        '
        Me.ListBox1.DataSource = Me.GrupoBindingSource
        Me.ListBox1.DisplayMember = "Nro de grupo"
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(12, 41)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(82, 134)
        Me.ListBox1.TabIndex = 13
        Me.ListBox1.ValueMember = "Nro de grupo"
        '
        'GrupoBindingSource
        '
        Me.GrupoBindingSource.DataMember = "Grupo"
        Me.GrupoBindingSource.DataSource = Me.Control_de_calificaciones_dbDataSet
        '
        'GrupoTableAdapter
        '
        Me.GrupoTableAdapter.ClearBeforeFill = True
        '
        'MateriasTableAdapter
        '
        Me.MateriasTableAdapter.ClearBeforeFill = True
        '
        'Sub_unidadTableAdapter
        '
        Me.Sub_unidadTableAdapter.ClearBeforeFill = True
        '
        'UnidadesTableAdapter
        '
        Me.UnidadesTableAdapter.ClearBeforeFill = True
        '
        'AlumnosTableAdapter
        '
        Me.AlumnosTableAdapter.ClearBeforeFill = True
        '
        'CalificacionesBindingSource
        '
        Me.CalificacionesBindingSource.DataMember = "Calificaciones"
        Me.CalificacionesBindingSource.DataSource = Me.Control_de_calificaciones_dbDataSet
        '
        'CalificacionesTableAdapter
        '
        Me.CalificacionesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AlumnosTableAdapter = Me.AlumnosTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CalificacionesTableAdapter = Me.CalificacionesTableAdapter
        Me.TableAdapterManager.GrupoTableAdapter = Me.GrupoTableAdapter
        Me.TableAdapterManager.UpdateOrder = Control_de_alumnos.control_de_calificaciones_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PorcentajeTextBox
        '
        Me.PorcentajeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UnidadesBindingSource, "Porcentaje", True))
        Me.PorcentajeTextBox.Enabled = False
        Me.PorcentajeTextBox.Location = New System.Drawing.Point(194, 127)
        Me.PorcentajeTextBox.Name = "PorcentajeTextBox"
        Me.PorcentajeTextBox.ReadOnly = True
        Me.PorcentajeTextBox.Size = New System.Drawing.Size(59, 20)
        Me.PorcentajeTextBox.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(253, 130)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(15, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "%"
        '
        'MatriculaTextBox
        '
        Me.MatriculaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlumnosBindingSource, "Matricula", True))
        Me.MatriculaTextBox.Enabled = False
        Me.MatriculaTextBox.Location = New System.Drawing.Point(319, 214)
        Me.MatriculaTextBox.Name = "MatriculaTextBox"
        Me.MatriculaTextBox.ReadOnly = True
        Me.MatriculaTextBox.Size = New System.Drawing.Size(93, 20)
        Me.MatriculaTextBox.TabIndex = 19
        '
        'PorcentajeTextBox1
        '
        Me.PorcentajeTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SubUnidadBindingSource, "Porcentaje", True))
        Me.PorcentajeTextBox1.Enabled = False
        Me.PorcentajeTextBox1.Location = New System.Drawing.Point(549, 123)
        Me.PorcentajeTextBox1.Name = "PorcentajeTextBox1"
        Me.PorcentajeTextBox1.ReadOnly = True
        Me.PorcentajeTextBox1.Size = New System.Drawing.Size(62, 20)
        Me.PorcentajeTextBox1.TabIndex = 21
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(617, 126)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(15, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "%"
        '
        'ListaAlumnos
        '
        Me.ListaAlumnos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ListaAlumnos.FormattingEnabled = True
        Me.ListaAlumnos.Location = New System.Drawing.Point(232, 175)
        Me.ListaAlumnos.Name = "ListaAlumnos"
        Me.ListaAlumnos.Size = New System.Drawing.Size(242, 21)
        Me.ListaAlumnos.TabIndex = 23
        '
        'CalificacionesDataGridView
        '
        Me.CalificacionesDataGridView.AutoGenerateColumns = False
        Me.CalificacionesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CalificacionesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.CalificacionesDataGridView.DataSource = Me.CalificacionesBindingSource
        Me.CalificacionesDataGridView.Enabled = False
        Me.CalificacionesDataGridView.Location = New System.Drawing.Point(24, 283)
        Me.CalificacionesDataGridView.Name = "CalificacionesDataGridView"
        Me.CalificacionesDataGridView.Size = New System.Drawing.Size(653, 237)
        Me.CalificacionesDataGridView.TabIndex = 31
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Unidad"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Unidad"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Sub unidad"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Sub unidad"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Matricula"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Matricula"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Calificacion"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Calificacion"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Materia"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Materia"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlumnosBindingSource, "Nombre", True))
        Me.NombreTextBox.Enabled = False
        Me.NombreTextBox.Location = New System.Drawing.Point(937, 175)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NombreTextBox.TabIndex = 33
        '
        'SuperControl
        '
        Me.SuperControl.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlumnosBindingSource, "Matricula", True))
        Me.SuperControl.Enabled = False
        Me.SuperControl.Location = New System.Drawing.Point(937, 201)
        Me.SuperControl.Name = "SuperControl"
        Me.SuperControl.Size = New System.Drawing.Size(100, 20)
        Me.SuperControl.TabIndex = 34
        '
        'OtherSuperControl
        '
        Me.OtherSuperControl.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CalificacionesBindingSource, "Calificacion", True))
        Me.OtherSuperControl.Enabled = False
        Me.OtherSuperControl.Location = New System.Drawing.Point(937, 304)
        Me.OtherSuperControl.Name = "OtherSuperControl"
        Me.OtherSuperControl.Size = New System.Drawing.Size(100, 20)
        Me.OtherSuperControl.TabIndex = 36
        '
        'Numero_de_subTextBox
        '
        Me.Numero_de_subTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SubUnidadBindingSource, "Numero de sub", True))
        Me.Numero_de_subTextBox.Enabled = False
        Me.Numero_de_subTextBox.Location = New System.Drawing.Point(937, 149)
        Me.Numero_de_subTextBox.Name = "Numero_de_subTextBox"
        Me.Numero_de_subTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Numero_de_subTextBox.TabIndex = 37
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(12, 222)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(97, 17)
        Me.CheckBox1.TabIndex = 38
        Me.CheckBox1.Text = "Mostrar capura"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.ModificarCalificacionesToolStripMenuItem, Me.RevisarCalificacionesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(698, 24)
        Me.MenuStrip1.TabIndex = 39
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarToolStripMenuItem, Me.AbrirMenuPrincipalToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'ModificarCalificacionesToolStripMenuItem
        '
        Me.ModificarCalificacionesToolStripMenuItem.Name = "ModificarCalificacionesToolStripMenuItem"
        Me.ModificarCalificacionesToolStripMenuItem.Size = New System.Drawing.Size(144, 20)
        Me.ModificarCalificacionesToolStripMenuItem.Text = "Modificar calificaciones"
        '
        'RevisarCalificacionesToolStripMenuItem
        '
        Me.RevisarCalificacionesToolStripMenuItem.Name = "RevisarCalificacionesToolStripMenuItem"
        Me.RevisarCalificacionesToolStripMenuItem.Size = New System.Drawing.Size(130, 20)
        Me.RevisarCalificacionesToolStripMenuItem.Text = "Revisar calificaciones"
        '
        'CerrarToolStripMenuItem
        '
        Me.CerrarToolStripMenuItem.Name = "CerrarToolStripMenuItem"
        Me.CerrarToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.CerrarToolStripMenuItem.Text = "Cerrar"
        '
        'AbrirMenuPrincipalToolStripMenuItem
        '
        Me.AbrirMenuPrincipalToolStripMenuItem.Name = "AbrirMenuPrincipalToolStripMenuItem"
        Me.AbrirMenuPrincipalToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.AbrirMenuPrincipalToolStripMenuItem.Text = "Abrir menu principal"
        '
        'Calif
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(698, 246)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Numero_de_subLabel)
        Me.Controls.Add(Me.Numero_de_subTextBox)
        Me.Controls.Add(CalificacionLabel)
        Me.Controls.Add(Me.OtherSuperControl)
        Me.Controls.Add(MatriculaLabel)
        Me.Controls.Add(Me.SuperControl)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(Me.CalificacionesDataGridView)
        Me.Controls.Add(Me.ListaAlumnos)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.PorcentajeTextBox1)
        Me.Controls.Add(Label9)
        Me.Controls.Add(Me.MatriculaTextBox)
        Me.Controls.Add(Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(PorcentajeLabel)
        Me.Controls.Add(Me.PorcentajeTextBox)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Calif"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calif"
        CType(Me.MateriasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Control_de_calificaciones_dbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnidadesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubUnidadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlumnosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrupoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CalificacionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CalificacionesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Control_de_calificaciones_dbDataSet As Control_de_alumnos.control_de_calificaciones_dbDataSet
    Friend WithEvents GrupoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GrupoTableAdapter As Control_de_alumnos.control_de_calificaciones_dbDataSetTableAdapters.GrupoTableAdapter
    Friend WithEvents MateriasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MateriasTableAdapter As Control_de_alumnos.control_de_calificaciones_dbDataSetTableAdapters.MateriasTableAdapter
    Friend WithEvents SubUnidadBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sub_unidadTableAdapter As Control_de_alumnos.control_de_calificaciones_dbDataSetTableAdapters.Sub_unidadTableAdapter
    Friend WithEvents UnidadesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UnidadesTableAdapter As Control_de_alumnos.control_de_calificaciones_dbDataSetTableAdapters.UnidadesTableAdapter
    Friend WithEvents AlumnosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AlumnosTableAdapter As Control_de_alumnos.control_de_calificaciones_dbDataSetTableAdapters.AlumnosTableAdapter
    Friend WithEvents CalificacionesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CalificacionesTableAdapter As Control_de_alumnos.control_de_calificaciones_dbDataSetTableAdapters.CalificacionesTableAdapter
    Friend WithEvents TableAdapterManager As Control_de_alumnos.control_de_calificaciones_dbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PorcentajeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents MatriculaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PorcentajeTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ListaAlumnos As System.Windows.Forms.ComboBox
    Friend WithEvents CalificacionesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
    Public WithEvents SuperControl As System.Windows.Forms.TextBox
    Friend WithEvents OtherSuperControl As System.Windows.Forms.TextBox
    Friend WithEvents Numero_de_subTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarCalificacionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RevisarCalificacionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbrirMenuPrincipalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
