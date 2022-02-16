<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Balancebtl = New System.Windows.Forms.Button()
        Me.BankAssetbtl = New System.Windows.Forms.Button()
        Me.BalanceUnderbtl = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Balancebtl
        '
        Me.Balancebtl.Location = New System.Drawing.Point(109, 39)
        Me.Balancebtl.Name = "Balancebtl"
        Me.Balancebtl.Size = New System.Drawing.Size(181, 77)
        Me.Balancebtl.TabIndex = 0
        Me.Balancebtl.Text = "Show Balance"
        Me.Balancebtl.UseVisualStyleBackColor = True
        '
        'BankAssetbtl
        '
        Me.BankAssetbtl.Location = New System.Drawing.Point(110, 144)
        Me.BankAssetbtl.Name = "BankAssetbtl"
        Me.BankAssetbtl.Size = New System.Drawing.Size(180, 83)
        Me.BankAssetbtl.TabIndex = 1
        Me.BankAssetbtl.Text = "Show Bank Assets"
        Me.BankAssetbtl.UseVisualStyleBackColor = True
        '
        'BalanceUnderbtl
        '
        Me.BalanceUnderbtl.Location = New System.Drawing.Point(110, 257)
        Me.BalanceUnderbtl.Name = "BalanceUnderbtl"
        Me.BalanceUnderbtl.Size = New System.Drawing.Size(179, 81)
        Me.BalanceUnderbtl.TabIndex = 2
        Me.BalanceUnderbtl.Text = "Show Balance Under $500"
        Me.BalanceUnderbtl.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 389)
        Me.Controls.Add(Me.BalanceUnderbtl)
        Me.Controls.Add(Me.BankAssetbtl)
        Me.Controls.Add(Me.Balancebtl)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Balancebtl As Button
    Friend WithEvents BankAssetbtl As Button
    Friend WithEvents BalanceUnderbtl As Button
End Class
