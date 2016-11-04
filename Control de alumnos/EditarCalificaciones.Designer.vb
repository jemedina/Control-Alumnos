<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditarCalificaciones
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
        Dim CalificacionLabel As System.Windows.Forms.Label
        Me.grupo = New System.Windows.Forms.ComboBox()
        Me.GrupoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Control_de_calificaciones_dbDataSet = New Control_de_alumnos.control_de_calificaciones_dbDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.materia = New System.Windows.Forms.ComboBox()
        Me.MateriasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.unid = New System.Windows.Forms.ComboBox()
        Me.UnidadesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SubUnidadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ControldecalificacionesdbDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.alumno = New System.Windows.Forms.ComboBox()
        Me.AlumnosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GrupoTableAdapter = New Control_de_alumnos.control_de_calificaciones_dbDataSetTableAdapters.GrupoTableAdapter()
        Me.AlumnosTableAdapter = New Control_de_alumnos.control_de_calificaciones_dbDataSetTableAdapters.AlumnosTableAdapter()
        Me.MateriasTableAdapter = New Control_de_alumnos.control_de_calificaciones_dbDataSetTableAdapters.MateriasTableAdapter()
        Me.UnidadesTableAdapter = New Control_de_alumnos.control_de_calificaciones_dbDataSetTableAdapters.UnidadesTableAdapter()
        Me.Sub_unidadTableAdapter = New Control_de_alumnos.control_de_calificaciones_dbDataSetTableAdapters.Sub_unidadTableAdapter()
        Me.TableAdapterManager = New Control_de_alumnos.control_de_calificaciones_dbDataSetTableAdapters.TableAdapterManager()
        Me.Sub_unidadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MatriculaTextBox = New System.Windows.Forms.TextBox()
        Me.CalificacionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CalificacionesTableAdapter = New Control_de_alumnos.control_de_calificaciones_dbDataSetTableAdapters.CalificacionesTableAdapter()
        Me.CalificacionTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.subunid = New System.Windows.Forms.ComboBox()
        Me.FullNameTextBox = New System.Windows.Forms.TextBox()
        Me.AlumnosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CalificacionLabel = New System.Windows.Forms.Label()
        CType(Me.GrupoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Control_de_calificaciones_dbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MateriasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnidadesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubUnidadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ControldecalificacionesdbDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlumnosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sub_unidadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CalificacionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlumnosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CalificacionLabel
        '
        CalificacionLabel.AutoSize = True
        CalificacionLabel.Location = New System.Drawing.Point(4, 159)
        CalificacionLabel.Name = "CalificacionLabel"
        CalificacionLabel.Size = New System.Drawing.Size(64, 13)
        CalificacionLabel.TabIndex = 18
        CalificacionLabel.Text = "Calificacion:"
        '
        'grupo
        '
        Me.grupo.DataSource = Me.GrupoBindingSource
        Me.grupo.DisplayMember = "Nro de grupo"
        Me.grupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.grupo.FormattingEnabled = True
        Me.grupo.Location = New System.Drawing.Point(53, 17)
        Me.grupo.Name = "grupo"
        Me.grupo.Size = New System.Drawing.Size(121, 21)
        Me.grupo.TabIndex = 0
        Me.grupo.ValueMember = "Nro de grupo"
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
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Grupo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(198, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Materia:"
        '
        'materia
        '
        Me.materia.DataSource = Me.MateriasBindingSource
        Me.materia.DisplayMember = "Materia"
        Me.materia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.materia.FormattingEnabled = True
        Me.materia.Location = New System.Drawing.Point(249, 17)
        Me.materia.Name = "materia"
        Me.materia.Size = New System.Drawing.Size(498, 21)
        Me.materia.TabIndex = 2
        Me.materia.ValueMember = "Materia"
        '
        'MateriasBindingSource
        '
        Me.MateriasBindingSource.DataMember = "Materias"
        Me.MateriasBindingSource.DataSource = Me.Control_de_calificaciones_dbDataSet
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Unidad:"
        '
        'unid
        '
        Me.unid.DataSource = Me.UnidadesBindingSource
        Me.unid.DisplayMember = "Numero de la unidad"
        Me.unid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.unid.FormattingEnabled = True
        Me.unid.Location = New System.Drawing.Point(62, 63)
        Me.unid.Name = "unid"
        Me.unid.Size = New System.Drawing.Size(112, 21)
        Me.unid.TabIndex = 4
        Me.unid.ValueMember = "Numero de la unidad"
        '
        'UnidadesBindingSource
        '
        Me.UnidadesBindingSource.DataMember = "Unidades"
        Me.UnidadesBindingSource.DataSource = Me.Control_de_calificaciones_dbDataSet
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(195, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Sub unidad:"
        '
        'SubUnidadBindingSource
        '
        Me.SubUnidadBindingSource.DataMember = "Sub unidad"
        Me.SubUnidadBindingSource.DataSource = Me.ControldecalificacionesdbDataSetBindingSource
        '
        'ControldecalificacionesdbDataSetBindingSource
        '
        Me.ControldecalificacionesdbDataSetBindingSource.DataSource = Me.Control_de_calificaciones_dbDataSet
        Me.ControldecalificacionesdbDataSetBindingSource.Position = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Alumno:"
        '
        'alumno
        '
        Me.alumno.DataSource = Me.AlumnosBindingSource
        Me.alumno.DisplayMember = "Nombre"
        Me.alumno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.alumno.FormattingEnabled = True
        Me.alumno.Location = New System.Drawing.Point(62, 104)
        Me.alumno.Name = "alumno"
        Me.alumno.Size = New System.Drawing.Size(498, 21)
        Me.alumno.TabIndex = 9
        Me.alumno.ValueMember = "Nombre"
        '
        'AlumnosBindingSource
        '
        Me.AlumnosBindingSource.DataMember = "Alumnos"
        Me.AlumnosBindingSource.DataSource = Me.Control_de_calificaciones_dbDataSet
        '
        'GrupoTableAdapter
        '
        Me.GrupoTableAdapter.ClearBeforeFill = True
        '
        'AlumnosTableAdapter
        '
        Me.AlumnosTableAdapter.ClearBeforeFill = True
        '
        'MateriasTableAdapter
        '
        Me.MateriasTableAdapter.ClearBeforeFill = True
        '
        'UnidadesTableAdapter
        '
        Me.UnidadesTableAdapter.ClearBeforeFill = True
        '
        'Sub_unidadTableAdapter
        '
        Me.Sub_unidadTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AlumnosTableAdapter = Me.AlumnosTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CalificacionesTableAdapter = Nothing
        Me.TableAdapterManager.GrupoTableAdapter = Me.GrupoTableAdapter
        Me.TableAdapterManager.UpdateOrder = Control_de_alumnos.control_de_calificaciones_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Sub_unidadBindingSource
        '
        Me.Sub_unidadBindingSource.DataMember = "Sub unidad"
        Me.Sub_unidadBindingSource.DataSource = Me.Control_de_calificaciones_dbDataSet
        '
        'MatriculaTextBox
        '
        Me.MatriculaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlumnosBindingSource, "Matricula", True))
        Me.MatriculaTextBox.Enabled = False
        Me.MatriculaTextBox.Location = New System.Drawing.Point(829, 104)
        Me.MatriculaTextBox.Name = "MatriculaTextBox"
        Me.MatriculaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MatriculaTextBox.TabIndex = 17
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
        Me.CalificacionTextBox.BackColor = System.Drawing.Color.White
        Me.CalificacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CalificacionesBindingSource, "Calificacion", True))
        Me.CalificacionTextBox.Enabled = False
        Me.CalificacionTextBox.Location = New System.Drawing.Point(74, 156)
        Me.CalificacionTextBox.Name = "CalificacionTextBox"
        Me.CalificacionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CalificacionTextBox.TabIndex = 19
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(214, 156)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(163, 50)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Modificar esta calificacion"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'subunid
        '
        Me.subunid.DataSource = Me.SubUnidadBindingSource
        Me.subunid.DisplayMember = "Numero de sub"
        Me.subunid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.subunid.FormattingEnabled = True
        Me.subunid.Location = New System.Drawing.Point(265, 63)
        Me.subunid.Name = "subunid"
        Me.subunid.Size = New System.Drawing.Size(112, 21)
        Me.subunid.TabIndex = 21
        Me.subunid.ValueMember = "Numero de sub"
        '
        'FullNameTextBox
        '
        Me.FullNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UnidadesBindingSource, "FullName", True))
        Me.FullNameTextBox.Enabled = False
        Me.FullNameTextBox.Location = New System.Drawing.Point(829, 59)
        Me.FullNameTextBox.Name = "FullNameTextBox"
        Me.FullNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FullNameTextBox.TabIndex = 22
        '
        'AlumnosBindingSource1
        '
        Me.AlumnosBindingSource1.DataMember = "Calificaciones_Alumnos"
        Me.AlumnosBindingSource1.DataSource = Me.CalificacionesBindingSource
        '
        'EditarCalificaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(749, 230)
        Me.Controls.Add(Me.FullNameTextBox)
        Me.Controls.Add(Me.subunid)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(CalificacionLabel)
        Me.Controls.Add(Me.CalificacionTextBox)
        Me.Controls.Add(Me.MatriculaTextBox)
        Me.Controls.Add(Me.alumno)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.unid)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.materia)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grupo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EditarCalificaciones"
        Me.Text = "Editar Calificaciones"
        CType(Me.GrupoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Control_de_calificaciones_dbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MateriasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnidadesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubUnidadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ControldecalificacionesdbDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlumnosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sub_unidadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CalificacionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlumnosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grupo As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents materia As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents unid As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents alumno As System.Windows.Forms.ComboBox
    Friend WithEvents Control_de_calificaciones_dbDataSet As Control_de_alumnos.control_de_calificaciones_dbDataSet
    Friend WithEvents GrupoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GrupoTableAdapter As Control_de_alumnos.control_de_calificaciones_dbDataSetTableAdapters.GrupoTableAdapter
    Friend WithEvents AlumnosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AlumnosTableAdapter As Control_de_alumnos.control_de_calificaciones_dbDataSetTableAdapters.AlumnosTableAdapter
    Friend WithEvents MateriasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MateriasTableAdapter As Control_de_alumnos.control_de_calificaciones_dbDataSetTableAdapters.MateriasTableAdapter
    Friend WithEvents UnidadesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UnidadesTableAdapter As Control_de_alumnos.control_de_calificaciones_dbDataSetTableAdapters.UnidadesTableAdapter
    Friend WithEvents ControldecalificacionesdbDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SubUnidadBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sub_unidadTableAdapter As Control_de_alumnos.control_de_calificaciones_dbDataSetTableAdapters.Sub_unidadTableAdapter
    Friend WithEvents TableAdapterManager As Control_de_alumnos.control_de_calificaciones_dbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Sub_unidadBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MatriculaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CalificacionesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CalificacionesTableAdapter As Control_de_alumnos.control_de_calificaciones_dbDataSetTableAdapters.CalificacionesTableAdapter
    Friend WithEvents CalificacionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents subunid As System.Windows.Forms.ComboBox
    Friend WithEvents FullNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AlumnosBindingSource1 As System.Windows.Forms.BindingSource
End Class
