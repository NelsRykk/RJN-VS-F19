'Assignment: Asg1-5
'RCET0265
'Rykken Nelson
'Menu
Option Strict On
Option Explicit On

Public Class Form1
    Dim baconPotato As Integer
    Dim minestore As Integer
    Dim pizzaSoup As Integer
    Dim italiangreens As Integer
    Dim houseSalad As Integer
    Dim autumns As Integer
    Dim petes As Integer
    Dim singers As Integer
    Dim gweniths As Integer
    Dim kylis As Integer
    Dim Pepper As Integer
    Dim Oranges As Integer
    Dim Spirite As Integer
    Dim aid As Integer
    Dim tea As Integer
    Dim baconPotato2 As Integer
    Dim minestore2 As Integer
    Dim pizzaSoup2 As Integer
    Dim italiangreens2 As Integer
    Dim houseSalad2 As Integer
    Dim autumns2 As Integer
    Dim petes2 As Integer
    Dim singers2 As Integer
    Dim gweniths2 As Integer
    Dim kylis2 As Integer
    Dim Pepper2 As Integer
    Dim Oranges2 As Integer
    Dim Spirite2 As Integer
    Dim aid2 As Integer
    Dim tea2 As Integer
    Dim bring As Integer
    Dim detail As String
    Dim running As Boolean = True


    Public Sub Front_Click(sender As Object, e As EventArgs) Handles Front.Click        'this is the main menu 
        What.Visible = True
        What.Text = "select order"
        PizzaButton.Visible = True
        DrinkButton.Visible = True
        AppetizerButton.Visible = True
        P1Button.Visible = False
        P2Button.Visible = False
        P3Button.Visible = False
        P4Button.Visible = False
        P5Button.Visible = False
        PictureBox1.Visible = False
        ItalianSalad.Visible = False
        BaconButton.Visible = False
        PizzaSlop.Visible = False
        MinestroneButton.Visible = False
        HouseButton.Visible = False
        Orange.Visible = False
        Dr.Visible = False
        Sprite.Visible = False
        Lemonade.Visible = False
        Iced.Visible = False
        RichTextBox1.Visible = False
        Op()



    End Sub
    Private Sub PizzaButton_Click(sender As Object, e As EventArgs) Handles PizzaButton.Click   'this shows all the types of pizza and where you order pizza
        PizzaButton.Visible = False         'Pizza menu
        DrinkButton.Visible = False            'Drink menu
        AppetizerButton.Visible = False
        P1Button.Visible = True             'Below contains pizza buttons
        P2Button.Visible = True
        P3Button.Visible = True
        P4Button.Visible = True
        P5Button.Visible = True
        PictureBox1.Visible = True
        ItalianSalad.Visible = False        'Below contains soup menu buttons
        BaconButton.Visible = False
        PizzaSlop.Visible = False
        MinestroneButton.Visible = False
        HouseButton.Visible = False
        Orange.Visible = False
        Dr.Visible = False
        Sprite.Visible = False
        Lemonade.Visible = False
        Iced.Visible = False
        RichTextBox1.Visible = False
        PictureBox1.Image = Asg_1_5.My.Resources.Resources.Pizza_by_the_slice
        What.Visible = True
        What.Text = "These are the Types of Pizza"
        Op()

    End Sub
    Private Sub Appetizer_Click(sender As Object, e As EventArgs) Handles AppetizerButton.Click     ' Where you order your appetizer
        What.Visible = True
        What.Text = "Select Soup or House Salad"
        PizzaButton.Visible = False
        DrinkButton.Visible = False
        AppetizerButton.Visible = False
        P1Button.Visible = False
        P2Button.Visible = False
        P3Button.Visible = False
        P4Button.Visible = False
        P5Button.Visible = False
        ItalianSalad.Visible = True
        BaconButton.Visible = True
        PizzaSlop.Visible = True
        MinestroneButton.Visible = True
        HouseButton.Visible = True
        Orange.Visible = False
        Dr.Visible = False
        Sprite.Visible = False
        Lemonade.Visible = False
        Iced.Visible = False
        RichTextBox1.Visible = False
        PictureBox1.Visible = True
        PictureBox1.Image = Asg_1_5.My.Resources.Resources.SuperSalad

    End Sub

    Private Sub Drink_Click(sender As Object, e As EventArgs) Handles DrinkButton.Click     'where you order your drink
        What.Visible = True
        What.Text = "Select Drink"
        PizzaButton.Visible = False
        DrinkButton.Visible = False
        AppetizerButton.Visible = False
        P1Button.Visible = False
        P2Button.Visible = False
        P3Button.Visible = False
        P4Button.Visible = False
        P5Button.Visible = False
        ItalianSalad.Visible = False
        BaconButton.Visible = False
        PizzaSlop.Visible = False
        MinestroneButton.Visible = False
        HouseButton.Visible = False
        Orange.Visible = True
        Dr.Visible = True
        Sprite.Visible = True
        Lemonade.Visible = True
        Iced.Visible = True
        RichTextBox1.Visible = False
        PictureBox1.Visible = True
        PictureBox1.Image = Asg_1_5.My.Resources.Resources.Drinks
    End Sub




    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        What.Visible = True
        What.Text = "select order"
        PizzaButton.Visible = True
        DrinkButton.Visible = True
        AppetizerButton.Visible = True
        P1Button.Visible = False
        P2Button.Visible = False
        P3Button.Visible = False
        P4Button.Visible = False
        P5Button.Visible = False
        PictureBox1.Visible = False
        ItalianSalad.Visible = False
        BaconButton.Visible = False
        PizzaSlop.Visible = False
        MinestroneButton.Visible = False
        HouseButton.Visible = False
        Orange.Visible = False
        Dr.Visible = False
        Sprite.Visible = False
        Lemonade.Visible = False
        Iced.Visible = False
        RichTextBox1.Visible = False
        Op()

    End Sub



    Private Sub P1Button_Click(sender As Object, e As EventArgs) Handles P1Button.Click     'Pizza Events p1 - p5
        autumns = (1 + autumns)
        Op()
    End Sub

    Private Sub P2Button_Click(sender As Object, e As EventArgs) Handles P2Button.Click
        petes = (1 + petes)
        Op()
    End Sub
    Private Sub P3Button_Click(sender As Object, e As EventArgs) Handles P3Button.Click
        singers = (1 + singers)
        Op()
    End Sub
    Private Sub P4Button_Click(sender As Object, e As EventArgs) Handles P4Button.Click
        gweniths = (1 + gweniths)
        Op()
    End Sub

    Private Sub P5Button_Click(sender As Object, e As EventArgs) Handles P5Button.Click
        kylis = (1 + kylis)
        Op()
    End Sub

    Private Sub BaconButton_Click(sender As Object, e As EventArgs) Handles BaconButton.Click
        baconPotato = (1 + baconPotato)
        Op()
    End Sub

    Private Sub MinestroneButton_Click(sender As Object, e As EventArgs) Handles MinestroneButton.Click
        minestore = (1 + minestore)
        Op()
    End Sub

    Private Sub PizzaSlop_Click(sender As Object, e As EventArgs) Handles PizzaSlop.Click
        pizzaSoup = (1 + pizzaSoup)
        Op()
    End Sub

    Private Sub ItalianSalad_Click(sender As Object, e As EventArgs) Handles ItalianSalad.Click
        italiangreens = (1 + italiangreens)
        Op()
    End Sub

    Private Sub HouseButton_Click(sender As Object, e As EventArgs) Handles HouseButton.Click
        houseSalad = (1 + houseSalad)
        Op()
    End Sub
    Private Sub Dr_Click(sender As Object, e As EventArgs) Handles Dr.Click
        Pepper = (1 + Pepper)
        Op()
    End Sub

    Private Sub Orange_Click(sender As Object, e As EventArgs) Handles Orange.Click
        Oranges = (1 + Oranges)
        Op()
    End Sub

    Private Sub Sprite_Click(sender As Object, e As EventArgs) Handles Sprite.Click
        Spirite = (1 + Spirite)
        Op()
    End Sub

    Private Sub Lemonade_Click(sender As Object, e As EventArgs) Handles Lemonade.Click
        aid = (1 + aid)
        Op()
    End Sub

    Private Sub Iced_Click(sender As Object, e As EventArgs) Handles Iced.Click
        tea = (1 + tea)
        Op()
    End Sub

    Sub order()
        If tea2 > 0 Then
            detail = ("Iced Tea = " & " " & tea2 & detail)
        End If
        If aid2 > 0 Then
            detail = ("Lemonade = " & " " & aid2 & detail)
        End If
        If Spirite2 > 0 Then
            detail = ("Sprite = " & " " & Spirite2 & detail)
        End If
        If Oranges2 > 0 Then
            detail = ("Orange Soda = " & " " & Oranges2 & detail)
        End If
        If Pepper2 > 0 Then
            detail = ("Dr.Pepper = " & " " & Pepper2 & detail)
        End If
        If houseSalad2 > 0 Then
            detail = ("House Salad = " & " " & houseSalad2 & detail)
        End If
        If italiangreens2 > 0 Then
            detail = ("Italian Salad = " & " " & italiangreens2 & detail)
        End If
        If pizzaSoup2 > 0 Then
            detail = ("Pizza Slop Soup = " & " " & pizzaSoup2 & detail)
        End If
        If minestore2 > 0 Then
            detail = ("Minestrone Soup = " & " " & minestore2 & detail)
        End If
        If baconPotato2 > 0 Then
            detail = ("Bacon Potato Soup = " & " " & baconPotato2 & detail)
        End If
        If kylis2 > 0 Then
            detail = ("Kylis Pizza = " & " " & kylis2 & detail)
        End If
        If gweniths2 > 0 Then
            detail = ("Gweniths Pizza = " & " " & gweniths2 & detail)
        End If
        If singers2 > 0 Then
            detail = ("sinigers Pizza = " & " " & singers2 & detail)
        End If
        If petes2 > 0 Then
            detail = ("Petes Pizza = " & " " & petes2 & detail)
        End If
        If autumns2 > 0 Then
            detail = ("Autumns Pizza = " & " " & autumns2 & detail)
        End If
        What.Visible = False
        PizzaButton.Visible = False
        DrinkButton.Visible = False
        AppetizerButton.Visible = False
        P1Button.Visible = False
        P2Button.Visible = False
        P3Button.Visible = False
        P4Button.Visible = False
        P5Button.Visible = False
        ItalianSalad.Visible = False
        BaconButton.Visible = False
        PizzaSlop.Visible = False
        MinestroneButton.Visible = False
        HouseButton.Visible = False
        Orange.Visible = False
        Dr.Visible = False
        Sprite.Visible = False
        Lemonade.Visible = False
        Iced.Visible = False
        PictureBox1.Visible = False
        RichTextBox1.Visible = True
        RichTextBox1.Text = detail
        bring = 0
        detail = ""


    End Sub

    Sub Op()                                                'This is the operator sub routine which holds data for each variable

        tea2 = tea
        Console.WriteLine(tea2)
        Spirite2 = Spirite
        Console.WriteLine(Spirite2)
        aid2 = aid
        Console.WriteLine(aid2)
        Oranges2 = Oranges
        Console.WriteLine(Oranges2)
        Pepper2 = Pepper
        Console.WriteLine(Pepper2)
        houseSalad2 = houseSalad
        Console.WriteLine(houseSalad2)
        italiangreens2 = italiangreens
        'Console.WriteLine(italiangreens2)
        pizzaSoup2 = pizzaSoup
        ' Console.WriteLine(pizzaSoup2)
        minestore2 = minestore
        'Console.WriteLine(minestore2)
        baconPotato2 = baconPotato
        'Console.WriteLine(baconPotato2)
        kylis2 = kylis
        ' Console.WriteLine(kylis2)
        gweniths2 = gweniths
        Console.WriteLine(gweniths2)
        singers2 = singers
        Console.WriteLine(singers2)
        petes2 = petes
        Console.WriteLine(petes2)
        autumns2 = autumns
        'Console.WriteLine(autumns2)
        If bring = 1 Then
            order()
        End If

    End Sub
    Private Sub Details_Click(sender As Object, e As EventArgs) Handles Details.Click
        bring = 1
        Op()
    End Sub


End Class
