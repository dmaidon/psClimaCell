Imports System.Text.Json.Serialization

Partial Public Class FieldUnitsModel
    Public Property CloudBase As String
    Public Property CloudCeiling As String
    Public Property CloudCover As String
    Public Property DewPoint As String
    Public Property EpaBgColor() As Dictionary(Of String, String)
    Public Property EpaFgColor() As Dictionary(Of String, String)
    Public Property EpaConcernText() As Dictionary(Of String, String)
    Public Property EpaHealthConcern() As Dictionary(Of String, String)
    Public Property EpaIndex As String
    Public Property EpaPrimaryPollutant() As Dictionary(Of String, String)
    Public Property FireIndex As String
    Public Property GrassGrassIndex() As Dictionary(Of String, String)
    Public Property GrassIndex() As Dictionary(Of String, String)
    Public Property HailBinary As String
    Public Property Humidity As String
    Public Property MepHealthConcern() As Dictionary(Of String, String)
    Public Property MepIndex As String
    Public Property MepPrimaryPollutant() As Dictionary(Of String, String)
    Public Property MoonPhase() As Dictionary(Of String, String)
    Public Property ParticulateMatter10() As String
    Public Property ParticulateMatter25() As String
    Public Property PollutantCO As String
    Public Property PollutantNO2 As String
    Public Property PollutantO3 As String
    Public Property PollutantSO2 As String
    Public Property PrecipitationIntensity() As String
    Public Property PrecipitationProbability() As String
    Public Property PrecipitationType() As Dictionary(Of String, String)
    Public Property PressureSeaLevel As String
    Public Property PressureSurfaceLevel As String
    Public Property SolarDIF As String
    Public Property SolarDIR As String
    Public Property SolarGHI As String
    Public Property Temperature As String
    Public Property TemperatureApparent As String
    Public Property TreeAcacia() As Dictionary(Of String, String)
    Public Property TreeAsh() As Dictionary(Of String, String)
    Public Property TreeBeech() As Dictionary(Of String, String)
    Public Property TreeBirch() As Dictionary(Of String, String)
    Public Property TreeCedar() As Dictionary(Of String, String)
    Public Property TreeCottonwood() As Dictionary(Of String, String)
    Public Property TreeCyPress() As Dictionary(Of String, String)
    Public Property TreeElder() As Dictionary(Of String, String)
    Public Property TreeElm() As Dictionary(Of String, String)
    Public Property TreeHemlock() As Dictionary(Of String, String)
    Public Property TreeHickory() As Dictionary(Of String, String)
    Public Property TreeIndex() As Dictionary(Of String, String)
    Public Property TreeJuniper() As Dictionary(Of String, String)
    Public Property TreeMahagony() As Dictionary(Of String, String)
    Public Property TreeMaple() As Dictionary(Of String, String)
    Public Property TreeMulberry() As Dictionary(Of String, String)
    Public Property TreeOak() As Dictionary(Of String, String)
    Public Property TreePine() As Dictionary(Of String, String)
    Public Property TreeSpruce() As Dictionary(Of String, String)
    Public Property TreeSycamore() As Dictionary(Of String, String)
    Public Property TreeWalnut() As Dictionary(Of String, String)
    Public Property TreeWillow() As Dictionary(Of String, String)
    Public Property Visibility As String
    Public Property WeatherCode() As Dictionary(Of String, String)
    Public Property WeedGrassWeedIndex() As Dictionary(Of String, String)
    Public Property WeedIndex() As Dictionary(Of String, String)
    Public Property WindDirection As String
    Public Property WindGust As String
    Public Property WindSpeed As String
End Class

'Partial Public Class MoonPhase
'<JsonPropertyName("0")> Public Property Ndx0 As String
'    <JsonPropertyName("1")> Public Property Ndx1 As String
'    <JsonPropertyName("2")> Public Property Ndx2 As String
'    <JsonPropertyName("3")> Public Property Ndx3 As String
'    <JsonPropertyName("4")> Public Property Ndx4 As String
'    <JsonPropertyName("5")> Public Property Ndx5 As String
'    <JsonPropertyName("6")> Public Property Ndx6 As String
'    <JsonPropertyName("7")> Public Property Ndx7 As String
'End Class

'Partial Public Class PrecipType
'    <JsonPropertyName("_0")> Public Property Ndx0 As String
'    <JsonPropertyName("_1")> Public Property Ndx1 As String
'    <JsonPropertyName("_2")> Public Property Ndx2 As String
'    <JsonPropertyName("_3")> Public Property Ndx3 As String
'    <JsonPropertyName("_4")> Public Property Ndx4 As String
'End Class

'Partial Public Class StrIndex1
'    <JsonPropertyName("_0")> Public Property Ndx0 As String
'    <JsonPropertyName("_1")> Public Property Ndx1 As String
'    <JsonPropertyName("_2")> Public Property Ndx2 As String
'    <JsonPropertyName("_3")> Public Property Ndx3 As String
'    <JsonPropertyName("_4")> Public Property Ndx4 As String
'    <JsonPropertyName("_5")> Public Property Ndx5 As String
'End Class

'Partial Public Class WxCode
'    <JsonPropertyName("_0")> Public Property Ndx0 As String
'    <JsonPropertyName("_1000")> Public Property Ndx1000 As String
'    <JsonPropertyName("_1001")> Public Property Ndx1001 As String
'    <JsonPropertyName("_1100")> Public Property Ndx1100 As String
'    <JsonPropertyName("_1101")> Public Property Ndx1101 As String
'    <JsonPropertyName("_1102")> Public Property Ndx1102 As String
'    <JsonPropertyName("_2000")> Public Property Ndx2000 As String
'    <JsonPropertyName("_2100")> Public Property Ndx2100 As String
'    <JsonPropertyName("_3000")> Public Property Ndx3000 As String
'    <JsonPropertyName("_3001")> Public Property Ndx3001 As String
'    <JsonPropertyName("_3002")> Public Property Ndx3002 As String
'    <JsonPropertyName("_4000")> Public Property Ndx4000 As String
'    <JsonPropertyName("_4001")> Public Property Ndx4001 As String
'    <JsonPropertyName("_4200")> Public Property Ndx4200 As String
'    <JsonPropertyName("_4201")> Public Property Ndx4201 As String
'    <JsonPropertyName("_5000")> Public Property Ndx5000 As String
'    <JsonPropertyName("_5001")> Public Property Ndx5001 As String
'    <JsonPropertyName("_5100")> Public Property Ndx5100 As String
'    <JsonPropertyName("_5101")> Public Property Ndx5101 As String
'    <JsonPropertyName("_6000")> Public Property Ndx6000 As String
'    <JsonPropertyName("_6001")> Public Property Ndx6001 As String
'    <JsonPropertyName("_6200")> Public Property Ndx6200 As String
'    <JsonPropertyName("_6201")> Public Property Ndx6201 As String
'    <JsonPropertyName("_7000")> Public Property Ndx7000 As String
'    <JsonPropertyName("_7101")> Public Property Ndx7101 As String
'    <JsonPropertyName("_7102")> Public Property Ndx7102 As String
'    <JsonPropertyName("_8000")> Public Property Ndx8000 As String
'End Class