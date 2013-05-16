Public Class Functions
    Public Shared Sub PopulationChange(ByVal num)
        Dim popCap As Decimal = Time2Explore.populationCap.GetAmount
        Dim population As Decimal = Time2Explore.population.GetAmount

        Dim PopulationChange = population + num
        If PopulationChange > popCap Then
            Time2Explore.population.SetAmount(popCap)
        End If
        Time2Explore.population.ChangeAmount(num)
    End Sub

    Public Shared Function PopulationCap()
        Dim popCap As Decimal = 1.6 * (TownCenter.population + Hut.population * Hut.owned + RV.population * RV.owned + Prefab.population * Prefab.owned + Shack.population * Shack.owned + Bungalo.population * Bungalo.owned + SmallHouse.population * SmallHouse.owned + MediumHouse.population * MediumHouse.owned + LargeHouse.population * LargeHouse.owned + MansionHouse.population * MansionHouse.owned)
        Return popCap
    End Function
End Class
