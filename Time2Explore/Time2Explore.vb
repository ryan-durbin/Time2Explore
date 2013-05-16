Public Class Time2Explore

    'declares multi threading
    'NOT USING MULTITHREADING YET


    'Initialize objects
    Dim Building As Building = New Building()
    Dim Functions As Functions = New Functions()
    'Dim Resource As Resources = New Resources

    Public Shared populationCap As Resources = New Resources()
    Public Shared population As Resources = New Resources()
    Public Shared prestige As Resources = New Resources()
    Public Shared gold As Resources = New Resources()
    Public Shared tree As Resources = New Resources()
    Public Shared wood As Resources = New Resources()
    Public Shared stone As Resources = New Resources()
    Public Shared food As Resources = New Resources()
    Public Shared water As Resources = New Resources()
    Public Shared wheat As Resources = New Resources()
    Public Shared bread As Resources = New Resources()
    Public Shared corn As Resources = New Resources()
    Public Shared pig As Resources = New Resources()
    Public Shared cow As Resources = New Resources()
    Public Shared meat As Resources = New Resources()

    'FPS counter
    Dim tSec As Integer = TimeOfDay.Second
    Dim tTicks As Integer = 0
    Dim maxTicks As Integer = 0

    'debug
    Dim i As Integer = 0
    Dim b As Integer = 0

    ' listbox array
    Public Shared BuildingListArray() As String = {"Tent", "River Water Well"}
    Public Shared ResourceListArray() As String = {"1", "2"}
    Dim indexMaxB As Integer
    Dim indexMaxR As Integer

    'Private Sub AddToBuildingListArray(ByVal BuildingToAddToArray) 'checks to see if building is already in list of buildings to be displayed
    '    For Each Str As String In BuildingListArray
    '        If Str.Contains(BuildingToAddToArray) Then
    '            'Do nothing
    '        Else
    '            indexMaxB = BuildingListArray.Length
    '            BuildingListArray(indexMaxB) = BuildingToAddToArray
    '        End If
    '    Next
    'End Sub

    'Private Sub AddToResourceListArray(ByVal ResourceToAddToArray) 'checks to see if Resource is already in list of buildings to be displayed
    '    For Each Str As String In ResourceListArray
    '        If Str.Contains(ResourceToAddToArray) Then
    '            'Do nothing
    '        Else
    '            indexMaxR = ResourceListArray.Length
    '            ResourceListArray(indexMaxR) = ResourceToAddToArray
    '        End If
    '    Next
    'End Sub


    Private Sub UpdateBuildingList()

    End Sub


    'Game Running?
    Dim isRunning As Boolean = True

    Private Sub Time2Explore_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'GAME INITIALIZES ON LOAD
        Me.Show()
        Me.Focus()

        Setup()
        'startst he game loop
        StartGameLoop()
    End Sub

    Private Sub StartGameLoop()
        Do While isRunning = True
            'Keep App Responsive
            Application.DoEvents()

            '1) check user input

            '2) Run AI

            '3) UPdate Object Data (Object positions, Status, Ect.)


            '4) Check triggers and conditoins
            TickCounter() 'ALSO HAS 1 SECOND EVENTS

            '5) Draw Graphics

            '6) Playing sound effects and music

        Loop
    End Sub

    Private Sub TickCounter()
        If tSec = TimeOfDay.Second And isRunning = True Then
            tTicks = tTicks + 1

        Else 'EVENTS THAT HAPPEN ONCE PER SECOND
            maxTicks = tTicks
            tTicks = 0
            tSec = TimeOfDay.Second
            cpsTextBox.Text = Format(maxTicks, "#,##0.00")
            OneSecond()
        End If 'END ONCE PER SECOND
    End Sub


    '*
    '* ONE SECOND 
    '*
    Private Sub OneSecond()
        Tent.Update()
        Hut.Update()
        RV.Update()
        Prefab.Update()
        Shack.Update()
        Bungalo.Update()
        SmallHouse.Update()
        MediumHouse.Update()
        LargeHouse.Update()
        MansionHouse.Update()

        'debug 1 second
        b = b + 1
        Label3.Text = b
        '
        Label5.Text = population.GetAmount
        Label4.Text = food.GetAmount
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'click event for play pause button
        If isRunning = True Then
            isRunning = False
            Button1.Text = "Play"
        Else
            isRunning = True
            Button1.Text = "Pause"
            StartGameLoop()
        End If

    End Sub

    Private Sub UpdatePurchaseButtons() 'updates purchase buttons visablility for all purchase buttons.  Calls each separately.
        UpdatePurchaseButtonsAvailablePlusOne()
        UpdatePurchaseButtonsAvailableMinusOne()
        UpdatePurchaseButtonsAvailablePlusTen()
        UpdatePurchaseButtonsAvailableMinusTen()
        UpdatePurchaseButtonsAvailablePlusAll()
        UpdatePurchaseButtonsAvailableMinusAll()
    End Sub

    Private Sub UpdatePurchaseButtonsAvailablePlusOne()

    End Sub

    Private Sub UpdatePurchaseButtonsAvailableMinusOne()

    End Sub

    Private Sub UpdatePurchaseButtonsAvailablePlusTen()

    End Sub

    Private Sub UpdatePurchaseButtonsAvailableMinusTen()

    End Sub

    Private Sub UpdatePurchaseButtonsAvailablePlusAll()

    End Sub

    Private Sub UpdatePurchaseButtonsAvailableMinusAll()

    End Sub

    Private Sub BuildingList()
        listBoxBuildings.Items.Clear()
        Dim length As Integer = BuildingListArray.Length - 1
        For count As Integer = 0 To length Step 1
            listBoxBuildings.Items.Add(BuildingListArray(count))
        Next
    End Sub
    Private Sub ResourceList()
        listBoxResources.Items.Clear()
        Dim length As Integer = ResourceListArray.Length - 1
        For count As Integer = 0 To length Step 1
            listBoxResources.Items.Add(ResourceListArray(count))
        Next
    End Sub

    Private Sub listBoxBuildings_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listBoxBuildings.SelectedIndexChanged

    End Sub

    Private Sub Setup()
        population.SetAmount(20)
        populationCap.SetAmount(30)
        food.SetAmount(21)
        wood.SetAmount(5)
        tree.SetAmount(5)
        gold.SetAmount(100)
    End Sub
End Class