﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateLastTransactionID
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
        Me.txtCreatedTransactionID = New System.Windows.Forms.TextBox()
        Me.cboTransactionID = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'txtCreatedTransactionID
        '
        Me.txtCreatedTransactionID.Location = New System.Drawing.Point(27, 69)
        Me.txtCreatedTransactionID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCreatedTransactionID.Name = "txtCreatedTransactionID"
        Me.txtCreatedTransactionID.Size = New System.Drawing.Size(160, 22)
        Me.txtCreatedTransactionID.TabIndex = 7
        '
        'cboTransactionID
        '
        Me.cboTransactionID.FormattingEnabled = True
        Me.cboTransactionID.Location = New System.Drawing.Point(27, 22)
        Me.cboTransactionID.Margin = New System.Windows.Forms.Padding(4)
        Me.cboTransactionID.Name = "cboTransactionID"
        Me.cboTransactionID.Size = New System.Drawing.Size(160, 24)
        Me.cboTransactionID.TabIndex = 6
        '
        'CreateLastTransactionID
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(220, 126)
        Me.Controls.Add(Me.txtCreatedTransactionID)
        Me.Controls.Add(Me.cboTransactionID)
        Me.Name = "CreateLastTransactionID"
        Me.Text = "CreateLastTransactionID"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCreatedTransactionID As System.Windows.Forms.TextBox
    Friend WithEvents cboTransactionID As System.Windows.Forms.ComboBox
End Class
