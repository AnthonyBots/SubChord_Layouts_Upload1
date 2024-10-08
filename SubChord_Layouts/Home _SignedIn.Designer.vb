<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
		TextBox1 = New TextBox()
		DataGridView1 = New DataGridView()
		Week_1 = New DataGridViewTextBoxColumn()
		Week_2 = New DataGridViewTextBoxColumn()
		Week_3 = New DataGridViewTextBoxColumn()
		Week_4 = New DataGridViewTextBoxColumn()
		Week_5 = New DataGridViewTextBoxColumn()
		TextBox2 = New TextBox()
		Button2 = New Button()
		Button1 = New Button()
		Button3 = New Button()
		Button4 = New Button()
		ComboBox1 = New ComboBox()
		Button5 = New Button()
		TextBox4 = New TextBox()
		GroupBox1 = New GroupBox()
		CheckBox1 = New CheckBox()
		CheckBox2 = New CheckBox()
		CheckBox3 = New CheckBox()
		CheckBox4 = New CheckBox()
		CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
		GroupBox1.SuspendLayout()
		SuspendLayout()
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
		DataGridView1.Location = New Point(44, 77)
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
		TextBox2.Location = New Point(778, 91)
		TextBox2.Name = "TextBox2"
		TextBox2.Size = New Size(174, 27)
		TextBox2.TabIndex = 5
		TextBox2.Text = "-Start display with Friday"
		' 
		' Button2
		' 
		Button2.Location = New Point(291, 529)
		Button2.Name = "Button2"
		Button2.Size = New Size(112, 29)
		Button2.TabIndex = 2
		Button2.Text = "Create Venue"
		Button2.UseVisualStyleBackColor = True
		' 
		' Button1
		' 
		Button1.Location = New Point(138, 529)
		Button1.Name = "Button1"
		Button1.Size = New Size(113, 29)
		Button1.TabIndex = 1
		Button1.Text = "Create Artist"
		Button1.UseVisualStyleBackColor = True
		' 
		' Button3
		' 
		Button3.Location = New Point(437, 529)
		Button3.Name = "Button3"
		Button3.Size = New Size(112, 29)
		Button3.TabIndex = 7
		Button3.Text = "Create Vendor"
		Button3.UseVisualStyleBackColor = True
		' 
		' Button4
		' 
		Button4.Location = New Point(610, 529)
		Button4.Name = "Button4"
		Button4.Size = New Size(112, 29)
		Button4.TabIndex = 8
		Button4.Text = "Create Event"
		Button4.UseVisualStyleBackColor = True
		' 
		' ComboBox1
		' 
		ComboBox1.FormattingEnabled = True
		ComboBox1.Location = New Point(343, 12)
		ComboBox1.Name = "ComboBox1"
		ComboBox1.Size = New Size(174, 28)
		ComboBox1.TabIndex = 9
		ComboBox1.Text = "Select Managed Page"
		' 
		' Button5
		' 
		Button5.Location = New Point(840, 12)
		Button5.Name = "Button5"
		Button5.Size = New Size(112, 29)
		Button5.TabIndex = 10
		Button5.Text = "Sign Out"
		Button5.UseVisualStyleBackColor = True
		' 
		' TextBox4
		' 
		TextBox4.Location = New Point(778, 124)
		TextBox4.Name = "TextBox4"
		TextBox4.Size = New Size(174, 27)
		TextBox4.TabIndex = 11
		TextBox4.Text = "7x5 table"
		' 
		' GroupBox1
		' 
		GroupBox1.Controls.Add(CheckBox4)
		GroupBox1.Controls.Add(CheckBox3)
		GroupBox1.Controls.Add(CheckBox2)
		GroupBox1.Controls.Add(CheckBox1)
		GroupBox1.Location = New Point(763, 224)
		GroupBox1.Name = "GroupBox1"
		GroupBox1.Size = New Size(189, 147)
		GroupBox1.TabIndex = 12
		GroupBox1.TabStop = False
		GroupBox1.Text = "GroupBox1"
		' 
		' CheckBox1
		' 
		CheckBox1.AutoSize = True
		CheckBox1.Location = New Point(6, 23)
		CheckBox1.Name = "CheckBox1"
		CheckBox1.Size = New Size(133, 24)
		CheckBox1.TabIndex = 0
		CheckBox1.Text = "Seeking Venues"
		CheckBox1.UseVisualStyleBackColor = True
		' 
		' CheckBox2
		' 
		CheckBox2.AutoSize = True
		CheckBox2.Location = New Point(6, 53)
		CheckBox2.Name = "CheckBox2"
		CheckBox2.Size = New Size(128, 24)
		CheckBox2.TabIndex = 1
		CheckBox2.Text = "Seeking Artists"
		CheckBox2.UseVisualStyleBackColor = True
		' 
		' CheckBox3
		' 
		CheckBox3.AutoSize = True
		CheckBox3.Location = New Point(6, 83)
		CheckBox3.Name = "CheckBox3"
		CheckBox3.Size = New Size(140, 24)
		CheckBox3.TabIndex = 2
		CheckBox3.Text = "Seeking Vendors"
		CheckBox3.UseVisualStyleBackColor = True
		' 
		' CheckBox4
		' 
		CheckBox4.AutoSize = True
		CheckBox4.Location = New Point(6, 113)
		CheckBox4.Name = "CheckBox4"
		CheckBox4.Size = New Size(128, 24)
		CheckBox4.TabIndex = 3
		CheckBox4.Text = "Booked Events"
		CheckBox4.UseVisualStyleBackColor = True
		' 
		' Form1
		' 
		AutoScaleDimensions = New SizeF(8F, 20F)
		AutoScaleMode = AutoScaleMode.Font
		ClientSize = New Size(964, 631)
		Controls.Add(GroupBox1)
		Controls.Add(TextBox4)
		Controls.Add(Button5)
		Controls.Add(ComboBox1)
		Controls.Add(Button4)
		Controls.Add(Button3)
		Controls.Add(TextBox2)
		Controls.Add(DataGridView1)
		Controls.Add(TextBox1)
		Controls.Add(Button2)
		Controls.Add(Button1)
		Name = "Form1"
		Text = "Home"
		CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
		GroupBox1.ResumeLayout(False)
		GroupBox1.PerformLayout()
		ResumeLayout(False)
		PerformLayout()
	End Sub
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents DataGridView1 As DataGridView
	Friend WithEvents Week_1 As DataGridViewTextBoxColumn
	Friend WithEvents Week_2 As DataGridViewTextBoxColumn
	Friend WithEvents Week_3 As DataGridViewTextBoxColumn
	Friend WithEvents Week_4 As DataGridViewTextBoxColumn
	Friend WithEvents Week_5 As DataGridViewTextBoxColumn
	Friend WithEvents TextBox2 As TextBox
	Friend WithEvents Button2 As Button
	Friend WithEvents Button1 As Button
	Friend WithEvents Button3 As Button
	Friend WithEvents Button4 As Button
	Friend WithEvents ComboBox1 As ComboBox
	Friend WithEvents Button5 As Button
	Friend WithEvents TextBox4 As TextBox
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents CheckBox4 As CheckBox
	Friend WithEvents CheckBox3 As CheckBox
	Friend WithEvents CheckBox2 As CheckBox
	Friend WithEvents CheckBox1 As CheckBox

End Class
