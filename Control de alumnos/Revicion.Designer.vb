<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Revicion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            Try
                MyBase.Dispose(disposing)
            Catch ex As Exception
                MyBase.Dispose(disposing)
            End Try

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
        Dim Nombre_de_la_unidadLabel As System.Windows.Forms.Label
        Dim PorcentajeLabel As System.Windows.Forms.Label
        Dim Numero_de_subLabel As System.Windows.Forms.Label
        Dim PorcentajeLabel1 As System.Windows.Forms.Label
        Dim CalificacionLabel As System.Windows.Forms.Label
        Dim MatriculaLabel As System.Windows.Forms.Label
        Dim Numero_de_la_unidadLabel As System.Windows.Forms.Label
        Dim FullNameLabel As System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GrupoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Control_de_calificaciones_dbDataSet = New Control_de_alumnos.control_de_calificaciones_dbDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AlumnosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AlumnosTableAdapter = New Control_de_alumnos.control_de_calificaciones_dbDataSetTableAdapters.AlumnosTableAdapter()
        Me.TableAdapterManager = New Control_de_alumnos.control_de_calificaciones_dbDataSetTableAdapters.TableAdapterManager()
        Me.CalificacionesTableAdapter = New Control_de_alumnos.control_de_calificaciones_dbDataSetTableAdapters.CalificacionesTableAdapter()
        Me.CalificacionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.GrupoTableAdapter = New Control_de_alumnos.control_de_calificaciones_dbDataSetTableAdapters.GrupoTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MATERIER = New System.Windows.Forms.ComboBox()
        Me.MateriasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CalificacionesAlumnosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MateriasTableAdapter = New Control_de_alumnos.control_de_calificaciones_dbDataSetTableAdapters.MateriasTableAdapter()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.MatriculaTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nombreLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.materiaLabel = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Nombre_de_la_unidadTextBox = New System.Windows.Forms.TextBox()
        Me.UnidadesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Numero_de_la_unidadTextBox = New System.Windows.Forms.TextBox()
        Me.CalificacionTextBox = New System.Windows.Forms.TextBox()
        Me.PorcentajeTextBox1 = New System.Windows.Forms.TextBox()
        Me.Sub_unidadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Numero_de_subTextBox = New System.Windows.Forms.TextBox()
        Me.PorcentajeTextBox = New System.Windows.Forms.TextBox()
        Me.UnidadesTableAdapter = New Control_de_alumnos.control_de_calificaciones_dbDataSetTableAdapters.UnidadesTableAdapter()
        Me.CalificacionesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.avanceLabel = New System.Windows.Forms.Label()
        Me.Sub_unidadTableAdapter = New Control_de_alumnos.control_de_calificaciones_dbDataSetTableAdapters.Sub_unidadTableAdapter()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IrACapturaDeCalificacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IrAConfiguracionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IrAGraficasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Nombre_de_la_unidadLabel = New System.Windows.Forms.Label()
        PorcentajeLabel = New System.Windows.Forms.Label()
        Numero_de_subLabel = New System.Windows.Forms.Label()
        PorcentajeLabel1 = New System.Windows.Forms.Label()
        CalificacionLabel = New System.Windows.Forms.Label()
        MatriculaLabel = New System.Windows.Forms.Label()
        Numero_de_la_unidadLabel = New System.Windows.Forms.Label()
        FullNameLabel = New System.Windows.Forms.Label()
        CType(Me.GrupoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Control_de_calificaciones_dbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlumnosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CalificacionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MateriasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CalificacionesAlumnosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.UnidadesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sub_unidadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CalificacionesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Nombre_de_la_unidadLabel
        '
        Nombre_de_la_unidadLabel.AutoSize = True
        Nombre_de_la_unidadLabel.Location = New System.Drawing.Point(14, 17)
        Nombre_de_la_unidadLabel.Name = "Nombre_de_la_unidadLabel"
        Nombre_de_la_unidadLabel.Size = New System.Drawing.Size(108, 13)
        Nombre_de_la_unidadLabel.TabIndex = 0
        Nombre_de_la_unidadLabel.Text = "Nombre de la unidad:"
        '
        'PorcentajeLabel
        '
        PorcentajeLabel.AutoSize = True
        PorcentajeLabel.Location = New System.Drawing.Point(29, 55)
        PorcentajeLabel.Name = "PorcentajeLabel"
        PorcentajeLabel.Size = New System.Drawing.Size(61, 13)
        PorcentajeLabel.TabIndex = 2
        PorcentajeLabel.Text = "Porcentaje:"
        '
        'Numero_de_subLabel
        '
        Numero_de_subLabel.AutoSize = True
        Numero_de_subLabel.Location = New System.Drawing.Point(12, 174)
        Numero_de_subLabel.Name = "Numero_de_subLabel"
        Numero_de_subLabel.Size = New System.Drawing.Size(82, 13)
        Numero_de_subLabel.TabIndex = 4
        Numero_de_subLabel.Text = "Numero de sub:"
        '
        'PorcentajeLabel1
        '
        PorcentajeLabel1.AutoSize = True
        PorcentajeLabel1.Location = New System.Drawing.Point(29, 213)
        PorcentajeLabel1.Name = "PorcentajeLabel1"
        PorcentajeLabel1.Size = New System.Drawing.Size(61, 13)
        PorcentajeLabel1.TabIndex = 6
        PorcentajeLabel1.Text = "Porcentaje:"
        '
        'CalificacionLabel
        '
        CalificacionLabel.AutoSize = True
        CalificacionLabel.Location = New System.Drawing.Point(26, 301)
        CalificacionLabel.Name = "CalificacionLabel"
        CalificacionLabel.Size = New System.Drawing.Size(64, 13)
        CalificacionLabel.TabIndex = 8
        CalificacionLabel.Text = "Calificacion:"
        '
        'MatriculaLabel
        '
        MatriculaLabel.AutoSize = True
        MatriculaLabel.Location = New System.Drawing.Point(342, 52)
        MatriculaLabel.Name = "MatriculaLabel"
        MatriculaLabel.Size = New System.Drawing.Size(53, 13)
        MatriculaLabel.TabIndex = 0
        MatriculaLabel.Text = "Matricula:"
        '
        'Numero_de_la_unidadLabel
        '
        Numero_de_la_unidadLabel.AutoSize = True
        Numero_de_la_unidadLabel.Location = New System.Drawing.Point(41, 120)
        Numero_de_la_unidadLabel.Name = "Numero_de_la_unidadLabel"
        Numero_de_la_unidadLabel.Size = New System.Drawing.Size(108, 13)
        Numero_de_la_unidadLabel.TabIndex = 10
        Numero_de_la_unidadLabel.Text = "Numero de la unidad:"
        '
        'FullNameLabel
        '
        FullNameLabel.AutoSize = True
        FullNameLabel.Location = New System.Drawing.Point(18, 36)
        FullNameLabel.Name = "FullNameLabel"
        FullNameLabel.Size = New System.Drawing.Size(57, 13)
        FullNameLabel.TabIndex = 12
        FullNameLabel.Text = "Full Name:"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.GrupoBindingSource
        Me.ComboBox1.DisplayMember = "Nro de grupo"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(12, 45)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.ValueMember = "Nro de grupo"
        '
        'GrupoBindingSource
        '
        Me.GrupoBindingSource.DataMember = "Grupo"
        Me.GrupoBindingSource.DataSource = Me.Control_de_calificaciones_dbDataSet
        '
        'Control_de_calificaciones_dbDataSet
        '
        Me.Control_de_calificaciones_dbDataSet.DataSetName = "control_de_calificaciones_dbDataSet"
        Me.Control_de_calificaciones_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Grupo"
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
        Me.TableAdapterManager.CalificacionesTableAdapter = Me.CalificacionesTableAdapter
        Me.TableAdapterManager.GrupoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Control_de_alumnos.control_de_calificaciones_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CalificacionesTableAdapter
        '
        Me.CalificacionesTableAdapter.ClearBeforeFill = True
        '
        'CalificacionesBindingSource
        '
        Me.CalificacionesBindingSource.DataMember = "Calificaciones"
        Me.CalificacionesBindingSource.DataSource = Me.Control_de_calificaciones_dbDataSet
        '
        'ListBox1
        '
        Me.ListBox1.DataSource = Me.AlumnosBindingSource
        Me.ListBox1.DisplayMember = "Nombre"
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Location = New System.Drawing.Point(12, 74)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(250, 384)
        Me.ListBox1.TabIndex = 2
        Me.ListBox1.ValueMember = "Nombre"
        '
        'GrupoTableAdapter
        '
        Me.GrupoTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(180, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Materia"
        '
        'MATERIER
        '
        Me.MATERIER.DataSource = Me.MateriasBindingSource
        Me.MATERIER.DisplayMember = "Materia"
        Me.MATERIER.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MATERIER.FormattingEnabled = True
        Me.MATERIER.Location = New System.Drawing.Point(141, 45)
        Me.MATERIER.Name = "MATERIER"
        Me.MATERIER.Size = New System.Drawing.Size(121, 21)
        Me.MATERIER.TabIndex = 7
        Me.MATERIER.ValueMember = "Materia"
        '
        'MateriasBindingSource
        '
        Me.MateriasBindingSource.DataMember = "Materias"
        Me.MateriasBindingSource.DataSource = Me.Control_de_calificaciones_dbDataSet
        '
        'CalificacionesAlumnosBindingSource
        '
        Me.CalificacionesAlumnosBindingSource.DataMember = "Calificaciones_Alumnos"
        Me.CalificacionesAlumnosBindingSource.DataSource = Me.CalificacionesBindingSource
        '
        'MateriasTableAdapter
        '
        Me.MateriasTableAdapter.ClearBeforeFill = True
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape3, Me.LineShape2, Me.LineShape1, Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(910, 489)
        Me.ShapeContainer1.TabIndex = 8
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape3
        '
        Me.LineShape3.BorderWidth = 4
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 328
        Me.LineShape3.X2 = 874
        Me.LineShape3.Y1 = 178
        Me.LineShape3.Y2 = 178
        '
        'LineShape2
        '
        Me.LineShape2.BorderWidth = 4
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 328
        Me.LineShape2.X2 = 874
        Me.LineShape2.Y1 = 145
        Me.LineShape2.Y2 = 145
        '
        'LineShape1
        '
        Me.LineShape1.BorderWidth = 4
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 328
        Me.LineShape1.X2 = 874
        Me.LineShape1.Y1 = 112
        Me.LineShape1.Y2 = 112
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BorderWidth = 4
        Me.RectangleShape1.Location = New System.Drawing.Point(327, 80)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(549, 377)
        '
        'MatriculaTextBox
        '
        Me.MatriculaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlumnosBindingSource, "Matricula", True))
        Me.MatriculaTextBox.Enabled = False
        Me.MatriculaTextBox.Location = New System.Drawing.Point(401, 50)
        Me.MatriculaTextBox.Name = "MatriculaTextBox"
        Me.MatriculaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MatriculaTextBox.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(356, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 23)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "NOMBRE:"
        '
        'nombreLabel
        '
        Me.nombreLabel.AutoSize = True
        Me.nombreLabel.BackColor = System.Drawing.Color.Transparent
        Me.nombreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombreLabel.Location = New System.Drawing.Point(454, 88)
        Me.nombreLabel.Name = "nombreLabel"
        Me.nombreLabel.Size = New System.Drawing.Size(256, 20)
        Me.nombreLabel.TabIndex = 10
        Me.nombreLabel.Text = "Seleccione algun alumno de la lista"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(353, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 23)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "MATERIA:"
        '
        'materiaLabel
        '
        Me.materiaLabel.AutoSize = True
        Me.materiaLabel.BackColor = System.Drawing.Color.Transparent
        Me.materiaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.materiaLabel.Location = New System.Drawing.Point(454, 120)
        Me.materiaLabel.Name = "materiaLabel"
        Me.materiaLabel.Size = New System.Drawing.Size(256, 20)
        Me.materiaLabel.TabIndex = 12
        Me.materiaLabel.Text = "Seleccione algun alumno de la lista"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(FullNameLabel)
        Me.GroupBox1.Controls.Add(Me.Nombre_de_la_unidadTextBox)
        Me.GroupBox1.Controls.Add(Numero_de_la_unidadLabel)
        Me.GroupBox1.Controls.Add(Me.Numero_de_la_unidadTextBox)
        Me.GroupBox1.Controls.Add(CalificacionLabel)
        Me.GroupBox1.Controls.Add(Me.CalificacionTextBox)
        Me.GroupBox1.Controls.Add(PorcentajeLabel1)
        Me.GroupBox1.Controls.Add(Me.PorcentajeTextBox1)
        Me.GroupBox1.Controls.Add(Numero_de_subLabel)
        Me.GroupBox1.Controls.Add(Me.Numero_de_subTextBox)
        Me.GroupBox1.Controls.Add(PorcentajeLabel)
        Me.GroupBox1.Controls.Add(Me.PorcentajeTextBox)
        Me.GroupBox1.Controls.Add(Nombre_de_la_unidadLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(921, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(334, 458)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'Nombre_de_la_unidadTextBox
        '
        Me.Nombre_de_la_unidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UnidadesBindingSource, "FullName", True))
        Me.Nombre_de_la_unidadTextBox.Location = New System.Drawing.Point(81, 33)
        Me.Nombre_de_la_unidadTextBox.Name = "Nombre_de_la_unidadTextBox"
        Me.Nombre_de_la_unidadTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Nombre_de_la_unidadTextBox.TabIndex = 13
        '
        'UnidadesBindingSource
        '
        Me.UnidadesBindingSource.DataMember = "Unidades"
        Me.UnidadesBindingSource.DataSource = Me.Control_de_calificaciones_dbDataSet
        '
        'Numero_de_la_unidadTextBox
        '
        Me.Numero_de_la_unidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UnidadesBindingSource, "Numero de la unidad", True))
        Me.Numero_de_la_unidadTextBox.Location = New System.Drawing.Point(155, 117)
        Me.Numero_de_la_unidadTextBox.Name = "Numero_de_la_unidadTextBox"
        Me.Numero_de_la_unidadTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Numero_de_la_unidadTextBox.TabIndex = 11
        '
        'CalificacionTextBox
        '
        Me.CalificacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CalificacionesBindingSource, "Calificacion", True))
        Me.CalificacionTextBox.Location = New System.Drawing.Point(6, 317)
        Me.CalificacionTextBox.Name = "CalificacionTextBox"
        Me.CalificacionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CalificacionTextBox.TabIndex = 9
        '
        'PorcentajeTextBox1
        '
        Me.PorcentajeTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sub_unidadBindingSource, "Porcentaje", True))
        Me.PorcentajeTextBox1.Location = New System.Drawing.Point(6, 229)
        Me.PorcentajeTextBox1.Name = "PorcentajeTextBox1"
        Me.PorcentajeTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.PorcentajeTextBox1.TabIndex = 7
        '
        'Sub_unidadBindingSource
        '
        Me.Sub_unidadBindingSource.DataMember = "Sub unidad"
        Me.Sub_unidadBindingSource.DataSource = Me.Control_de_calificaciones_dbDataSet
        '
        'Numero_de_subTextBox
        '
        Me.Numero_de_subTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sub_unidadBindingSource, "Numero de sub", True))
        Me.Numero_de_subTextBox.Location = New System.Drawing.Point(6, 190)
        Me.Numero_de_subTextBox.Name = "Numero_de_subTextBox"
        Me.Numero_de_subTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Numero_de_subTextBox.TabIndex = 5
        '
        'PorcentajeTextBox
        '
        Me.PorcentajeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UnidadesBindingSource, "Porcentaje", True))
        Me.PorcentajeTextBox.Location = New System.Drawing.Point(16, 71)
        Me.PorcentajeTextBox.Name = "PorcentajeTextBox"
        Me.PorcentajeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PorcentajeTextBox.TabIndex = 3
        '
        'UnidadesTableAdapter
        '
        Me.UnidadesTableAdapter.ClearBeforeFill = True
        '
        'CalificacionesBindingSource1
        '
        Me.CalificacionesBindingSource1.DataMember = "Calificaciones"
        Me.CalificacionesBindingSource1.DataSource = Me.Control_de_calificaciones_dbDataSet
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(354, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(262, 23)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "AVANCE ACUMULADO FINAL:"
        '
        'avanceLabel
        '
        Me.avanceLabel.AutoSize = True
        Me.avanceLabel.BackColor = System.Drawing.Color.Transparent
        Me.avanceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.avanceLabel.Location = New System.Drawing.Point(618, 152)
        Me.avanceLabel.Name = "avanceLabel"
        Me.avanceLabel.Size = New System.Drawing.Size(256, 20)
        Me.avanceLabel.TabIndex = 16
        Me.avanceLabel.Text = "Seleccione algun alumno de la lista"
        '
        'Sub_unidadTableAdapter
        '
        Me.Sub_unidadTableAdapter.ClearBeforeFill = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarToolStripMenuItem, Me.ActualizarToolStripMenuItem, Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(910, 24)
        Me.MenuStrip1.TabIndex = 17
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CerrarToolStripMenuItem
        '
        Me.CerrarToolStripMenuItem.BackColor = System.Drawing.Color.Red
        Me.CerrarToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CerrarToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.CerrarToolStripMenuItem.Name = "CerrarToolStripMenuItem"
        Me.CerrarToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.CerrarToolStripMenuItem.Text = "Cerrar"
        '
        'ActualizarToolStripMenuItem
        '
        Me.ActualizarToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ActualizarToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActualizarToolStripMenuItem.Name = "ActualizarToolStripMenuItem"
        Me.ActualizarToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.ActualizarToolStripMenuItem.Text = "Actualizar"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IrACapturaDeCalificacionesToolStripMenuItem, Me.IrAConfiguracionToolStripMenuItem, Me.IrAGraficasToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'IrACapturaDeCalificacionesToolStripMenuItem
        '
        Me.IrACapturaDeCalificacionesToolStripMenuItem.Name = "IrACapturaDeCalificacionesToolStripMenuItem"
        Me.IrACapturaDeCalificacionesToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.IrACapturaDeCalificacionesToolStripMenuItem.Text = "Ir a captura de calificaciones"
        '
        'IrAConfiguracionToolStripMenuItem
        '
        Me.IrAConfiguracionToolStripMenuItem.Name = "IrAConfiguracionToolStripMenuItem"
        Me.IrAConfiguracionToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.IrAConfiguracionToolStripMenuItem.Text = "Ir a configuracion"
        '
        'IrAGraficasToolStripMenuItem
        '
        Me.IrAGraficasToolStripMenuItem.Name = "IrAGraficasToolStripMenuItem"
        Me.IrAGraficasToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.IrAGraficasToolStripMenuItem.Text = "Ir a graficas"
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(339, 197)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(521, 250)
        Me.WebBrowser1.TabIndex = 19
        '
        'Revicion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(910, 489)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(MatriculaLabel)
        Me.Controls.Add(Me.MatriculaTextBox)
        Me.Controls.Add(Me.avanceLabel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.materiaLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.nombreLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.MATERIER)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Revicion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Revicion"
        CType(Me.GrupoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Control_de_calificaciones_dbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlumnosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CalificacionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MateriasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CalificacionesAlumnosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.UnidadesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sub_unidadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CalificacionesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Control_de_calificaciones_dbDataSet As Control_de_alumnos.control_de_calificaciones_dbDataSet
    Friend WithEvents AlumnosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AlumnosTableAdapter As Control_de_alumnos.control_de_calificaciones_dbDataSetTableAdapters.AlumnosTableAdapter
    Friend WithEvents TableAdapterManager As Control_de_alumnos.control_de_calificaciones_dbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CalificacionesTableAdapter As Control_de_alumnos.control_de_calificaciones_dbDataSetTableAdapters.CalificacionesTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CalificacionesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents GrupoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GrupoTableAdapter As Control_de_alumnos.control_de_calificaciones_dbDataSetTableAdapters.GrupoTableAdapter
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MATERIER As System.Windows.Forms.ComboBox
    Friend WithEvents CalificacionesAlumnosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MateriasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MateriasTableAdapter As Control_de_alumnos.control_de_calificaciones_dbDataSetTableAdapters.MateriasTableAdapter
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents nombreLabel As System.Windows.Forms.Label
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents materiaLabel As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents UnidadesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UnidadesTableAdapter As Control_de_alumnos.control_de_calificaciones_dbDataSetTableAdapters.UnidadesTableAdapter
    Friend WithEvents PorcentajeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CalificacionesBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents avanceLabel As System.Windows.Forms.Label
    Friend WithEvents Sub_unidadBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sub_unidadTableAdapter As Control_de_alumnos.control_de_calificaciones_dbDataSetTableAdapters.Sub_unidadTableAdapter
    Friend WithEvents PorcentajeTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Numero_de_subTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CalificacionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MatriculaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CerrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActualizarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IrACapturaDeCalificacionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IrAConfiguracionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IrAGraficasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Numero_de_la_unidadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Nombre_de_la_unidadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
