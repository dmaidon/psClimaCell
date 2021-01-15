
Imports System.Text.Json.Serialization

Public Class Rootobject

    <JsonPropertyName("cloudbase")>
    Public Property CloudBase As String
    Public Property cloudCeiling As String
    Public Property cloudCover As String
    Public Property dewPoint As String

    <JsonPropertyName("epaHealthConcern")>
    Public Property EpaHealthConcern As EpaHealthConcern
    Public Property epaIndex As String
    Public Property epaPrimaryPollutant As Epaprimarypollutant
    Public Property fireIndex As String
    Public Property grassGrassIndex As Grassgrassindex
    Public Property grassIndex As Grassindex
    Public Property hailBinary As String
    Public Property humidity As String
    Public Property mepHealthConcern As Mephealthconcern
    Public Property mepIndex As String
    Public Property mepPrimaryPollutant As Mepprimarypollutant
    Public Property moonPhase As Moonphase
    Public Property particulateMatter10 As String
    Public Property particulateMatter25 As String
    Public Property pollutantCO As String
    Public Property pollutantNO2 As String
    Public Property pollutantO3 As String
    Public Property pollutantSO2 As String
    Public Property precipitationIntensity As String
    Public Property precipitationProbability As String
    Public Property precipitationType As Precipitationtype
    Public Property pressureSeaLevel As String
    Public Property pressureSurfaceLevel As String
    Public Property solarDIF As String
    Public Property solarDIR As String
    Public Property solarGHI As String
    Public Property temperature As String
    Public Property temperatureApparent As String
    Public Property treeAcacia As Treeacacia
    Public Property treeAsh As Treeash
    Public Property treeBeech As Treebeech
    Public Property treeBirch As Treebirch
    Public Property treeCedar As Treecedar
    Public Property treeCottonwood As Treecottonwood
    Public Property treeCypress As Treecypress
    Public Property treeElder As Treeelder
    Public Property treeElm As Treeelm
    Public Property treeHemlock As Treehemlock
    Public Property treeHickory As Treehickory
    Public Property treeIndex As Treeindex
    Public Property treeJuniper As Treejuniper
    Public Property treeMahagony As Treemahagony
    Public Property treeMaple As Treemaple
    Public Property treeMulberry As Treemulberry
    Public Property treeOak As Treeoak
    Public Property treePine As Treepine
    Public Property treeSpruce As Treespruce
    Public Property treeSycamore As Treesycamore
    Public Property treeWalnut As Treewalnut
    Public Property treeWillow As Treewillow
    Public Property visibility As String
    Public Property weatherCode As Weathercode
    Public Property weedGrassweedIndex As Weedgrassweedindex
    Public Property weedIndex As Weedindex
    Public Property windDirection As String
    Public Property windGust As String
    Public Property windSpeed As String
End Class

Public Class EpaHealthConcern

    <JsonPropertyName("_0")> Public Property P0 As String

    <JsonPropertyName("_1")> Public Property P1 As String

    <JsonPropertyName("_2")> Public Property P2 As String

    <JsonPropertyName("_3")> Public Property P3 As String

    <JsonPropertyName("_4")> Public Property P4 As String

    <JsonPropertyName("_5")> Public Property P5 As String
End Class

Public Class Epaprimarypollutant
    Public Property _0 As String
    Public Property _1 As String
    Public Property _2 As String
    Public Property _3 As String
    Public Property _4 As String
    Public Property _5 As String
End Class

Public Class Grassgrassindex
    Public Property _0 As String
    Public Property _1 As String
    Public Property _2 As String
    Public Property _3 As String
    Public Property _4 As String
    Public Property _5 As String
End Class

Public Class Grassindex
    Public Property _0 As String
    Public Property _1 As String
    Public Property _2 As String
    Public Property _3 As String
    Public Property _4 As String
    Public Property _5 As String
End Class

Public Class Mephealthconcern
    Public Property _0 As String
    Public Property _1 As String
    Public Property _2 As String
    Public Property _3 As String
    Public Property _4 As String
    Public Property _5 As String
End Class

Public Class Mepprimarypollutant
    Public Property _0 As String
    Public Property _1 As String
    Public Property _2 As String
    Public Property _3 As String
    Public Property _4 As String
    Public Property _5 As String
End Class

Public Class Moonphase
    Public Property _0 As String
    Public Property _1 As String
    Public Property _2 As String
    Public Property _3 As String
    Public Property _4 As String
    Public Property _5 As String
    Public Property _6 As String
    Public Property _7 As String
End Class

Public Class Precipitationtype
    Public Property _0 As String
    Public Property _1 As String
    Public Property _2 As String
    Public Property _3 As String
    Public Property _4 As String
End Class

Public Class Treeacacia
    Public Property _0 As String
    Public Property _1 As String
    Public Property _2 As String
    Public Property _3 As String
    Public Property _4 As String
    Public Property _5 As String
End Class

Public Class Treeash
    Public Property _0 As String
    Public Property _1 As String
    Public Property _2 As String
    Public Property _3 As String
    Public Property _4 As String
    Public Property _5 As String
End Class

Public Class Treebeech
    Public Property _0 As String
    Public Property _1 As String
    Public Property _2 As String
    Public Property _3 As String
    Public Property _4 As String
    Public Property _5 As String
End Class

Public Class Treebirch
    Public Property _0 As String
    Public Property _1 As String
    Public Property _2 As String
    Public Property _3 As String
    Public Property _4 As String
    Public Property _5 As String
End Class

Public Class Treecedar
    Public Property _0 As String
    Public Property _1 As String
    Public Property _2 As String
    Public Property _3 As String
    Public Property _4 As String
    Public Property _5 As String
End Class

Public Class Treecottonwood
    Public Property _0 As String
    Public Property _1 As String
    Public Property _2 As String
    Public Property _3 As String
    Public Property _4 As String
    Public Property _5 As String
End Class

Public Class Treecypress
    Public Property _0 As String
    Public Property _1 As String
    Public Property _2 As String
    Public Property _3 As String
    Public Property _4 As String
    Public Property _5 As String
End Class

Public Class Treeelder
    Public Property _0 As String
    Public Property _1 As String
    Public Property _2 As String
    Public Property _3 As String
    Public Property _4 As String
    Public Property _5 As String
End Class

Public Class Treeelm
    Public Property _0 As String
    Public Property _1 As String
    Public Property _2 As String
    Public Property _3 As String
    Public Property _4 As String
    Public Property _5 As String
End Class

Public Class Treehemlock
    Public Property _0 As String
    Public Property _1 As String
    Public Property _2 As String
    Public Property _3 As String
    Public Property _4 As String
    Public Property _5 As String
End Class

Public Class Treehickory
    Public Property _0 As String
    Public Property _1 As String
    Public Property _2 As String
    Public Property _3 As String
    Public Property _4 As String
    Public Property _5 As String
End Class

Public Class Treeindex
    Public Property _0 As String
    Public Property _1 As String
    Public Property _2 As String
    Public Property _3 As String
    Public Property _4 As String
    Public Property _5 As String
End Class

Public Class Treejuniper
    Public Property _0 As String
    Public Property _1 As String
    Public Property _2 As String
    Public Property _3 As String
    Public Property _4 As String
    Public Property _5 As String
End Class

Public Class Treemahagony
    Public Property _0 As String
    Public Property _1 As String
    Public Property _2 As String
    Public Property _3 As String
    Public Property _4 As String
    Public Property _5 As String
End Class

Public Class Treemaple
    Public Property _0 As String
    Public Property _1 As String
    Public Property _2 As String
    Public Property _3 As String
    Public Property _4 As String
    Public Property _5 As String
End Class

Public Class Treemulberry
    Public Property _0 As String
    Public Property _1 As String
    Public Property _2 As String
    Public Property _3 As String
    Public Property _4 As String
    Public Property _5 As String
End Class

Public Class Treeoak
    Public Property _0 As String
    Public Property _1 As String
    Public Property _2 As String
    Public Property _3 As String
    Public Property _4 As String
    Public Property _5 As String
End Class

Public Class Treepine
    Public Property _0 As String
    Public Property _1 As String
    Public Property _2 As String
    Public Property _3 As String
    Public Property _4 As String
    Public Property _5 As String
End Class

Public Class Treespruce
    Public Property _0 As String
    Public Property _1 As String
    Public Property _2 As String
    Public Property _3 As String
    Public Property _4 As String
    Public Property _5 As String
End Class

Public Class Treesycamore
    Public Property _0 As String
    Public Property _1 As String
    Public Property _2 As String
    Public Property _3 As String
    Public Property _4 As String
    Public Property _5 As String
End Class

Public Class Treewalnut
    Public Property _0 As String
    Public Property _1 As String
    Public Property _2 As String
    Public Property _3 As String
    Public Property _4 As String
    Public Property _5 As String
End Class

Public Class Treewillow
    Public Property _0 As String
    Public Property _1 As String
    Public Property _2 As String
    Public Property _3 As String
    Public Property _4 As String
    Public Property _5 As String
End Class

Public Class Weathercode
    Public Property _0 As String
    Public Property _1000 As String
    Public Property _1001 As String
    Public Property _1100 As String
    Public Property _1101 As String
    Public Property _1102 As String
    Public Property _2000 As String
    Public Property _2100 As String
    Public Property _3000 As String
    Public Property _3001 As String
    Public Property _3002 As String
    Public Property _4000 As String
    Public Property _4001 As String
    Public Property _4200 As String
    Public Property _4201 As String
    Public Property _5000 As String
    Public Property _5001 As String
    Public Property _5100 As String
    Public Property _5101 As String
    Public Property _6000 As String
    Public Property _6001 As String
    Public Property _6200 As String
    Public Property _6201 As String
    Public Property _7000 As String
    Public Property _7101 As String
    Public Property _7102 As String
    Public Property _8000 As String
End Class

Public Class Weedgrassweedindex
    Public Property _0 As String
    Public Property _1 As String
    Public Property _2 As String
    Public Property _3 As String
    Public Property _4 As String
    Public Property _5 As String
End Class

Public Class Weedindex
    Public Property _0 As String
    Public Property _1 As String
    Public Property _2 As String
    Public Property _3 As String
    Public Property _4 As String
    Public Property _5 As String
End Class
