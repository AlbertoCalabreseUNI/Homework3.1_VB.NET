Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Windows.Forms

Namespace Homework3._1_CSharp
    Public Partial Class Form1
        Inherits Form

        Public sample As IEnumerable(Of Student)
        Public gpaList As List(Of Double)
        Private timer As Timer = New Timer()
        Public rectangles As List(Of MyRectangle)
        Private random As Random = New Random()
        Public mean As Double = 0
        Public deviation As Double = 0
        Public n As Integer = 0

        Public Sub New()
            InitializeComponent()
            SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.DoubleBuffer, True)
            MyBase.DoubleBuffered = True
            UpdateStyles()
            sample = Nothing
            rectangles = New List(Of MyRectangle)()
            gpaList = New List(Of Double)()
            AddHandler pictureBox1.Paint, New PaintEventHandler(AddressOf pictureBox1_Paint)
            Controls.Add(pictureBox1)
            AddHandler timer.Tick, New EventHandler(AddressOf timer1_Tick)
            timer.Interval = 50
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs)
            sample = File.ReadAllLines("CSV\satgpa.csv").Skip(1).[Select](Function(x) x.Split(","c)).[Select](Function(x) New Student(Integer.Parse(x(0)), Double.Parse(x(5).Replace("."c, ","c))))
            Dim columnWidth As Integer = pictureBox1.Width \ sample.Count()

            For Each student In sample
                Dim color As SolidBrush = New SolidBrush(Drawing.Color.FromArgb(Math.Abs((student.sex - 1) * 255), 0, Math.Abs((student.sex - 2) * 255)))
                'This simple formula allows automatic offset of rectangles
                Dim sX = columnWidth * rectangles.Count
                Dim height As Integer = Convert.ToInt32(Math.Truncate(student.getGpa() + 1)) * 50
                rectangles.Add(New MyRectangle(columnWidth, height, sX, 0, color, pictureBox1))
            Next

            timer.Start()
        End Sub

        Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs)
            For Each student In sample
                label1.Text = "Mean: " & calculateMean(student.getGpa()).ToString()
            Next
        End Sub

        Private Sub button3_Click(ByVal sender As Object, ByVal e As EventArgs)
            gpaList.Clear()

            For Each student In sample
                gpaList.Add(student.getGpa())
            Next

            label2.Text = "Deviation: " & calculateDeviation(gpaList).ToString().Remove(5)
        End Sub

        Private Sub button4_Click(ByVal sender As Object, ByVal e As EventArgs)
            label3.Text = "Males 3+ GPA: " & calculateMaleHigh().ToString()
            label4.Text = "Females 3+ GPA: " & calculateFemaleHigh().ToString()
        End Sub

        Private Sub timer1_Tick(ByVal sender As Object, ByVal e As EventArgs)
            pictureBox1.Refresh()
        End Sub

        Private Sub pictureBox1_Paint(ByVal sender As Object, ByVal e As PaintEventArgs)
            Dim g = e.Graphics

            For Each rect In rectangles
                rect.Draw(g)
                rect.Update()
            Next
        End Sub

        Private Function calculateMean(ByVal nextNumber As Double) As Double
            n += 1
            mean = mean + 1.0R / n * (nextNumber - mean)
            Return mean
        End Function

        Private Function calculateDeviation(ByVal values As IEnumerable(Of Double)) As Double
            Dim standardDeviation As Double = 0

            If values.Any() Then
                Dim avg As Double = values.Average()
                Dim sum = values.Sum(Function(d) Math.Pow(d - avg, 2))
                standardDeviation = Math.Sqrt(sum / (values.Count() - 1))
            End If

            Return standardDeviation
        End Function

        Private Function calculateFemaleHigh() As Integer
            Return sample.Where(Function(x) x.getGpa() >= 3 AndAlso x.sex = 2).Count()
        End Function

        Private Function calculateMaleHigh() As Integer
            Return sample.Where(Function(x) x.getGpa() >= 3 AndAlso x.sex = 1).Count()
        End Function
    End Class
End Namespace
