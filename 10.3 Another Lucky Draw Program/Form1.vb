Public Class Form1

	Dim myAge As Integer

	Dim myName As String
	Private Sub BtnDraw_Click(sender As Object, e As EventArgs) Handles BtnDraw.Click

		Dim myNumber As Integer

		myName = TextBox2.Text
		myAge = TextBox3.Text
		myNumber = Int(Rnd() * 200) + 1
		TextBox4.Text = myNumber

		If myNumber > 120 And myAge > 50 Then
			TextBox1.Text = " Congratulation " & myName & ",You won a lucky prize!"
		Else
			TextBox1.Text = " Sorry " & myName & ", you did not win any prize"
		End If


	End Sub
End Class
