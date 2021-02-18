Imports System.Text.Json.Serialization

Partial Public Class CcTimelinesModel
    <JsonPropertyName("data")> Public Property WxData As WxData
    <JsonPropertyName("warnings")> Public Property Warnings() As List(Of Warning)
End Class

Partial Public Class WxData
    <JsonPropertyName("timelines")> Public Property TimeLines() As List(Of Timeline)
End Class

Partial Public Class Warning
    <JsonPropertyName("code")> Public Property Code() As Long

    <JsonPropertyName("type")> Public Property Type() As String

    <JsonPropertyName("message")> Public Property Message() As String

    <JsonPropertyName("meta")> Public Property Meta() As Meta

End Class

Partial Public Class Meta
    <JsonPropertyName("field")> Public Property Field() As String

    <JsonPropertyName("from")> Public Property From() As String

    <JsonPropertyName("to")> Public Property [To]() As String

    <JsonPropertyName("timestep")> Public Property Timestep() As String

    <JsonPropertyName("timesteps")> Public Property Timesteps() As List(Of String)
End Class


Partial Public Class Timeline
    <JsonPropertyName("timestep")> Public Property TimeStep As String
    <JsonPropertyName("startTime")> Public Property StartTime As Date
    <JsonPropertyName("endTime")> Public Property EndTime As Date
    <JsonPropertyName("intervals")> Public Property Intervals() As List(Of Interval)
End Class

Partial Public Class Interval
    <JsonPropertyName("startTime")> Public Property StartTime As Date
    <JsonPropertyName("values")> Public Property Values() As Values
End Class

Partial Public Class Values

    <JsonPropertyName("temperature")> Public Property Temp As Double?
    <JsonPropertyName("temperatureMin")> Public Property TempMin As Double?
    <JsonPropertyName("temperatureMax")> Public Property TempMax As Double?
    <JsonPropertyName("temperatureApparent")> Public Property TempApparent As Double?
    <JsonPropertyName("dewpoint")> Public Property Dewpoint As Double?
    <JsonPropertyName("humidity")> Public Property RH As Double?
    <JsonPropertyName("windSpeed")> Public Property WindSpeed As Double?
    <JsonPropertyName("windDirection")> Public Property WindDir As Double?
    <JsonPropertyName("windGust")> Public Property WindGust As Double?
    <JsonPropertyName("pressureSurfaceLevel")> Public Property PressureSurfaceLevel As Double?
    <JsonPropertyName("pressureSeaLevel")> Public Property PressureSeaLevel As Double?
    <JsonPropertyName("precipitationIntensity")> Public Property PrecipIntensity As Double?
    <JsonPropertyName("precipitationProbability")> Public Property PrecipPct As Double?
    <JsonPropertyName("precipitationType")> Public Property PrecipType As Integer?
    <JsonPropertyName("sunriseTime")> Public Property Sunrise As Date
    <JsonPropertyName("sunsetTime")> Public Property Sunset As Date
    <JsonPropertyName("solarGHI")> Public Property SolarGHI As Double?
    <JsonPropertyName("visibility")> Public Property Visibility As Double?
    <JsonPropertyName("cloudCover")> Public Property CloudCover As Double?
    <JsonPropertyName("cloudBase")> Public Property CloudBase As Double?
    <JsonPropertyName("cloudCeiling")> Public Property CloudCeiling As Double?
    <JsonPropertyName("moonPhase")> Public Property MoonPhase As Integer?
    <JsonPropertyName("weatherCode")> Public Property WxCode As Integer?
    <JsonPropertyName("particulateMatter25")> Public Property PM25 As Double?
    <JsonPropertyName("particulateMatter10")> Public Property PM10 As Double?
    <JsonPropertyName("pollutantO3")> Public Property O3 As Double?
    <JsonPropertyName("pollutantNO2")> Public Property NO2 As Double?
    <JsonPropertyName("pollutantCO")> Public Property CO As Double?
    <JsonPropertyName("pollutantSO2")> Public Property SO2 As Double?
    <JsonPropertyName("mepIndex")> Public Property MepIndex As Integer?
    <JsonPropertyName("mepPrimaryPollutant")> Public Property MepPrimaryPollutant As Integer?
    <JsonPropertyName("mepHealthConcern")> Public Property MepHealthConcern As Integer?
    <JsonPropertyName("epaIndex")> Public Property EpaIndex As Integer?
    <JsonPropertyName("epaPrimaryPollutant")> Public Property EpaPrimaryPollutant As Integer?
    <JsonPropertyName("epaHealthConcern")> Public Property EpaHealthConcern As Integer?
    <JsonPropertyName("treeIndex")> Public Property Tree As Double?
    <JsonPropertyName("treeAcaciaIndex")> Public Property TreeAcacia As Double?
    <JsonPropertyName("treeAshIndex")> Public Property TreeAsh As Double?
    <JsonPropertyName("treeBeechIndex")> Public Property TreeBeech As Double?
    <JsonPropertyName("treeBirchIndex")> Public Property TreeBirch As Double?
    <JsonPropertyName("treeCedarIndex")> Public Property TreeCedar As Double?
    <JsonPropertyName("treeCypressIndex")> Public Property TreeCypress As Double?
    <JsonPropertyName("treeElderIndex")> Public Property TreeElder As Double?
    <JsonPropertyName("treeElmIndex")> Public Property TreeElm As Double?
    <JsonPropertyName("treeHemlockIndex")> Public Property TreeHemlock As Double?
    <JsonPropertyName("treeHickoryIndex")> Public Property TreeHickory As Double?
    <JsonPropertyName("treeJuniperIndex")> Public Property TreeJuniper As Double?
    <JsonPropertyName("treeMahagonyIndex")> Public Property TreeMahogany As Double?
    <JsonPropertyName("treeMapleIndex")> Public Property TreeMaple As Double?
    <JsonPropertyName("treeMulberryIndex")> Public Property TreeMulberry As Double?
    <JsonPropertyName("treeOakIndex")> Public Property TreeOak As Double?
    <JsonPropertyName("treePineIndex")> Public Property TreePine As Double?
    <JsonPropertyName("treeCottonwoodIndex")> Public Property TreeCottonwood As Double?
    <JsonPropertyName("treeSpruceIndex")> Public Property TreeSpruce As Double?
    <JsonPropertyName("treeSycamoreIndex")> Public Property TreeSycamore As Double?
    <JsonPropertyName("treeWalnutIndex")> Public Property TreeWalnut As Double?
    <JsonPropertyName("treeWillowIndex")> Public Property TreeWillow As Double?
    <JsonPropertyName("grassIndex")> Public Property Grass As Double?
    <JsonPropertyName("grassGrassIndex")> Public Property GrassGrass As Double?
    <JsonPropertyName("weedIndex")> Public Property Weed As Double?
    <JsonPropertyName("weedGrassweedIndex")> Public Property WeedGrassWeed As Double?
    <JsonPropertyName("fireIndex")> Public Property FireIndex As Integer?
    <JsonPropertyName("hailBinary")> Public Property HailProbability As Integer?

End Class