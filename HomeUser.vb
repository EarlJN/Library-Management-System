Public Class HomeUser

    Private Sub PictureBox1_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox1.MouseEnter, PictureBox2.MouseEnter, PictureBox3.MouseEnter, PictureBox4.MouseEnter, PictureBox5.MouseEnter
        Dim pb As PictureBox = DirectCast(sender, PictureBox)

        ' Set the outline color of the PictureBox to dark blue
        pb.BackColor = Color.Transparent
        pb.Tag = pb.BorderStyle
        pb.BorderStyle = BorderStyle.None

        ' Animate the outline by gradually increasing its thickness to 5 pixels
        For i As Integer = 1 To 5
            ControlPaint.DrawBorder(pb.CreateGraphics(), New Rectangle(0, 0, pb.Width, pb.Height),
            Color.FromArgb(0, 20, 39), i, ButtonBorderStyle.Solid, Color.FromArgb(0, 20, 39), i, ButtonBorderStyle.Solid,
            Color.FromArgb(0, 20, 39), i, ButtonBorderStyle.Solid, Color.FromArgb(0, 20, 39), i, ButtonBorderStyle.Solid)
            Threading.Thread.Sleep(20)
        Next
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave, PictureBox2.MouseLeave, PictureBox3.MouseLeave, PictureBox4.MouseLeave, PictureBox5.MouseLeave
        Dim pb As PictureBox = DirectCast(sender, PictureBox)

        ' Restore the original border style and color
        pb.BorderStyle = CType(pb.Tag, BorderStyle)
        pb.BackColor = Color.Transparent

        ' Redraw the PictureBox control
        pb.Refresh()
    End Sub


End Class