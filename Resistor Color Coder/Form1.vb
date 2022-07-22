Public Class Form1


    Dim color(12) As String
    Dim calculate As Decimal

    Dim input(4) As String

    Dim value(4) As Decimal
    Dim actualvalue As String
    Dim negative As Decimal
    Dim positive As Decimal
    Dim TolPerc As Decimal
    Dim nominalvalue As String
    Dim mode As String = "4"









    Private Sub Black_Click(sender As Object, e As EventArgs)

        

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        color(0) = "Black"
        color(1) = "Brown"
        color(2) = "Red"
        color(3) = "Orange"
        color(4) = "Yellow"
        color(5) = "Green"
        color(6) = "Blue"
        color(7) = "Violet"
        color(8) = "Gray"
        color(9) = "White"
        color(10) = "Gold"
        color(11) = "Silver"
        color(12) = "No Color"


        




        If mode = "4" Then


            input(0) = First.Text
            input(1) = Second.Text
            input(2) = Multiplier.Text
            input(3) = Tolerance.Text

            trd_color.Visible = False
            trd_colorBox.Visible = False

            Multiplier.Top = 340
            Tolerance.Top = 369

            Mul_lbl.Top = 341
            tlr_lbl.Top = 370
            colorcode1.Left = 241
            colorcode2.Left = 278
            colorcode3.Left = 320
            colorcode4.Left = 374

            color5.Visible = False


            Compute.Top = 402
            PictureBox1.Image = My.Resources.resistor


        Else
            trd_color.Visible = True
            trd_colorBox.Visible = True
        End If



    End Sub

    Private Sub colorcode3_Click(sender As Object, e As EventArgs) Handles colorcode3.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
       
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Compute.Click



        If (First.Text = "") Then
            MessageBox.Show("Empty Field1", "Please Fill")
            Return
        ElseIf (Second.Text = "") Then
            MessageBox.Show("Empty Field2", "Please Fill")
            Return
        ElseIf (Multiplier.Text = "") Then

            MessageBox.Show("Empty Field3", "Please Fill")

            Return

        ElseIf (Tolerance.Text = "") Then
            MessageBox.Show("Empty Field4", "Please Fill")
            Return
        ElseIf (trd_colorBox.Text = "" And trd_colorBox.Visible = True) Then
            MessageBox.Show("Empty Field5", "Please Fill")
            Return

        End If



        If mode = 4 Then


            If (First.Text = color(0)) Then

                colorcode1.BackColor = Drawing.Color.Black
                value(0) = "0"

            ElseIf (First.Text = color(1)) Then
                colorcode1.BackColor = Drawing.Color.Brown
                value(0) = "1"
            ElseIf (First.Text = color(2)) Then
                colorcode1.BackColor = Drawing.Color.Red
                value(0) = "2"
            ElseIf (First.Text = color(3)) Then
                colorcode1.BackColor = Drawing.Color.Orange
                value(0) = "3"
            ElseIf (First.Text = color(4)) Then
                colorcode1.BackColor = Drawing.Color.Yellow
                value(0) = "4"
            ElseIf (First.Text = color(5)) Then
                colorcode1.BackColor = Drawing.Color.Green
                value(0) = "5"
            ElseIf (First.Text = color(6)) Then
                colorcode1.BackColor = Drawing.Color.Blue
                value(0) = "6"
            ElseIf (First.Text = color(7)) Then
                colorcode1.BackColor = Drawing.Color.Violet
                value(0) = "7"
            ElseIf (First.Text = color(8)) Then
                colorcode1.BackColor = Drawing.Color.Gray
                value(0) = "8"
            ElseIf (First.Text = color(9)) Then
                colorcode1.BackColor = Drawing.Color.White
                value(0) = "9"
            ElseIf (First.Text = color(10)) Then
                colorcode1.BackColor = Drawing.Color.Gold
                value(0) = "0.1"
            ElseIf (First.Text = color(11)) Then
                colorcode1.BackColor = Drawing.Color.Silver
                value(0) = "0.01"
            ElseIf (First.Text = color(12)) Then



            End If



            If (Second.Text = color(0)) Then

                colorcode2.BackColor = Drawing.Color.Black
                value(1) = "0"

            ElseIf (Second.Text = color(1)) Then
                colorcode2.BackColor = Drawing.Color.Brown
                value(1) = "1"

            ElseIf (Second.Text = color(2)) Then
                colorcode2.BackColor = Drawing.Color.Red
                value(1) = "2"
            ElseIf (Second.Text = color(3)) Then
                colorcode2.BackColor = Drawing.Color.Orange
                value(1) = "3"
            ElseIf (Second.Text = color(4)) Then
                value(1) = "4"

                colorcode2.BackColor = Drawing.Color.Yellow
            ElseIf (Second.Text = color(5)) Then
                colorcode2.BackColor = Drawing.Color.Green
                value(1) = "5"

            ElseIf (Second.Text = color(6)) Then
                colorcode2.BackColor = Drawing.Color.Blue
                value(1) = "6"

            ElseIf (Second.Text = color(7)) Then
                colorcode2.BackColor = Drawing.Color.Violet
                value(1) = "7"

            ElseIf (Second.Text = color(8)) Then
                colorcode2.BackColor = Drawing.Color.Gray
                value(1) = "8"

            ElseIf (Second.Text = color(9)) Then
                colorcode2.BackColor = Drawing.Color.White
                value(1) = "9"

            ElseIf (Second.Text = color(10)) Then
                colorcode2.BackColor = Drawing.Color.Gold
                value(1) = "0.1"

            ElseIf (Second.Text = color(11)) Then
                colorcode2.BackColor = Drawing.Color.Silver
                value(1) = "0.01"
            ElseIf (Second.Text = color(12)) Then



            End If



            If (Multiplier.Text = color(0)) Then

                colorcode3.BackColor = Drawing.Color.Black
                value(2) = "0"

            ElseIf (Multiplier.Text = color(1)) Then
                colorcode3.BackColor = Drawing.Color.Brown
                value(2) = "1"

            ElseIf (Multiplier.Text = color(2)) Then
                colorcode3.BackColor = Drawing.Color.Red
                value(2) = "2"

            ElseIf (Multiplier.Text = color(3)) Then
                colorcode3.BackColor = Drawing.Color.Orange
                value(2) = "3"
            ElseIf (Multiplier.Text = color(4)) Then
                colorcode3.BackColor = Drawing.Color.Yellow
                value(2) = "4"
            ElseIf (Multiplier.Text = color(5)) Then
                colorcode3.BackColor = Drawing.Color.Green
                value(2) = "5"
            ElseIf (Multiplier.Text = color(6)) Then
                colorcode3.BackColor = Drawing.Color.Blue
                value(2) = "6"
            ElseIf (Multiplier.Text = color(7)) Then
                colorcode3.BackColor = Drawing.Color.Violet
                value(2) = "7"
            ElseIf (Multiplier.Text = color(8)) Then
                colorcode3.BackColor = Drawing.Color.Gray
                value(2) = "8"
            ElseIf (Multiplier.Text = color(9)) Then
                colorcode3.BackColor = Drawing.Color.White
                value(2) = "9"
            ElseIf (Multiplier.Text = color(10)) Then
                colorcode3.BackColor = Drawing.Color.Gold
                value(2) = "0.1"
            ElseIf (Multiplier.Text = color(11)) Then
                colorcode3.BackColor = Drawing.Color.Silver
                value(2) = "0.01"
            ElseIf (Multiplier.Text = color(12)) Then



            End If



            If (Tolerance.Text = color(0)) Then

                colorcode4.BackColor = Drawing.Color.Black

            ElseIf (Tolerance.Text = color(1)) Then
                colorcode4.BackColor = Drawing.Color.Brown
                value(3) = "1"

            ElseIf (Tolerance.Text = color(2)) Then
                colorcode4.BackColor = Drawing.Color.Red
                value(3) = "2"

            ElseIf (Tolerance.Text = color(3)) Then
                colorcode4.BackColor = Drawing.Color.Orange
            ElseIf (Tolerance.Text = color(4)) Then
                colorcode4.BackColor = Drawing.Color.Yellow
            ElseIf (Tolerance.Text = color(5)) Then
                colorcode4.BackColor = Drawing.Color.Green
            ElseIf (Tolerance.Text = color(6)) Then
                colorcode4.BackColor = Drawing.Color.Blue
            ElseIf (Tolerance.Text = color(7)) Then
                colorcode4.BackColor = Drawing.Color.Violet
            ElseIf (Tolerance.Text = color(8)) Then
                colorcode4.BackColor = Drawing.Color.Gray
            ElseIf (Tolerance.Text = color(9)) Then
                colorcode4.BackColor = Drawing.Color.White
            ElseIf (Tolerance.Text = color(10)) Then
                colorcode4.BackColor = Drawing.Color.Gold
                value(3) = "5"
            ElseIf (Tolerance.Text = color(11)) Then
                colorcode4.BackColor = Drawing.Color.Silver
                value(3) = "10"
            ElseIf (Tolerance.Text = color(12)) Then



            End If









            calculate = CDec(value(0) & value(1)) * Math.Pow(10, CDec(value(2)))

            TolPerc = (CDec(value(3)) * calculate) / 100

            positive = calculate + TolPerc
            negative = calculate - TolPerc


            actualvalue = CStr(negative) & " To " & CStr(positive)

            nominalvalue = CStr(CDec(value(0) & value(1)) * Math.Pow(10, CDec(value(2)))) & " ± " & value(3) & "%"


            MessageBox.Show("Done!")

            Actual.Text = "Actual Value: " & actualvalue
            Nominal.Text = "Nominal Value: " & nominalvalue



        Else


            If (First.Text = color(0)) Then

                colorcode1.BackColor = Drawing.Color.Black
                value(0) = "0"

            ElseIf (First.Text = color(1)) Then
                colorcode1.BackColor = Drawing.Color.Brown
                value(0) = "1"
            ElseIf (First.Text = color(2)) Then
                colorcode1.BackColor = Drawing.Color.Red
                value(0) = "2"
            ElseIf (First.Text = color(3)) Then
                colorcode1.BackColor = Drawing.Color.Orange
                value(0) = "3"
            ElseIf (First.Text = color(4)) Then
                colorcode1.BackColor = Drawing.Color.Yellow
                value(0) = "4"
            ElseIf (First.Text = color(5)) Then
                colorcode1.BackColor = Drawing.Color.Green
                value(0) = "5"
            ElseIf (First.Text = color(6)) Then
                colorcode1.BackColor = Drawing.Color.Blue
                value(0) = "6"
            ElseIf (First.Text = color(7)) Then
                colorcode1.BackColor = Drawing.Color.Violet
                value(0) = "7"
            ElseIf (First.Text = color(8)) Then
                colorcode1.BackColor = Drawing.Color.Gray
                value(0) = "8"
            ElseIf (First.Text = color(9)) Then
                colorcode1.BackColor = Drawing.Color.White
                value(0) = "9"
            ElseIf (First.Text = color(10)) Then
                colorcode1.BackColor = Drawing.Color.Gold
                value(0) = "0.1"
            ElseIf (First.Text = color(11)) Then
                colorcode1.BackColor = Drawing.Color.Silver
                value(0) = "0.01"
            ElseIf (First.Text = color(12)) Then



            End If



            If (Second.Text = color(0)) Then

                colorcode2.BackColor = Drawing.Color.Black
                value(1) = "0"

            ElseIf (Second.Text = color(1)) Then
                colorcode2.BackColor = Drawing.Color.Brown
                value(1) = "1"

            ElseIf (Second.Text = color(2)) Then
                colorcode2.BackColor = Drawing.Color.Red
                value(1) = "2"
            ElseIf (Second.Text = color(3)) Then
                colorcode2.BackColor = Drawing.Color.Orange
                value(1) = "3"
            ElseIf (Second.Text = color(4)) Then
                value(1) = "4"

                colorcode2.BackColor = Drawing.Color.Yellow
            ElseIf (Second.Text = color(5)) Then
                colorcode2.BackColor = Drawing.Color.Green
                value(1) = "5"

            ElseIf (Second.Text = color(6)) Then
                colorcode2.BackColor = Drawing.Color.Blue
                value(1) = "6"

            ElseIf (Second.Text = color(7)) Then
                colorcode2.BackColor = Drawing.Color.Violet
                value(1) = "7"

            ElseIf (Second.Text = color(8)) Then
                colorcode2.BackColor = Drawing.Color.Gray
                value(1) = "8"

            ElseIf (Second.Text = color(9)) Then
                colorcode2.BackColor = Drawing.Color.White
                value(1) = "9"

            ElseIf (Second.Text = color(10)) Then
                colorcode2.BackColor = Drawing.Color.Gold
                value(1) = "0.1"

            ElseIf (Second.Text = color(11)) Then
                colorcode2.BackColor = Drawing.Color.Silver
                value(1) = "0.01"
            ElseIf (trd_colorBox.Text = color(12)) Then



            End If


            If (trd_colorBox.Text = color(0)) Then

                color5.BackColor = Drawing.Color.Black
                value(2) = "0"

            ElseIf (trd_colorBox.Text = color(1)) Then
                color5.BackColor = Drawing.Color.Brown
                value(2) = "1"

            ElseIf (trd_colorBox.Text = color(2)) Then
                color5.BackColor = Drawing.Color.Red
                value(2) = "2"
            ElseIf (trd_colorBox.Text = color(3)) Then
                color5.BackColor = Drawing.Color.Orange
                value(2) = "3"
            ElseIf (trd_colorBox.Text = color(4)) Then
                value(2) = "4"

                color5.BackColor = Drawing.Color.Yellow
            ElseIf (trd_colorBox.Text = color(5)) Then
                color5.BackColor = Drawing.Color.Green
                value(2) = "5"

            ElseIf (trd_colorBox.Text = color(6)) Then
                color5.BackColor = Drawing.Color.Blue
                value(2) = "6"

            ElseIf (trd_colorBox.Text = color(7)) Then
                color5.BackColor = Drawing.Color.Violet
                value(2) = "7"

            ElseIf (trd_colorBox.Text = color(8)) Then
                color5.BackColor = Drawing.Color.Gray
                value(2) = "8"

            ElseIf (trd_colorBox.Text = color(9)) Then
                color5.BackColor = Drawing.Color.White
                value(2) = "9"

            ElseIf (trd_colorBox.Text = color(10)) Then
                color5.BackColor = Drawing.Color.Gold
                value(2) = "0.1"

            ElseIf (trd_colorBox.Text = color(11)) Then
                color5.BackColor = Drawing.Color.Silver
                value(2) = "0.01"
            ElseIf (trd_colorBox.Text = color(12)) Then



            End If

            If (Multiplier.Text = color(0)) Then

                colorcode3.BackColor = Drawing.Color.Black
                value(3) = "0"

            ElseIf (Multiplier.Text = color(1)) Then
                colorcode3.BackColor = Drawing.Color.Brown
                value(3) = "1"

            ElseIf (Multiplier.Text = color(2)) Then
                colorcode3.BackColor = Drawing.Color.Red
                value(3) = "2"

            ElseIf (Multiplier.Text = color(3)) Then
                colorcode3.BackColor = Drawing.Color.Orange
                value(3) = "3"
            ElseIf (Multiplier.Text = color(4)) Then
                colorcode3.BackColor = Drawing.Color.Yellow
                value(3) = "4"
            ElseIf (Multiplier.Text = color(5)) Then
                colorcode3.BackColor = Drawing.Color.Green
                value(3) = "5"
            ElseIf (Multiplier.Text = color(6)) Then
                colorcode3.BackColor = Drawing.Color.Blue
                value(3) = "6"
            ElseIf (Multiplier.Text = color(7)) Then
                colorcode3.BackColor = Drawing.Color.Violet
                value(3) = "7"
            ElseIf (Multiplier.Text = color(8)) Then
                colorcode3.BackColor = Drawing.Color.Gray
                value(3) = "8"
            ElseIf (Multiplier.Text = color(9)) Then
                colorcode3.BackColor = Drawing.Color.White
                value(3) = "9"
            ElseIf (Multiplier.Text = color(10)) Then
                colorcode3.BackColor = Drawing.Color.Gold
                value(3) = "0.1"
            ElseIf (Multiplier.Text = color(11)) Then
                colorcode3.BackColor = Drawing.Color.Silver
                value(3) = "0.01"
            ElseIf (Multiplier.Text = color(12)) Then



            End If



            If (Tolerance.Text = color(0)) Then

                colorcode4.BackColor = Drawing.Color.Black

            ElseIf (Tolerance.Text = color(1)) Then
                colorcode4.BackColor = Drawing.Color.Brown
                value(4) = "1"

            ElseIf (Tolerance.Text = color(2)) Then
                colorcode4.BackColor = Drawing.Color.Red
                value(4) = "2"

            ElseIf (Tolerance.Text = color(3)) Then
                colorcode4.BackColor = Drawing.Color.Orange
            ElseIf (Tolerance.Text = color(4)) Then
                colorcode4.BackColor = Drawing.Color.Yellow
            ElseIf (Tolerance.Text = color(5)) Then
                colorcode4.BackColor = Drawing.Color.Green
            ElseIf (Tolerance.Text = color(6)) Then
                colorcode4.BackColor = Drawing.Color.Blue
            ElseIf (Tolerance.Text = color(7)) Then
                colorcode4.BackColor = Drawing.Color.Violet
            ElseIf (Tolerance.Text = color(8)) Then
                colorcode4.BackColor = Drawing.Color.Gray
            ElseIf (Tolerance.Text = color(9)) Then
                colorcode4.BackColor = Drawing.Color.White
            ElseIf (Tolerance.Text = color(10)) Then
                colorcode4.BackColor = Drawing.Color.Gold
                value(4) = "5"
            ElseIf (Tolerance.Text = color(11)) Then
                colorcode4.BackColor = Drawing.Color.Silver
                value(4) = "10"
            ElseIf (Tolerance.Text = color(12)) Then



            End If

            calculate = CDec(value(0) & value(1) & value(2)) * Math.Pow(10, CDec(value(3)))

            TolPerc = (CDec(value(4)) * calculate) / 100

            positive = calculate + TolPerc
            negative = calculate - TolPerc


            actualvalue = CStr(negative) & " To " & CStr(positive)

            nominalvalue = CStr(CDec(value(0) & value(1) & value(2)) * Math.Pow(10, CDec(value(3)))) & " ± " & value(4) & "%"


            MessageBox.Show("Done!")

            Actual.Text = "Actual Value: " & actualvalue
            Nominal.Text = "Nominal Value: " & nominalvalue





        End If








    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Nominal.Click

    End Sub

    Private Sub FiveColorBandToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FiveColorBandToolStripMenuItem.Click
        Me.Controls.Clear()
        InitializeComponent()
        mode = "5"


        Multiplier.Top = 369
        Mul_lbl.Top = 370
        Tolerance.Top = 396
        tlr_lbl.Top = 396

        color5.Visible = True


        colorcode1.Left = 233
        colorcode2.Left = 268
        colorcode3.Left = 339
        colorcode4.Left = 370

        PictureBox1.Image = My.Resources.resistor3

        Compute.Top = 432

        trd_color.Visible = True
        trd_colorBox.Visible = True
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles trd_colorBox.SelectedIndexChanged

    End Sub

    Private Sub FourColorBandToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FourColorBandToolStripMenuItem.Click
        Me.Controls.Clear()
        InitializeComponent()

        mode = "4"
        If mode = "4" Then

            trd_color.Visible = False
            trd_colorBox.Visible = False

            Multiplier.Top = 340
            Tolerance.Top = 369

            PictureBox1.Image = My.Resources.resistor


            color5.Visible = False


            colorcode1.Left = 241
            colorcode2.Left = 278
            colorcode3.Left = 320
            colorcode4.Left = 374

           

            Mul_lbl.Top = 341
            tlr_lbl.Top = 370

            Compute.Top = 402


        End If

    End Sub

    Private Sub RedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedToolStripMenuItem.Click
        Me.BackColor = Drawing.Color.Red

    End Sub

    Private Sub BlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlueToolStripMenuItem.Click
        Me.BackColor = Drawing.Color.Blue
    End Sub

    Private Sub GreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GreenToolStripMenuItem.Click
        Me.BackColor = Drawing.Color.Green
    End Sub

    Private Sub MaroonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaroonToolStripMenuItem.Click
        Me.BackColor = Drawing.Color.Maroon
    End Sub

    Private Sub ModeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModeToolStripMenuItem.Click

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub PreferenceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PreferenceToolStripMenuItem.Click

    End Sub

    Private Sub BgColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BgColorToolStripMenuItem.Click

    End Sub
End Class
