Imports System

Namespace Homework3._1_CSharp
    Partial Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <paramname="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            components = New ComponentModel.Container()
            button1 = New Windows.Forms.Button()
            timer1 = New Windows.Forms.Timer(components)
            label1 = New Windows.Forms.Label()
            button2 = New Windows.Forms.Button()
            button3 = New Windows.Forms.Button()
            label2 = New Windows.Forms.Label()
            label3 = New Windows.Forms.Label()
            label4 = New Windows.Forms.Label()
            button4 = New Windows.Forms.Button()
            pictureBox1 = New MyPictureBox(components)
            CType(pictureBox1, ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' button1
            ' 
            button1.Location = New Drawing.Point(12, 336)
            button1.Margin = New Windows.Forms.Padding(3, 2, 3, 2)
            button1.Name = "button1"
            button1.Size = New Drawing.Size(116, 37)
            button1.TabIndex = 0
            button1.Text = "Load CSV"
            button1.UseVisualStyleBackColor = True
            AddHandler button1.Click, New EventHandler(AddressOf button1_Click)
            ' 
            ' timer1
            ' 
            AddHandler timer1.Tick, New EventHandler(AddressOf timer1_Tick)
            ' 
            ' label1
            ' 
            label1.AutoSize = True
            label1.Location = New Drawing.Point(556, 9)
            label1.Name = "label1"
            label1.Size = New Drawing.Size(74, 17)
            label1.TabIndex = 2
            label1.Text = "Mean: N/A"
            ' 
            ' button2
            ' 
            button2.Location = New Drawing.Point(149, 336)
            button2.Margin = New Windows.Forms.Padding(3, 2, 3, 2)
            button2.Name = "button2"
            button2.Size = New Drawing.Size(125, 37)
            button2.TabIndex = 3
            button2.Text = "Mean"
            button2.UseVisualStyleBackColor = True
            AddHandler button2.Click, New EventHandler(AddressOf button2_Click)
            ' 
            ' button3
            ' 
            button3.Location = New Drawing.Point(289, 336)
            button3.Margin = New Windows.Forms.Padding(3, 2, 3, 2)
            button3.Name = "button3"
            button3.Size = New Drawing.Size(125, 37)
            button3.TabIndex = 4
            button3.Text = "Deviation"
            button3.UseVisualStyleBackColor = True
            AddHandler button3.Click, New EventHandler(AddressOf button3_Click)
            ' 
            ' label2
            ' 
            label2.AutoSize = True
            label2.Location = New Drawing.Point(556, 35)
            label2.Name = "label2"
            label2.Size = New Drawing.Size(98, 17)
            label2.TabIndex = 5
            label2.Text = "Deviation: N/A"
            ' 
            ' label3
            ' 
            label3.AutoSize = True
            label3.Location = New Drawing.Point(556, 63)
            label3.Name = "label3"
            label3.Size = New Drawing.Size(106, 17)
            label3.TabIndex = 6
            label3.Text = "Males 3+ GPA: "
            ' 
            ' label4
            ' 
            label4.AutoSize = True
            label4.Location = New Drawing.Point(556, 90)
            label4.Name = "label4"
            label4.Size = New Drawing.Size(122, 17)
            label4.TabIndex = 7
            label4.Text = "Females 3+ GPA: "
            ' 
            ' button4
            ' 
            button4.Location = New Drawing.Point(425, 336)
            button4.Margin = New Windows.Forms.Padding(3, 2, 3, 2)
            button4.Name = "button4"
            button4.Size = New Drawing.Size(125, 37)
            button4.TabIndex = 8
            button4.Text = "Frequency"
            button4.UseVisualStyleBackColor = True
            AddHandler button4.Click, New EventHandler(AddressOf button4_Click)
            ' 
            ' pictureBox1
            ' 
            pictureBox1.Location = New Drawing.Point(0, 0)
            pictureBox1.Margin = New Windows.Forms.Padding(3, 2, 3, 2)
            pictureBox1.Name = "pictureBox1"
            pictureBox1.Size = New Drawing.Size(550, 332)
            pictureBox1.SizeMode = Windows.Forms.PictureBoxSizeMode.StretchImage
            pictureBox1.TabIndex = 1
            pictureBox1.TabStop = False
            ' 
            ' Form1
            ' 
            AutoScaleDimensions = New Drawing.SizeF(8.0F, 16.0F)
            AutoScaleMode = Windows.Forms.AutoScaleMode.Font
            ClientSize = New Drawing.Size(711, 384)
            Controls.Add(button4)
            Controls.Add(label4)
            Controls.Add(label3)
            Controls.Add(label2)
            Controls.Add(button3)
            Controls.Add(button2)
            Controls.Add(label1)
            Controls.Add(pictureBox1)
            Controls.Add(button1)
            Margin = New Windows.Forms.Padding(3, 2, 3, 2)
            Name = "Form1"
            Text = "GPA Analyzer"
            CType(pictureBox1, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()
        End Sub

#End Region

        Private button1 As Windows.Forms.Button
        Private pictureBox1 As MyPictureBox
        Private timer1 As Windows.Forms.Timer
        Private label1 As Windows.Forms.Label
        Private button2 As Windows.Forms.Button
        Private button3 As Windows.Forms.Button
        Private label2 As Windows.Forms.Label
        Private label3 As Windows.Forms.Label
        Private label4 As Windows.Forms.Label
        Private button4 As Windows.Forms.Button
    End Class
End Namespace
