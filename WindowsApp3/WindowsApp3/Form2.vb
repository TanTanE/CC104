Public Class Form2
    Dim textBoxPlaceholderText As String = "Student ID"

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.Text = textBoxPlaceholderText
        TextBox2.ForeColor = Color.Gray
    End Sub
    Private Sub TextBox2_GotFocus(sender As Object, e As EventArgs) Handles TextBox2.GotFocus
        If TextBox2.Text = textBoxPlaceholderText Then
            TextBox2.Text = ""
            TextBox2.ForeColor = Color.White
        End If
    End Sub

    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TextBox2.LostFocus
        If String.IsNullOrWhiteSpace(TextBox2.Text) Then
            TextBox2.Text = textBoxPlaceholderText
            TextBox2.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.SelectedItem.ToString() = "Student" Then
            Dim studentForm As New Form2()
            studentForm.Show()
            Me.Hide()
        ElseIf ComboBox2.SelectedItem.ToString() = "Admin" Then
            Dim adminForm As New Form1()
            adminForm.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)
    End Sub
End Class