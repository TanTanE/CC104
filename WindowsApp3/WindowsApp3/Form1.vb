Public Class Form1
    Dim textBoxPlaceholderText As String = "ID"
    Dim maskedTextBoxPlaceholderText As String = "Password"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = textBoxPlaceholderText
        TextBox1.ForeColor = Color.Gray

        MaskedTextBox1.Text = maskedTextBoxPlaceholderText
        MaskedTextBox1.ForeColor = Color.Gray
    End Sub

    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles TextBox1.GotFocus
        If TextBox1.Text = textBoxPlaceholderText Then
            TextBox1.Text = ""
            TextBox1.ForeColor = Color.White
        End If
    End Sub

    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus
        If String.IsNullOrWhiteSpace(TextBox1.Text) Then
            TextBox1.Text = textBoxPlaceholderText
            TextBox1.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub MaskedTextBox1_GotFocus(sender As Object, e As EventArgs) Handles MaskedTextBox1.GotFocus

        If MaskedTextBox1.Text = maskedTextBoxPlaceholderText Then
            MaskedTextBox1.Text = ""
            MaskedTextBox1.ForeColor = Color.White
        End If
    End Sub

    Private Sub MaskedTextBox1_LostFocus(sender As Object, e As EventArgs) Handles MaskedTextBox1.LostFocus
        If String.IsNullOrWhiteSpace(MaskedTextBox1.Text) Then
            MaskedTextBox1.Text = maskedTextBoxPlaceholderText
            MaskedTextBox1.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem.ToString() = "Student" Then
            Dim studentForm As New Form2()
            studentForm.Show()
            Me.Hide()
        ElseIf ComboBox1.SelectedItem.ToString() = "Admin" Then
            Dim adminForm As New Form1()
            adminForm.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub
End Class
