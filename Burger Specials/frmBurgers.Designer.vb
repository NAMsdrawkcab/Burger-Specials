<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBurgers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBurgers))
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.lblConfirmation = New System.Windows.Forms.Label()
        Me.btnPrime = New System.Windows.Forms.Button()
        Me.btnSelectMeal = New System.Windows.Forms.Button()
        Me.btnVeggie = New System.Windows.Forms.Button()
        Me.picPrime = New System.Windows.Forms.PictureBox()
        Me.picVeggie = New System.Windows.Forms.PictureBox()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.picPrime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picVeggie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblHeading.ForeColor = System.Drawing.Color.Red
        Me.lblHeading.Location = New System.Drawing.Point(239, 34)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(304, 33)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Farm Burger Specials"
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblInstructions.Location = New System.Drawing.Point(211, 404)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(360, 18)
        Me.lblInstructions.TabIndex = 1
        Me.lblInstructions.Text = "Choose a burger and then click the Select Meal button"
        '
        'lblConfirmation
        '
        Me.lblConfirmation.AutoSize = True
        Me.lblConfirmation.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblConfirmation.Location = New System.Drawing.Point(305, 433)
        Me.lblConfirmation.Name = "lblConfirmation"
        Me.lblConfirmation.Size = New System.Drawing.Size(172, 18)
        Me.lblConfirmation.TabIndex = 2
        Me.lblConfirmation.Text = "Enjoy your burger special"
        Me.lblConfirmation.Visible = False
        '
        'btnPrime
        '
        Me.btnPrime.BackColor = System.Drawing.Color.Wheat
        Me.btnPrime.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnPrime.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnPrime.Location = New System.Drawing.Point(118, 354)
        Me.btnPrime.Name = "btnPrime"
        Me.btnPrime.Size = New System.Drawing.Size(128, 35)
        Me.btnPrime.TabIndex = 3
        Me.btnPrime.Text = "Prime Beef"
        Me.btnPrime.UseVisualStyleBackColor = False
        '
        'btnSelectMeal
        '
        Me.btnSelectMeal.BackColor = System.Drawing.Color.Wheat
        Me.btnSelectMeal.Enabled = False
        Me.btnSelectMeal.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnSelectMeal.Location = New System.Drawing.Point(327, 354)
        Me.btnSelectMeal.Name = "btnSelectMeal"
        Me.btnSelectMeal.Size = New System.Drawing.Size(128, 35)
        Me.btnSelectMeal.TabIndex = 4
        Me.btnSelectMeal.Text = "Select Meal"
        Me.btnSelectMeal.UseVisualStyleBackColor = False
        '
        'btnVeggie
        '
        Me.btnVeggie.BackColor = System.Drawing.Color.Wheat
        Me.btnVeggie.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnVeggie.Location = New System.Drawing.Point(536, 354)
        Me.btnVeggie.Name = "btnVeggie"
        Me.btnVeggie.Size = New System.Drawing.Size(128, 35)
        Me.btnVeggie.TabIndex = 5
        Me.btnVeggie.Text = "Veggie"
        Me.btnVeggie.UseVisualStyleBackColor = False
        '
        'picPrime
        '
        Me.picPrime.Image = CType(resources.GetObject("picPrime.Image"), System.Drawing.Image)
        Me.picPrime.Location = New System.Drawing.Point(52, 88)
        Me.picPrime.Name = "picPrime"
        Me.picPrime.Size = New System.Drawing.Size(260, 250)
        Me.picPrime.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPrime.TabIndex = 6
        Me.picPrime.TabStop = False
        Me.picPrime.Visible = False
        '
        'picVeggie
        '
        Me.picVeggie.Image = CType(resources.GetObject("picVeggie.Image"), System.Drawing.Image)
        Me.picVeggie.Location = New System.Drawing.Point(470, 88)
        Me.picVeggie.Name = "picVeggie"
        Me.picVeggie.Size = New System.Drawing.Size(260, 250)
        Me.picVeggie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picVeggie.TabIndex = 7
        Me.picVeggie.TabStop = False
        Me.picVeggie.Visible = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Wheat
        Me.btnExit.Enabled = False
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnExit.Location = New System.Drawing.Point(327, 468)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(128, 35)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit Window"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'frmBurgers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FloralWhite
        Me.ClientSize = New System.Drawing.Size(782, 543)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.picVeggie)
        Me.Controls.Add(Me.picPrime)
        Me.Controls.Add(Me.btnVeggie)
        Me.Controls.Add(Me.btnSelectMeal)
        Me.Controls.Add(Me.btnPrime)
        Me.Controls.Add(Me.lblConfirmation)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.lblHeading)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "frmBurgers"
        Me.Text = "Burger Specials"
        CType(Me.picPrime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picVeggie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents lblInstructions As Label
    Friend WithEvents lblConfirmation As Label
    Friend WithEvents btnPrime As Button
    Friend WithEvents btnSelectMeal As Button
    Friend WithEvents btnVeggie As Button
    Friend WithEvents picPrime As PictureBox
    Friend WithEvents picVeggie As PictureBox
    Friend WithEvents btnExit As Button
End Class
