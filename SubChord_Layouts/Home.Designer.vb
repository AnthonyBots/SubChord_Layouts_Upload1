<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
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
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Button1 = New Button()
		Button2 = New Button()
		TextBox1 = New TextBox()
		DataGridView1 = New DataGridView()
		Week_1 = New DataGridViewTextBoxColumn()
		Week_2 = New DataGridViewTextBoxColumn()
		Week_3 = New DataGridViewTextBoxColumn()
		Week_4 = New DataGridViewTextBoxColumn()
		Week_5 = New DataGridViewTextBoxColumn()
		TextBox2 = New TextBox()
		TextBox3 = New TextBox()
		CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
		SuspendLayout()
		' 
		' Button1
		' 
		Button1.Location = New Point(706, 12)
		Button1.Name = "Button1"
		Button1.Size = New Size(94, 29)
		Button1.TabIndex = 1
		Button1.Text = "Sign Up"
		Button1.UseVisualStyleBackColor = True
		' 
		' Button2
		' 
		Button2.Location = New Point(832, 10)
		Button2.Name = "Button2"
		Button2.Size = New Size(94, 29)
		Button2.TabIndex = 2
		Button2.Text = "Sign In"
		Button2.UseVisualStyleBackColor = True
		' 
		' TextBox1
		' 
		TextBox1.Location = New Point(12, 12)
		TextBox1.Name = "TextBox1"
		TextBox1.Size = New Size(55, 27)
		TextBox1.TabIndex = 3
		TextBox1.Text = "Logo"
		' 
		' DataGridView1
		' 
		DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
		DataGridView1.Columns.AddRange(New DataGridViewColumn() {Week_1, Week_2, Week_3, Week_4, Week_5})
		DataGridView1.Location = New Point(107, 112)
		DataGridView1.Name = "DataGridView1"
		DataGridView1.RowHeadersWidth = 51
		DataGridView1.Size = New Size(678, 397)
		DataGridView1.TabIndex = 4
		' 
		' Week_1
		' 
		Week_1.HeaderText = "Week 1"
		Week_1.MinimumWidth = 6
		Week_1.Name = "Week_1"
		Week_1.Width = 125
		' 
		' Week_2
		' 
		Week_2.HeaderText = "Week 2"
		Week_2.MinimumWidth = 6
		Week_2.Name = "Week_2"
		Week_2.Width = 125
		' 
		' Week_3
		' 
		Week_3.HeaderText = "Week 3"
		Week_3.MinimumWidth = 6
		Week_3.Name = "Week_3"
		Week_3.Width = 125
		' 
		' Week_4
		' 
		Week_4.HeaderText = "Week 4"
		Week_4.MinimumWidth = 6
		Week_4.Name = "Week_4"
		Week_4.Width = 125
		' 
		' Week_5
		' 
		Week_5.HeaderText = "Week 5"
		Week_5.MinimumWidth = 6
		Week_5.Name = "Week_5"
		Week_5.Width = 125
		' 
		' TextBox2
		' 
		TextBox2.Location = New Point(806, 141)
		TextBox2.Name = "TextBox2"
		TextBox2.Size = New Size(129, 27)
		TextBox2.TabIndex = 5
		TextBox2.Text = "-Start on Friday"
		' 
		' TextBox3
		' 
		TextBox3.Location = New Point(135, 79)
		TextBox3.Name = "TextBox3"
		TextBox3.Size = New Size(650, 27)
		TextBox3.TabIndex = 6
		TextBox3.Text = "Calendar Tabs for ""Booked"", ""Seeking Artists"", ""Seeking Venues"", 'Seeking Vendors'"
		' 
		' Home
		' 
		AutoScaleDimensions = New SizeF(8F, 20F)
		AutoScaleMode = AutoScaleMode.Font
		ClientSize = New Size(964, 631)
		Controls.Add(TextBox3)
		Controls.Add(TextBox2)
		Controls.Add(DataGridView1)
		Controls.Add(TextBox1)
		Controls.Add(Button2)
		Controls.Add(Button1)
		Name = "Home"
		Text = "Home"
		CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents Button1 As Button
	Friend WithEvents Button2 As Button
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents DataGridView1 As DataGridView
	Friend WithEvents Week_1 As DataGridViewTextBoxColumn
	Friend WithEvents Week_2 As DataGridViewTextBoxColumn
	Friend WithEvents Week_3 As DataGridViewTextBoxColumn
	Friend WithEvents Week_4 As DataGridViewTextBoxColumn
	Friend WithEvents Week_5 As DataGridViewTextBoxColumn
	Friend WithEvents TextBox2 As TextBox
	Friend WithEvents TextBox3 As TextBox

End Class
