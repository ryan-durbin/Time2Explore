Public Class Building


    Public Shared hut As Integer = 0
    Public Shared rv As Integer = 0
    Public Shared preFab As Integer = 0

    Public Shared shack As Integer = 0
    Public Shared bungalo As Integer = 0

    Public Shared smallHouse As Integer = 0
    Public Shared mediumHouse As Integer = 0
    Public Shared largeHouse As Integer = 0
    Public Shared mansionHouse As Integer = 0

    Public Shared riverWater As Integer = 2
    Public Shared waterWell As Integer = 0
    Public Shared waterTower As Integer = 0
    Public Shared waterPump As Integer = 0

    Public Shared cornField As Integer = 0
    Public Shared wheatField As Integer = 0

    Public Shared stoneMill As Integer = 0
    Public Shared windMill As Integer = 0
    Public Shared waterMill As Integer = 0
    Public Shared steamMill As Integer = 0

    Public Shared breadFireOven As Integer = 0
    Public Shared breadBakery As Integer = 0
    Public Shared breadFactory As Integer = 0

End Class

Public Class TownCenter
    ''incriment population that towncenter gives by default
    'Dim popRate As Decimal = 0.1 'rate per cycle
    Public Shared population As Decimal = 20
    'Dim popCap As Decimal = Time2Explore.populationCap

    '    If population < popCap Then
    '        population = population + popRate / 60 'DEVIDE BY 60 TO MAKE THE RATE CORRECT PER MINUTE FOR UPDATE ON THE SECOND
    '        Time2Explore.population = population
    '    End If

    ''increment food
    'Dim foodRate As Decimal = 10
    'Dim food As Decimal = Time2Explore.food.GetAmount()

    '    Time2Explore.food.GetAmount() = food + foodRate


    ''increments
End Class


Public Class Tent
    'The number of buildings of this type owned in the game.
    'This is the number that increases and decreases upon purchase and selling
    Public Shared owned As Integer = 10

    'The number of population this building gives per unit.
    Public Shared population As Decimal = 2

    'This is the rate of population gain per minutes per building and the amount of food each person requres for the buiding to continue producing.
    Public Shared rate As Decimal = 0.01

    'This the amount of prestige each building will give towards the final score.
    Public Shared prestige As Decimal = 1

    'The technologies required for purchase.
    Public Shared techReq() As String = {}

    Public Shared Function HasAmount(ByVal num)
        If owned >= num Then
            Return True
        Else
            Return False
        End If
    End Function

    'SUB that runs every second 
    Public Shared Sub Update()
        Dim maxFeed As Integer = Convert.ToInt32(Time2Explore.food.GetAmount() / rate)

        Dim max As Integer

        If maxFeed <= owned Then 'sets the max number of population that can be supported.
            max = maxFeed
            max = max + Time2Explore.food.GetAmount() * (-1)
            'highlight red
        Else
            max = owned
        End If
        Dim change = max * rate
        Time2Explore.food.ChangeAmount(-change)
        If Time2Explore.food.GetAmount() < 0 Then
            Time2Explore.food.SetAmount(0)
        End If
        Functions.PopulationChange(change)
    End Sub

    Public Shared Sub Buy(ByVal num)
        If Time2Explore.wood.HasAmount(3) Then
            Time2Explore.wood.ChangeAmount(-3)
            owned = owned + 1
        ElseIf Time2Explore.tree.HasAmount(1) Then
            Time2Explore.tree.ChangeAmount(-1)
            owned = owned + 1
        Else
            'blink red
        End If
    End Sub

    Public Shared Sub Sell(ByVal num)
        'recycle nothing
    End Sub
End Class

Public Class Hut
    'The number of buildings of this type owned in the game.
    'This is the number that increases and decreases upon purchase and selling
    Public Shared owned As Integer = 1

    'The number of population this building gives per unit.
    Public Shared population As Decimal = 3

    'This is the rate of population gain per minutes per building and the amount of food each person requres for the buiding to continue producing.
    Public Shared rate As Decimal = 0.02

    'This the amount of prestige each building will give towards the final score.
    Public Shared prestige As Decimal = 1

    'The technologies required for purchase.
    Public Shared techReq() As String = {}

    Public Shared Function HasAmount(ByVal num)
        If owned >= num Then
            Return True
        Else
            Return False
        End If
    End Function

    'SUB that runs every second 
    Public Shared Sub Update()
        Dim maxFeed As Integer = Convert.ToInt32(Time2Explore.food.GetAmount() / rate)
        Dim max As Integer

        If maxFeed <= owned Then 'sets the max number of population that can be supported.
            max = maxFeed
            max = max + Time2Explore.food.GetAmount() * (-1)
            'highlight red
        Else
            max = owned
        End If
        Dim change = max * rate
        Time2Explore.food.ChangeAmount(-change)
        If Time2Explore.food.GetAmount() < 0 Then
            Time2Explore.food.SetAmount(0)
        End If
        Functions.PopulationChange(change)
    End Sub

    Public Shared Sub Buy(ByVal num)
        If Time2Explore.wood.HasAmount(10) And
            Tent.HasAmount(1) And
            Time2Explore.population.HasAmount(1) Then

            Time2Explore.wood.ChangeAmount(-10)
            Tent.owned = Tent.owned - 1
            Time2Explore.population.ChangeAmount(-1)

            owned = owned + 1
        End If
    End Sub

    Public Shared Sub Sell(ByVal num)
        owned = owned - 1
        Tent.owned = Tent.owned + 1
        Time2Explore.population.ChangeAmount(1)
    End Sub
End Class

Public Class RV
    'The number of buildings of this type owned in the game.
    'This is the number that increases and decreases upon purchase and selling
    Public Shared owned As Integer = 0

    'The number of population this building gives per unit.
    Public Shared population As Decimal = 4

    'This is the rate of population gain per minutes per building and the amount of food each person requres for the buiding to continue producing.
    Public Shared rate As Decimal = 0.015

    'This the amount of prestige each building will give towards the final score.
    Public Shared prestige As Decimal = 1

    'The technologies required for purchase.
    Public Shared techReq() As String = {"Vehicle"}

    Public Shared Function HasAmount(ByVal num)
        If owned >= num Then
            Return True
        Else
            Return False
        End If
    End Function

    'SUB that runs every second 
    Public Shared Sub Update()
        Dim maxFeed As Integer = Convert.ToInt32(Time2Explore.food.GetAmount() / rate)
        Dim max As Integer

        If maxFeed <= owned Then 'sets the max number of population that can be supported.
            max = maxFeed
            max = max + Time2Explore.food.GetAmount() * (-1)
            'highlight red
        Else
            max = owned
        End If
        Dim change = max * rate
        Time2Explore.food.ChangeAmount(-change)
        If Time2Explore.food.GetAmount() < 0 Then
            Time2Explore.food.SetAmount(0)
        End If
        Functions.PopulationChange(change)
    End Sub

    Public Shared Sub Buy(ByVal num)
        If Time2Explore.wood.HasAmount(20) And
            Hut.HasAmount(1) And
            Time2Explore.population.HasAmount(1) Then

            Time2Explore.wood.ChangeAmount(-20)
            Hut.owned = Hut.owned - 1
            Time2Explore.population.ChangeAmount(-1)

            owned = owned + 1
        End If
    End Sub

    Public Shared Sub Sell(ByVal num)
        'recycle 1 hut
        owned = owned - 1
        Hut.owned = Hut.owned + 1
        Time2Explore.population.ChangeAmount(1)
    End Sub
End Class

Public Class Prefab
    'The number of buildings of this type owned in the game.
    'This is the number that increases and decreases upon purchase and selling
    Public Shared owned As Integer = 0

    'The number of population this building gives per unit.
    Public Shared population As Decimal = 4

    'This is the rate of population gain per minutes per building and the amount of food each person requres for the buiding to continue producing.
    Public Shared rate As Decimal = 0.022

    'This the amount of prestige each building will give towards the final score.
    Public Shared prestige As Decimal = 2

    'The technologies required for purchase.
    Public Shared techReq() As String = {"Vehicle"}

    Public Shared Function HasAmount(ByVal num)
        If owned >= num Then
            Return True
        Else
            Return False
        End If
    End Function

    'SUB that runs every second 
    Public Shared Sub Update()
        Dim maxFeed As Integer = Convert.ToInt32(Time2Explore.food.GetAmount() / rate)
        Dim max As Integer

        If maxFeed <= owned Then 'sets the max number of population that can be supported.
            max = maxFeed
            max = max + Time2Explore.food.GetAmount() * (-1)
            'highlight red
        Else
            max = owned
        End If
        Dim change = max * rate
        Time2Explore.food.ChangeAmount(-change)
        If Time2Explore.food.GetAmount() < 0 Then
            Time2Explore.food.SetAmount(0)
        End If
        Functions.PopulationChange(change)
    End Sub

    Public Shared Sub Buy(ByVal num)
        If Time2Explore.wood.HasAmount(40) And
            RV.HasAmount(1) And
            Time2Explore.population.HasAmount(1) Then

            Time2Explore.wood.ChangeAmount(-40)
            RV.owned = RV.owned - 1
            Time2Explore.population.ChangeAmount(-1)

            owned = owned + 1
        End If
    End Sub

    Public Shared Sub Sell(ByVal num)
        owned = owned - 1
        RV.owned = RV.owned + 1
        Time2Explore.population.ChangeAmount(1)
    End Sub
End Class

Public Class Shack
    'The number of buildings of this type owned in the game.
    'This is the number that increases and decreases upon purchase and selling
    Public Shared owned As Integer = 0

    'The number of population this building gives per unit.
    Public Shared population As Decimal = 3

    'This is the rate of population gain per minutes per building and the amount of food each person requres for the buiding to continue producing.
    Public Shared rate As Decimal = 0.02

    'This the amount of prestige each building will give towards the final score.
    Public Shared prestige As Decimal = 2

    'The technologies required for purchase.
    Public Shared techReq() As String = {"Village"}

    Public Shared Function HasAmount(ByVal num)
        If owned >= num Then
            Return True
        Else
            Return False
        End If
    End Function

    'SUB that runs every second 
    Public Shared Sub Update()
        Dim maxFeed As Integer = Convert.ToInt32(Time2Explore.food.GetAmount() / rate)
        Dim max As Integer

        If maxFeed <= owned Then 'sets the max number of population that can be supported.
            max = maxFeed
            max = max + Time2Explore.food.GetAmount() * (-1)
            'highlight red
        Else
            max = owned
        End If
        Dim change = max * rate
        Time2Explore.food.ChangeAmount(-change)
        If Time2Explore.food.GetAmount() < 0 Then
            Time2Explore.food.SetAmount(0)
        End If
        Functions.PopulationChange(change)
    End Sub

    Public Shared Sub Buy(ByVal num)
        If Time2Explore.wood.HasAmount(40) And
            Time2Explore.stone.HasAmount(40) And
            Time2Explore.population.HasAmount(1) Then

            Time2Explore.wood.ChangeAmount(-40)
            Time2Explore.stone.ChangeAmount(-40)
            Time2Explore.population.ChangeAmount(-1)

            owned = owned + 1
        End If
    End Sub

    Public Shared Sub Sell(ByVal num)
        owned = owned - 1
        Time2Explore.wood.ChangeAmount(10)
        Time2Explore.stone.ChangeAmount(40)
        Time2Explore.population.ChangeAmount(1)
    End Sub
End Class

Public Class Bungalo
    'The number of buildings of this type owned in the game.
    'This is the number that increases and decreases upon purchase and selling
    Public Shared owned As Integer = 0

    'The number of population this building gives per unit.
    Public Shared population As Decimal = 5

    'This is the rate of population gain per minutes per building and the amount of food each person requres for the buiding to continue producing.
    Public Shared rate As Decimal = 0.025

    'This the amount of prestige each building will give towards the final score.
    Public Shared prestige As Decimal = 5

    'The technologies required for purchase.
    Public Shared techReq() As String = {"Village"}

    Public Shared Function HasAmount(ByVal num)
        If owned >= num Then
            Return True
        Else
            Return False
        End If
    End Function

    'SUB that runs every second 
    Public Shared Sub Update()
        Dim maxFeed As Integer = Convert.ToInt32(Time2Explore.food.GetAmount() / rate)
        Dim max As Integer

        If maxFeed <= owned Then 'sets the max number of population that can be supported.
            max = maxFeed
            max = max + Time2Explore.food.GetAmount() * (-1)
            'highlight red
        Else
            max = owned
        End If
        Dim change = max * rate
        Time2Explore.food.ChangeAmount(-change)
        If Time2Explore.food.GetAmount() < 0 Then
            Time2Explore.food.SetAmount(0)
        End If
        Functions.PopulationChange(change)
    End Sub

    Public Shared Sub Buy(ByVal num)
        If Time2Explore.wood.HasAmount(100) And
            Time2Explore.stone.HasAmount(100) And
            Shack.HasAmount(1) And
            Time2Explore.population.HasAmount(1) Then

            Time2Explore.wood.ChangeAmount(-100)
            Time2Explore.stone.ChangeAmount(-100)
            Shack.owned = Shack.owned - 1
            Time2Explore.population.ChangeAmount(-1)

            owned = owned + 1
        End If
    End Sub

    Public Shared Sub Sell(ByVal num)
        owned = owned - 1
        Time2Explore.wood.ChangeAmount(40)
        Time2Explore.stone.ChangeAmount(80)
        Shack.owned = Shack.owned + 1
        Time2Explore.population.ChangeAmount(1)
    End Sub
End Class

Public Class SmallHouse
    'The number of buildings of this type owned in the game.
    'This is the number that increases and decreases upon purchase and selling
    Public Shared owned As Integer = 0

    'The number of population this building gives per unit.
    Public Shared population As Decimal = 4

    'This is the rate of population gain per minutes per building and the amount of food each person requres for the buiding to continue producing.
    Public Shared rate As Decimal = 0.05

    'This the amount of prestige each building will give towards the final score.
    Public Shared prestige As Decimal = 10

    'The technologies required for purchase.
    Public Shared techReq() As String = {"Education"}

    Public Shared Function HasAmount(ByVal num)
        If owned >= num Then
            Return True
        Else
            Return False
        End If
    End Function

    'SUB that runs every second 
    Public Shared Sub Update()
        Dim maxFeed As Integer = Convert.ToInt32(Time2Explore.food.GetAmount() / rate)
        Dim max As Integer

        If maxFeed <= owned Then 'sets the max number of population that can be supported.
            max = maxFeed
            max = max + Time2Explore.food.GetAmount() * (-1)
            'highlight red
        Else
            max = owned
        End If
        Dim change = max * rate
        Time2Explore.food.ChangeAmount(-change)
        If Time2Explore.food.GetAmount() < 0 Then
            Time2Explore.food.SetAmount(0)
        End If
        Functions.PopulationChange(change)
    End Sub

    Public Shared Sub Buy(ByVal num)
        If Time2Explore.wood.HasAmount(100) And
            Time2Explore.stone.HasAmount(100) And
            Time2Explore.population.HasAmount(1) Then

            Time2Explore.wood.ChangeAmount(-100)
            Time2Explore.stone.ChangeAmount(-100)
            Time2Explore.population.ChangeAmount(-1)

            owned = owned + 1
        End If
    End Sub

    Public Shared Sub Sell(ByVal num)
        owned = owned - 1
        Time2Explore.wood.ChangeAmount(40)
        Time2Explore.stone.ChangeAmount(50)
        Time2Explore.population.ChangeAmount(1)
    End Sub
End Class

Public Class MediumHouse
    'The number of buildings of this type owned in the game.
    'This is the number that increases and decreases upon purchase and selling
    Public Shared owned As Integer = 0

    'The number of population this building gives per unit.
    Public Shared population As Decimal = 6

    'This is the rate of population gain per minutes per building and the amount of food each person requres for the buiding to continue producing.
    Public Shared rate As Decimal = 0.065

    'This the amount of prestige each building will give towards the final score.
    Public Shared prestige As Decimal = 16

    'The technologies required for purchase.
    Public Shared techReq() As String = {"Education"}

    Public Shared Function HasAmount(ByVal num)
        If owned >= num Then
            Return True
        Else
            Return False
        End If
    End Function

    'SUB that runs every second 
    Public Shared Sub Update()
        Dim maxFeed As Integer = Convert.ToInt32(Time2Explore.food.GetAmount() / rate)
        Dim max As Integer

        If maxFeed <= owned Then 'sets the max number of population that can be supported.
            max = maxFeed
            max = max + Time2Explore.food.GetAmount() * (-1)
            'highlight red
        Else
            max = owned
        End If
        Dim change = max * rate
        Time2Explore.food.ChangeAmount(-change)
        If Time2Explore.food.GetAmount() < 0 Then
            Time2Explore.food.SetAmount(0)
        End If
        Functions.PopulationChange(change)
    End Sub

    Public Shared Sub Buy(ByVal num)
        If Time2Explore.wood.HasAmount(200) And
            Time2Explore.stone.HasAmount(110) And
            Time2Explore.population.HasAmount(1) Then

            Time2Explore.wood.ChangeAmount(-200)
            Time2Explore.stone.ChangeAmount(-110)
            Time2Explore.population.ChangeAmount(-1)

            owned = owned + 1
        End If
    End Sub

    Public Shared Sub Sell(ByVal num)
        owned = owned - 1
        Time2Explore.wood.ChangeAmount(50)
        Time2Explore.stone.ChangeAmount(50)
        Time2Explore.population.ChangeAmount(1)
    End Sub
End Class

Public Class LargeHouse
    'The number of buildings of this type owned in the game.
    'This is the number that increases and decreases upon purchase and selling
    Public Shared owned As Integer = 0

    'The number of population this building gives per unit.
    Public Shared population As Decimal = 8

    'This is the rate of population gain per minutes per building and the amount of food each person requres for the buiding to continue producing.
    Public Shared rate As Decimal = 0.125

    'This the amount of prestige each building will give towards the final score.
    Public Shared prestige As Decimal = 25

    'The technologies required for purchase.
    Public Shared techReq() As String = {"Education"}

    Public Shared Function HasAmount(ByVal num)
        If owned >= num Then
            Return True
        Else
            Return False
        End If
    End Function

    'SUB that runs every second 
    Public Shared Sub Update()
        Dim maxFeed As Integer = Convert.ToInt32(Time2Explore.food.GetAmount() / rate)
        Dim max As Integer

        If maxFeed <= owned Then 'sets the max number of population that can be supported.
            max = maxFeed
            max = max + Time2Explore.food.GetAmount() * (-1)
            'highlight red
        Else
            max = owned
        End If
        Dim change = max * rate
        Time2Explore.food.ChangeAmount(-change)
        If Time2Explore.food.GetAmount() < 0 Then
            Time2Explore.food.SetAmount(0)
        End If
        Functions.PopulationChange(change)
    End Sub

    Public Shared Sub Buy(ByVal num)
        If Time2Explore.wood.HasAmount(500) And
            Time2Explore.stone.HasAmount(300) And
            Time2Explore.population.HasAmount(1) Then

            Time2Explore.wood.ChangeAmount(-500)
            Time2Explore.stone.ChangeAmount(-300)
            Time2Explore.population.ChangeAmount(-1)

            owned = owned + 1
        End If
    End Sub

    Public Shared Sub Sell(ByVal num)
        owned = owned - 1
        Time2Explore.wood.ChangeAmount(100)
        Time2Explore.stone.ChangeAmount(200)
        Time2Explore.population.ChangeAmount(1)
    End Sub
End Class

Public Class MansionHouse
    'The number of buildings of this type owned in the game.
    'This is the number that increases and decreases upon purchase and selling
    Public Shared owned As Integer = 0

    'The number of population this building gives per unit.
    Public Shared population As Decimal = 12

    'This is the rate of population gain per minutes per building and the amount of food each person requres for the buiding to continue producing.
    Public Shared rate As Decimal = 0.075

    'This the amount of prestige each building will give towards the final score.
    Public Shared prestige As Decimal = 50

    'The technologies required for purchase.
    Public Shared techReq() As String = {"Education", "prestige>7500"}

    Public Shared Function HasAmount(ByVal num)
        If owned >= num Then
            Return True
        Else
            Return False
        End If
    End Function

    'SUB that runs every second 
    Public Shared Sub Update()
        Dim maxFeed As Integer = Convert.ToInt32(Time2Explore.food.GetAmount() / rate)
        Dim max As Integer

        If maxFeed <= owned Then 'sets the max number of population that can be supported.
            max = maxFeed
            max = max + Time2Explore.food.GetAmount() * (-1)
            'highlight red
        Else
            max = owned
        End If
        Dim change = max * rate
        Time2Explore.food.ChangeAmount(-change)
        If Time2Explore.food.GetAmount() < 0 Then
            Time2Explore.food.SetAmount(0)
        End If
        Functions.PopulationChange(change)
    End Sub

    Public Shared Sub Buy(ByVal num)
        If Time2Explore.wood.HasAmount(1000) And
            Time2Explore.stone.HasAmount(1250) And
            Time2Explore.population.HasAmount(1) Then

            Time2Explore.wood.ChangeAmount(-1000)
            Time2Explore.stone.ChangeAmount(-1250)
            Time2Explore.population.ChangeAmount(-1)

            owned = owned + 1
        End If
    End Sub

    Public Shared Sub Sell(ByVal num)
        owned = owned - 1
        Time2Explore.wood.ChangeAmount(500)
        Time2Explore.stone.ChangeAmount(700)
        Time2Explore.population.ChangeAmount(1)
    End Sub
End Class