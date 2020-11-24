Public Class Form2

    Private Sub P2_Paint(sender As Object, e As PaintEventArgs) Handles pnltop.Paint

    End Sub

    Private Sub L2_Click(sender As Object, e As EventArgs) Handles L2.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles P3.Paint

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub B3_Click(sender As Object, e As EventArgs) Handles btnmeat.Click
        pnlmeat.Height = btnmeat.Height
        pnlhotdrinks.Top = btnmeat.Top
        pnlitems.Visible = False
        pnlhotdrinks.Visible = False
        pnlmeat.Visible = True
        pnlcolddrinks.Visible = False
        pnlcakes.Visible = False
        pnlbreakfast.Visible = False
        pnlpizza.Visible = False
        aboutus.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Show()
    End Sub


    Private Sub Button40_Click(sender As Object, e As EventArgs) Handles Button40.Click

    End Sub

    Private Sub fastfood_Click(sender As Object, e As EventArgs) Handles btnallitems.Click
        pnlitems.Height = btnallitems.Height
        pnlitems.Top = btnallitems.Top
        pnlitems.Visible = True
        pnlhotdrinks.Visible = False
        pnlmeat.Visible = False
        pnlcolddrinks.Visible = False
        pnlcakes.Visible = False
        pnlbreakfast.Visible = False
        pnlpizza.Visible = False
        aboutus.Visible = False


    End Sub
    Private Sub B2_Click(sender As Object, e As EventArgs) Handles btnhotdrinks.Click
        pnlhotdrinks.Height = btnhotdrinks.Height
        pnlhotdrinks.Top = btnhotdrinks.Top
        pnlitems.Visible = False
        pnlhotdrinks.Visible = True
        pnlmeat.Visible = False
        pnlcolddrinks.Visible = False
        pnlcakes.Visible = False
        pnlbreakfast.Visible = False
        pnlpizza.Visible = False
        aboutus.Visible = False
    End Sub

    Private Sub btncolddrinks_Click(sender As Object, e As EventArgs) Handles btncolddrinks.Click
        pnlcolddrinks.Height = btncolddrinks.Height
        pnlcolddrinks.Top = btncolddrinks.Top
        pnlitems.Visible = False
        pnlhotdrinks.Visible = False
        pnlmeat.Visible = False
        pnlcolddrinks.Visible = True
        pnlcakes.Visible = False
        pnlpizza.Visible = False
        aboutus.Visible = False
    End Sub

    Private Sub btncakes_Click(sender As Object, e As EventArgs) Handles btncakes.Click
        pnlcakes.Height = btncakes.Height
        pnlcakes.Top = btncakes.Top
        pnlitems.Visible = False
        pnlhotdrinks.Visible = False
        pnlmeat.Visible = False
        pnlcolddrinks.Visible = False
        pnlcakes.Visible = True
        pnlbreakfast.Visible = False
        pnlpizza.Visible = False
        aboutus.Visible = False
    End Sub

    Private Sub btnbreakfast_Click(sender As Object, e As EventArgs) Handles btnbreakfast.Click
        pnlbreakfast.Height = btnbreakfast.Height
        pnlbreakfast.Top = btnbreakfast.Top
        pnlitems.Visible = False
        pnlhotdrinks.Visible = False
        pnlmeat.Visible = False
        pnlcolddrinks.Visible = False
        pnlcakes.Visible = False
        pnlbreakfast.Visible = True
        pnlpizza.Visible = False
        aboutus.Visible = False
    End Sub

    Private Sub btnpizza_Click(sender As Object, e As EventArgs) Handles btnpizza.Click
        pnlpizza.Height = btnpizza.Height
        pnlpizza.Top = btnpizza.Top
        pnlitems.Visible = False
        pnlhotdrinks.Visible = False
        pnlmeat.Visible = False
        pnlcolddrinks.Visible = False
        pnlcakes.Visible = False
        pnlbreakfast.Visible = False
        aboutus.Visible = False
        pnlpizza.Visible = True
    End Sub


    Private Sub Button93_Click(sender As Object, e As EventArgs) Handles Button93.Click
        Form3.Show()
    End Sub

    Private Sub B11_Click(sender As Object, e As EventArgs) Handles B11.Click
        Form3.Show()
    End Sub

    Private Sub B9_Click(sender As Object, e As EventArgs) Handles B9.Click
        Form4.Show()
    End Sub

    Private Sub btnabout_Click(sender As Object, e As EventArgs) Handles btnabout.Click
        aboutus.Height = aboutus.Height
        aboutus.Top = btnabout.Top
        pnlitems.Visible = False
        pnlhotdrinks.Visible = False
        pnlmeat.Visible = False
        pnlcolddrinks.Visible = False
        pnlcakes.Visible = False
        pnlbreakfast.Visible = False
        pnlpizza.Visible = False
        aboutus.Visible = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form3.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form3.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Form3.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Form3.Show()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Form3.Show()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Form3.Show()
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Form3.Show()
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Form3.Show()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Form3.Show()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Form3.Show()
    End Sub

    Private Sub Button165_Click(sender As Object, e As EventArgs) Handles Button165.Click
        Form3.Show()
    End Sub

    Private Sub Button161_Click(sender As Object, e As EventArgs) Handles Button161.Click
        Form3.Show()
    End Sub

    Private Sub Button163_Click(sender As Object, e As EventArgs) Handles Button163.Click
        Form3.Show()
    End Sub

    Private Sub Button159_Click(sender As Object, e As EventArgs) Handles Button159.Click
        Form3.Show()
    End Sub

    Private Sub Button157_Click(sender As Object, e As EventArgs) Handles Button157.Click
        Form3.Show()
    End Sub

    Private Sub Button153_Click(sender As Object, e As EventArgs) Handles Button153.Click
        Form3.Show()
    End Sub

    Private Sub Button155_Click(sender As Object, e As EventArgs) Handles Button155.Click
        Form3.Show()
    End Sub

    Private Sub Button151_Click(sender As Object, e As EventArgs) Handles Button151.Click
        Form3.Show()
    End Sub

    Private Sub Button143_Click(sender As Object, e As EventArgs) Handles Button143.Click
        Form3.Show()
    End Sub

    Private Sub Button145_Click(sender As Object, e As EventArgs) Handles Button145.Click
        Form3.Show()
    End Sub

    Private Sub Button147_Click(sender As Object, e As EventArgs) Handles Button147.Click
        Form3.Show()
    End Sub

    Private Sub Button149_Click(sender As Object, e As EventArgs) Handles Button149.Click
        Form3.Show()
    End Sub

    Private Sub Button141_Click(sender As Object, e As EventArgs) Handles Button141.Click
        Form3.Show()
    End Sub

    Private Sub Button137_Click(sender As Object, e As EventArgs) Handles Button137.Click
        Form3.Show()
    End Sub

    Private Sub Button133_Click(sender As Object, e As EventArgs) Handles Button133.Click
        Form3.Show()
    End Sub

    Private Sub Button129_Click(sender As Object, e As EventArgs) Handles Button129.Click
        Form3.Show()
    End Sub

    Private Sub Button139_Click(sender As Object, e As EventArgs) Handles Button139.Click
        Form3.Show()
    End Sub

    Private Sub Button135_Click(sender As Object, e As EventArgs) Handles Button135.Click
        Form3.Show()
    End Sub

    Private Sub Button131_Click(sender As Object, e As EventArgs) Handles Button131.Click
        Form3.Show()
    End Sub

    Private Sub Button127_Click(sender As Object, e As EventArgs) Handles Button127.Click
        Form3.Show()
    End Sub

    Private Sub Button125_Click(sender As Object, e As EventArgs) Handles Button125.Click
        Form3.Show()
    End Sub

    Private Sub Button123_Click(sender As Object, e As EventArgs) Handles Button123.Click
        Form3.Show()
    End Sub

    Private Sub Label61_Click(sender As Object, e As EventArgs) Handles Label61.Click

    End Sub

    Private Sub Button121_Click(sender As Object, e As EventArgs) Handles Button121.Click
        Form3.Show()
    End Sub

    Private Sub Button119_Click(sender As Object, e As EventArgs) Handles Button119.Click
        Form3.Show()
    End Sub

    Private Sub Button89_Click(sender As Object, e As EventArgs) Handles Button89.Click
        Form3.Show()
    End Sub

    Private Sub Button85_Click(sender As Object, e As EventArgs) Handles Button85.Click
        Form3.Show()
    End Sub

    Private Sub Button81_Click(sender As Object, e As EventArgs) Handles Button81.Click
        Form3.Show()
    End Sub

    Private Sub Button79_Click(sender As Object, e As EventArgs) Handles Button79.Click
        Form3.Show()
    End Sub

    Private Sub Button83_Click(sender As Object, e As EventArgs) Handles Button83.Click
        Form3.Show()
    End Sub

    Private Sub Button87_Click(sender As Object, e As EventArgs) Handles Button87.Click
        Form3.Show()
    End Sub

    Private Sub Button91_Click(sender As Object, e As EventArgs) Handles Button91.Click
        Form3.Show()
    End Sub

    Private Sub Button77_Click(sender As Object, e As EventArgs) Handles Button77.Click
        Form3.Show()
    End Sub

    Private Sub Button75_Click(sender As Object, e As EventArgs) Handles Button75.Click
        Form3.Show()
    End Sub

    Private Sub Button73_Click(sender As Object, e As EventArgs) Handles Button73.Click
        Form3.Show()
    End Sub

    Private Sub Button71_Click(sender As Object, e As EventArgs) Handles Button71.Click
        Form3.Show()
    End Sub

    Private Sub Button189_Click(sender As Object, e As EventArgs) Handles Button189.Click
        Form3.Show()
    End Sub

    Private Sub Button185_Click(sender As Object, e As EventArgs) Handles Button185.Click
        Form3.Show()
    End Sub

    Private Sub Button181_Click(sender As Object, e As EventArgs) Handles Button181.Click
        Form3.Show()
    End Sub

    Private Sub Button177_Click(sender As Object, e As EventArgs) Handles Button177.Click
        Form3.Show()
    End Sub

    Private Sub Button187_Click(sender As Object, e As EventArgs) Handles Button187.Click
        Form3.Show()
    End Sub

    Private Sub Button183_Click(sender As Object, e As EventArgs) Handles Button183.Click
        Form3.Show()
    End Sub

    Private Sub Button179_Click(sender As Object, e As EventArgs) Handles Button179.Click
        Form3.Show()
    End Sub

    Private Sub Button175_Click(sender As Object, e As EventArgs) Handles Button175.Click
        Form3.Show()
    End Sub

    Private Sub Button117_Click(sender As Object, e As EventArgs) Handles Button117.Click
        Form3.Show()
    End Sub

    Private Sub Button113_Click(sender As Object, e As EventArgs) Handles Button113.Click
        Form3.Show()
    End Sub

    Private Sub Button109_Click(sender As Object, e As EventArgs) Handles Button109.Click
        Form3.Show()
    End Sub

    Private Sub Button105_Click(sender As Object, e As EventArgs) Handles Button105.Click
        Form3.Show()
    End Sub

    Private Sub Button103_Click(sender As Object, e As EventArgs) Handles Button103.Click
        Form3.Show()
    End Sub

    Private Sub Button107_Click(sender As Object, e As EventArgs) Handles Button107.Click
        Form3.Show()
    End Sub

    Private Sub Button115_Click(sender As Object, e As EventArgs) Handles Button115.Click
        Form3.Show()
    End Sub

    Private Sub Button111_Click(sender As Object, e As EventArgs) Handles Button111.Click
        Form3.Show()
    End Sub

    Private Sub Button101_Click(sender As Object, e As EventArgs) Handles Button101.Click
        Form3.Show()
    End Sub

    Private Sub Button99_Click(sender As Object, e As EventArgs) Handles Button99.Click
        Form3.Show()
    End Sub

    Private Sub Button65_Click(sender As Object, e As EventArgs) Handles Button65.Click
        Form3.Show()
    End Sub

    Private Sub Button61_Click(sender As Object, e As EventArgs) Handles Button61.Click
        Form3.Show()
    End Sub

    Private Sub Button57_Click(sender As Object, e As EventArgs) Handles Button57.Click
        Form3.Show()
    End Sub

    Private Sub Button55_Click(sender As Object, e As EventArgs) Handles Button55.Click
        Form3.Show()
    End Sub

    Private Sub Button59_Click(sender As Object, e As EventArgs) Handles Button59.Click
        Form3.Show()
    End Sub

    Private Sub Button63_Click(sender As Object, e As EventArgs) Handles Button63.Click
        Form3.Show()
    End Sub

    Private Sub Button67_Click(sender As Object, e As EventArgs) Handles Button67.Click
        Form3.Show()
    End Sub

    Private Sub Button53_Click(sender As Object, e As EventArgs) Handles Button53.Click
        Form3.Show()
    End Sub

    Private Sub Button69_Click(sender As Object, e As EventArgs) Handles Button69.Click
        Form3.Show()
    End Sub
End Class
