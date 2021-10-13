Namespace Homework3._1_CSharp
    Public Class Student
        Public Property sex As Integer
        Private gpa As Double

        Public Sub New(ByVal sex As Integer, ByVal gpa As Double)
            Me.sex = sex
            Me.gpa = gpa
        End Sub

        Public Function getGpa() As Double
            Return gpa
        End Function
    End Class
End Namespace
