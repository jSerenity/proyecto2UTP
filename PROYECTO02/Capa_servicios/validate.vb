Public Class Validate
	Function Validarcorreo(ByVal emailAddress As String) As Boolean
		Dim valid As Boolean = True
		Try
			Dim a = New System.Net.Mail.MailAddress(emailAddress)
		Catch ex As FormatException
			valid = False
		End Try
		Return valid
	End Function
End Class
