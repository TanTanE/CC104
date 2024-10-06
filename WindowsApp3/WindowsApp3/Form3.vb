Imports System.Windows.Forms
Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim assignedSubjects As String() = {"CC104", "FIL", "IM101", "NET101", "PE", "PF101", "SAD"}
        For Each subject In assignedSubjects
            CheckedListBox1.Items.Add(subject)
        Next
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox1.SelectedIndexChanged
        CheckedListBox1.Text = String.Join(", ", CheckedListBox1.SelectedItems.Cast(Of String)())
    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub
End Class