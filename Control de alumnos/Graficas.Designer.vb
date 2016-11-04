<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Graficas
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
        Dim MatriculaLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim FullNameLabel As System.Windows.Forms.Label
        Dim Numero_de_la_unidadLabel As System.Windows.Forms.Label
        Dim PorcentajeLabel As System.Windows.Forms.Label
        Dim Numero_de_subLabel As System.Windows.Forms.Label
        Dim PorcentajeLabel1 As System.Windows.Forms.Label
        Dim CalificacionLabel As System.Windows.Forms.Label
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Me.Control_de_calificaciones_dbDataSet = New Control_de_alumnos.control_de_calificaciones_dbDataSet()
        Me.AlumnosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AlumnosTableAdapter = New Control_de_alumnos.control_de_calificaciones_dbDataSetTableAdapters.AlumnosTableAdapter()
        Me.TableAdapterManager = New Control_de_alumnos.control_de_calificaciones_dbDataSetTableAdapters.TableAdapterManager()
        Me.GrupoTableAdapter = New Control_de_alumnos.control_de_calificaciones_dbDataSetTableAdapters.GrupoTableAdapter()
        Me.MatriculaTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.Grupos = New System.Windows.Forms.ComboBox()
        Me.GrupoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Materias = New System.Windows.Forms.ComboBox()
        Me.MateriasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MateriasTableAdapter = New Control_de_alumnos.control_de_calificaciones_dbDataSetTableAdapters.MateriasTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.UnidadesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UnidadesTableAdapter = New Control_de_alumnos.control_de_calificaciones_dbDataSetTableAdapters.UnidadesTableAdapter()
        Me.Nombre_de_la_unidadTextBox = New System.Windows.Forms.TextBox()
        Me.Numero_de_la_unidadTextBox = New System.Windows.Forms.TextBox()
        Me.PorcentajeTextBox = New System.Windows.Forms.TextBox()
        Me.Sub_unidadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sub_unidadTableAdapter = New Control_de_alumnos.control_de_calificaciones_dbDataSetTableAdapters.Sub_unidadTableAdapter()
        Me.Numero_de_subTextBox = New System.Windows.Forms.TextBox()
        Me.PorcentajeTextBox1 = New System.Windows.Forms.TextBox()
        Me.CalificacionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CalificacionesTableAdapter = New Control_de_alumnos.control_de_calificaciones_dbDataSetTableAdapters.CalificacionesTableAdapter()
        Me.CalificacionTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        MatriculaLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        FullNameLabel = New System.Windows.Forms.Label()
        Numero_de_la_unidadLabel = New System.Windows.Forms.Label()
        PorcentajeLabel = New System.Windows.Forms.Label()
        Numero_de_subLabel = New System.Windows.Forms.Label()
        PorcentajeLabel1 = New System.Windows.Forms.Label()
        CalificacionLabel = New System.Windows.Forms.Label()
        CType(Me.Control_de_calificaciones_dbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlumnosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrupoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MateriasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnidadesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sub_unidadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CalificacionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MatriculaLabel
        '
        MatriculaLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        MatriculaLabel.AutoSize = True
        MatriculaLabel.Enabled = False
        MatriculaLabel.Location = New System.Drawing.Point(1124, 324)
        MatriculaLabel.Name = "MatriculaLabel"
        MatriculaLabel.Size = New System.Drawing.Size(53, 13)
        MatriculaLabel.TabIndex = 3
        MatriculaLabel.Text = "Matricula:"
        '
        'NombreLabel
        '
        NombreLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        NombreLabel.AutoSize = True
        NombreLabel.Enabled = False
        NombreLabel.Location = New System.Drawing.Point(1130, 350)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 5
        NombreLabel.Text = "Nombre:"
        '
        'FullNameLabel
        '
        FullNameLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        FullNameLabel.AutoSize = True
        FullNameLabel.Location = New System.Drawing.Point(1120, 74)
        FullNameLabel.Name = "FullNameLabel"
        FullNameLabel.Size = New System.Drawing.Size(57, 13)
        FullNameLabel.TabIndex = 13
        FullNameLabel.Text = "Full Name:"
        '
        'Numero_de_la_unidadLabel
        '
        Numero_de_la_unidadLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Numero_de_la_unidadLabel.AutoSize = True
        Numero_de_la_unidadLabel.Location = New System.Drawing.Point(1097, 100)
        Numero_de_la_unidadLabel.Name = "Numero_de_la_unidadLabel"
        Numero_de_la_unidadLabel.Size = New System.Drawing.Size(108, 13)
        Numero_de_la_unidadLabel.TabIndex = 14
        Numero_de_la_unidadLabel.Text = "Numero de la unidad:"
        '
        'PorcentajeLabel
        '
        PorcentajeLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        PorcentajeLabel.AutoSize = True
        PorcentajeLabel.Location = New System.Drawing.Point(1116, 126)
        PorcentajeLabel.Name = "PorcentajeLabel"
        PorcentajeLabel.Size = New System.Drawing.Size(61, 13)
        PorcentajeLabel.TabIndex = 15
        PorcentajeLabel.Text = "Porcentaje:"
        '
        'Numero_de_subLabel
        '
        Numero_de_subLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Numero_de_subLabel.AutoSize = True
        Numero_de_subLabel.Location = New System.Drawing.Point(1095, 193)
        Numero_de_subLabel.Name = "Numero_de_subLabel"
        Numero_de_subLabel.Size = New System.Drawing.Size(82, 13)
        Numero_de_subLabel.TabIndex = 17
        Numero_de_subLabel.Text = "Numero de sub:"
        '
        'PorcentajeLabel1
        '
        PorcentajeLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        PorcentajeLabel1.AutoSize = True
        PorcentajeLabel1.Location = New System.Drawing.Point(1116, 219)
        PorcentajeLabel1.Name = "PorcentajeLabel1"
        PorcentajeLabel1.Size = New System.Drawing.Size(61, 13)
        PorcentajeLabel1.TabIndex = 19
        PorcentajeLabel1.Text = "Porcentaje:"
        '
        'CalificacionLabel
        '
        CalificacionLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        CalificacionLabel.AutoSize = True
        CalificacionLabel.Location = New System.Drawing.Point(1113, 293)
        CalificacionLabel.Name = "CalificacionLabel"
        CalificacionLabel.Size = New System.Drawing.Size(64, 13)
        CalificacionLabel.TabIndex = 21
        CalificacionLabel.Text = "Calificacion:"
        '
        'Control_de_calificaciones_dbDataSet
        '
        Me.Control_de_calificaciones_dbDataSet.DataSetName = "control_de_calificaciones_dbDataSet"
        Me.Control_de_calificaciones_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AlumnosBindingSource
        '
        Me.AlumnosBindingSource.DataMember = "Alumnos"
        Me.AlumnosBindingSource.DataSource = Me.Control_de_calificaciones_dbDataSet
        '
        'AlumnosTableAdapter
        '
        Me.AlumnosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AlumnosTableAdapter = Me.AlumnosTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CalificacionesTableAdapter = Nothing
        Me.TableAdapterManager.GrupoTableAdapter = Me.GrupoTableAdapter
        Me.TableAdapterManager.UpdateOrder = Control_de_alumnos.control_de_calificaciones_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GrupoTableAdapter
        '
        Me.GrupoTableAdapter.ClearBeforeFill = True
        '
        'MatriculaTextBox
        '
        Me.MatriculaTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MatriculaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlumnosBindingSource, "Matricula", True))
        Me.MatriculaTextBox.Enabled = False
        Me.MatriculaTextBox.Location = New System.Drawing.Point(1183, 321)
        Me.MatriculaTextBox.Name = "MatriculaTextBox"
        Me.MatriculaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MatriculaTextBox.TabIndex = 4
        '
        'NombreTextBox
        '
        Me.NombreTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlumnosBindingSource, "Nombre", True))
        Me.NombreTextBox.Enabled = False
        Me.NombreTextBox.Location = New System.Drawing.Point(1183, 347)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NombreTextBox.TabIndex = 6
        '
        'Grupos
        '
        Me.Grupos.DataSource = Me.GrupoBindingSource
        Me.Grupos.DisplayMember = "Nro de grupo"
        Me.Grupos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Grupos.FormattingEnabled = True
        Me.Grupos.Location = New System.Drawing.Point(13, 48)
        Me.Grupos.Name = "Grupos"
        Me.Grupos.Size = New System.Drawing.Size(121, 21)
        Me.Grupos.TabIndex = 7
        Me.Grupos.ValueMember = "Nro de grupo"
        '
        'GrupoBindingSource
        '
        Me.GrupoBindingSource.DataMember = "Grupo"
        Me.GrupoBindingSource.DataSource = Me.Control_de_calificaciones_dbDataSet
        '
        'Materias
        '
        Me.Materias.DataSource = Me.MateriasBindingSource
        Me.Materias.DisplayMember = "Materia"
        Me.Materias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Materias.FormattingEnabled = True
        Me.Materias.Location = New System.Drawing.Point(163, 48)
        Me.Materias.Name = "Materias"
        Me.Materias.Size = New System.Drawing.Size(121, 21)
        Me.Materias.TabIndex = 8
        Me.Materias.ValueMember = "Materia"
        '
        'MateriasBindingSource
        '
        Me.MateriasBindingSource.DataMember = "Materias"
        Me.MateriasBindingSource.DataSource = Me.Control_de_calificaciones_dbDataSet
        '
        'MateriasTableAdapter
        '
        Me.MateriasTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Grupo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(201, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Materia"
        '
        'UnidadesBindingSource
        '
        Me.UnidadesBindingSource.DataMember = "Unidades"
        Me.UnidadesBindingSource.DataSource = Me.Control_de_calificaciones_dbDataSet
        '
        'UnidadesTableAdapter
        '
        Me.UnidadesTableAdapter.ClearBeforeFill = True
        '
        'Nombre_de_la_unidadTextBox
        '
        Me.Nombre_de_la_unidadTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Nombre_de_la_unidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UnidadesBindingSource, "FullName", True))
        Me.Nombre_de_la_unidadTextBox.Enabled = False
        Me.Nombre_de_la_unidadTextBox.Location = New System.Drawing.Point(1183, 71)
        Me.Nombre_de_la_unidadTextBox.Name = "Nombre_de_la_unidadTextBox"
        Me.Nombre_de_la_unidadTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Nombre_de_la_unidadTextBox.TabIndex = 14
        '
        'Numero_de_la_unidadTextBox
        '
        Me.Numero_de_la_unidadTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Numero_de_la_unidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UnidadesBindingSource, "Numero de la unidad", True))
        Me.Numero_de_la_unidadTextBox.Enabled = False
        Me.Numero_de_la_unidadTextBox.Location = New System.Drawing.Point(1183, 97)
        Me.Numero_de_la_unidadTextBox.Name = "Numero_de_la_unidadTextBox"
        Me.Numero_de_la_unidadTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Numero_de_la_unidadTextBox.TabIndex = 15
        '
        'PorcentajeTextBox
        '
        Me.PorcentajeTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PorcentajeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UnidadesBindingSource, "Porcentaje", True))
        Me.PorcentajeTextBox.Enabled = False
        Me.PorcentajeTextBox.Location = New System.Drawing.Point(1183, 123)
        Me.PorcentajeTextBox.Name = "PorcentajeTextBox"
        Me.PorcentajeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PorcentajeTextBox.TabIndex = 16
        '
        'Sub_unidadBindingSource
        '
        Me.Sub_unidadBindingSource.DataMember = "Sub unidad"
        Me.Sub_unidadBindingSource.DataSource = Me.Control_de_calificaciones_dbDataSet
        '
        'Sub_unidadTableAdapter
        '
        Me.Sub_unidadTableAdapter.ClearBeforeFill = True
        '
        'Numero_de_subTextBox
        '
        Me.Numero_de_subTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Numero_de_subTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sub_unidadBindingSource, "Numero de sub", True))
        Me.Numero_de_subTextBox.Enabled = False
        Me.Numero_de_subTextBox.Location = New System.Drawing.Point(1183, 190)
        Me.Numero_de_subTextBox.Name = "Numero_de_subTextBox"
        Me.Numero_de_subTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Numero_de_subTextBox.TabIndex = 18
        '
        'PorcentajeTextBox1
        '
        Me.PorcentajeTextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PorcentajeTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sub_unidadBindingSource, "Porcentaje", True))
        Me.PorcentajeTextBox1.Enabled = False
        Me.PorcentajeTextBox1.Location = New System.Drawing.Point(1183, 216)
        Me.PorcentajeTextBox1.Name = "PorcentajeTextBox1"
        Me.PorcentajeTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.PorcentajeTextBox1.TabIndex = 20
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
        'CalificacionTextBox
        '
        Me.CalificacionTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CalificacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CalificacionesBindingSource, "Calificacion", True))
        Me.CalificacionTextBox.Enabled = False
        Me.CalificacionTextBox.Location = New System.Drawing.Point(1183, 290)
        Me.CalificacionTextBox.Name = "CalificacionTextBox"
        Me.CalificacionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CalificacionTextBox.TabIndex = 22
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(960, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 23)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Exportar reporte"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarToolStripMenuItem, Me.ActualizarToolStripMenuItem, Me.ExportarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1084, 24)
        Me.MenuStrip1.TabIndex = 25
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CerrarToolStripMenuItem
        '
        Me.CerrarToolStripMenuItem.Name = "CerrarToolStripMenuItem"
        Me.CerrarToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.CerrarToolStripMenuItem.Text = "Cerrar"
        '
        'ActualizarToolStripMenuItem
        '
        Me.ActualizarToolStripMenuItem.Name = "ActualizarToolStripMenuItem"
        Me.ActualizarToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.ActualizarToolStripMenuItem.Text = "Actualizar"
        '
        'ExportarToolStripMenuItem
        '
        Me.ExportarToolStripMenuItem.Name = "ExportarToolStripMenuItem"
        Me.ExportarToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.ExportarToolStripMenuItem.Text = "Exportar"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.HotTrack = True
        Me.TabControl1.Location = New System.Drawing.Point(0, 75)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1084, 551)
        Me.TabControl1.TabIndex = 26
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.Chart1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1076, 525)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Grafica"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(962, 1)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(113, 23)
        Me.Button2.TabIndex = 27
        Me.Button2.Text = "Exportar reporte"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Chart1
        '
        Me.Chart1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ChartArea1.Area3DStyle.Enable3D = True
        ChartArea1.Area3DStyle.Inclination = 10
        ChartArea1.Area3DStyle.Rotation = 10
        ChartArea1.BackColor = System.Drawing.Color.LightBlue
        ChartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter
        ChartArea1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.DarkDownwardDiagonal
        ChartArea1.Name = "ChartArea1"
        ChartArea1.ShadowColor = System.Drawing.Color.Gray
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(3, 29)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar
        Series1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series1.IsValueShownAsLabel = True
        Series1.LabelBackColor = System.Drawing.Color.Black
        Series1.LabelBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Series1.LabelBorderWidth = 2
        Series1.LabelForeColor = System.Drawing.Color.White
        Series1.Legend = "Legend1"
        Series1.Name = "Calificaciones"
        Series1.YValuesPerPoint = 4
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(1072, 495)
        Me.Chart1.TabIndex = 22
        Me.Chart1.Text = "Chart1"
        Title1.BackColor = System.Drawing.Color.Black
        Title1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter
        Title1.BorderColor = System.Drawing.Color.Red
        Title1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title1.ForeColor = System.Drawing.Color.Red
        Title1.Name = "Title1"
        Title1.Text = "Grafica"
        Me.Chart1.Titles.Add(Title1)
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.WebBrowser1)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1076, 525)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Grafica en HTML"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WebBrowser1.Location = New System.Drawing.Point(2, 32)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(1068, 434)
        Me.WebBrowser1.TabIndex = 25
        '
        'Graficas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 628)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(CalificacionLabel)
        Me.Controls.Add(Me.CalificacionTextBox)
        Me.Controls.Add(PorcentajeLabel1)
        Me.Controls.Add(Me.PorcentajeTextBox1)
        Me.Controls.Add(Numero_de_subLabel)
        Me.Controls.Add(Me.Numero_de_subTextBox)
        Me.Controls.Add(PorcentajeLabel)
        Me.Controls.Add(Me.PorcentajeTextBox)
        Me.Controls.Add(Numero_de_la_unidadLabel)
        Me.Controls.Add(Me.Numero_de_la_unidadTextBox)
        Me.Controls.Add(FullNameLabel)
        Me.Controls.Add(Me.Nombre_de_la_unidadTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Materias)
        Me.Controls.Add(Me.Grupos)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(MatriculaLabel)
        Me.Controls.Add(Me.MatriculaTextBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Graficas"
        Me.Text = "Graficas"
        CType(Me.Control_de_calificaciones_dbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlumnosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrupoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MateriasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnidadesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sub_unidadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CalificacionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Control_de_calificaciones_dbDataSet As Control_de_alumnos.control_de_calificaciones_dbDataSet
    Friend WithEvents AlumnosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AlumnosTableAdapter As Control_de_alumnos.control_de_calificaciones_dbDataSetTableAdapters.AlumnosTableAdapter
    Friend WithEvents TableAdapterManager As Control_de_alumnos.control_de_calificaciones_dbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MatriculaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GrupoTableAdapter As Control_de_alumnos.control_de_calificaciones_dbDataSetTableAdapters.GrupoTableAdapter
    Friend WithEvents Grupos As System.Windows.Forms.ComboBox
    Friend WithEvents GrupoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Materias As System.Windows.Forms.ComboBox
    Friend WithEvents MateriasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MateriasTableAdapter As Control_de_alumnos.control_de_calificaciones_dbDataSetTableAdapters.MateriasTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents UnidadesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UnidadesTableAdapter As Control_de_alumnos.control_de_calificaciones_dbDataSetTableAdapters.UnidadesTableAdapter
    Friend WithEvents Nombre_de_la_unidadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Numero_de_la_unidadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PorcentajeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Sub_unidadBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sub_unidadTableAdapter As Control_de_alumnos.control_de_calificaciones_dbDataSetTableAdapters.Sub_unidadTableAdapter
    Friend WithEvents Numero_de_subTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PorcentajeTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents CalificacionesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CalificacionesTableAdapter As Control_de_alumnos.control_de_calificaciones_dbDataSetTableAdapters.CalificacionesTableAdapter
    Friend WithEvents CalificacionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CerrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActualizarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
End Class
