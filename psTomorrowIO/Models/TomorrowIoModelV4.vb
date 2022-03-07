Imports System.Text.Json.Serialization

Partial Public Class Interval
    <JsonPropertyName("startTime")> Public Property StartTime As Date
    <JsonPropertyName("values")> Public Property Values() As Values
End Class

Partial Public Class Meta
    <JsonPropertyName("to")> Public Property [To]() As String
    <JsonPropertyName("field")> Public Property Field() As String
    <JsonPropertyName("from")> Public Property From() As String
    <JsonPropertyName("location")> Public Property Location() As String
    <JsonPropertyName("timestep")> Public Property Timestep() As String
    <JsonPropertyName("timesteps")> Public Property Timesteps() As List(Of String)
End Class

Partial Public Class Timeline
    <JsonPropertyName("endTime")> Public Property EndTime As Date
    <JsonPropertyName("intervals")> Public Property Intervals() As List(Of Interval)
    <JsonPropertyName("startTime")> Public Property StartTime As Date
    <JsonPropertyName("timestep")> Public Property TimeStep As String
End Class

Partial Public Class TioTimelinesModel
    <JsonPropertyName("warnings")> Public Property Warnings() As List(Of Warning)
    <JsonPropertyName("data")> Public Property WxData As WxData
End Class

Partial Public Class Values

    <JsonPropertyName("cloudBase")> Public Property CloudBase As Double?
    <JsonPropertyName("cloudCeiling")> Public Property CloudCeiling As Double?
    <JsonPropertyName("cloudCover")> Public Property CloudCover As Double?
    <JsonPropertyName("pollutantCO")> Public Property CO As Double?
    <JsonPropertyName("dewPoint")> Public Property Dewpoint As Double?
    <JsonPropertyName("epaHealthConcern")> Public Property EpaHealthConcern As Integer?
    <JsonPropertyName("epaIndex")> Public Property EpaIndex As Integer?
    <JsonPropertyName("epaPrimaryPollutant")> Public Property EpaPrimaryPollutant As Integer?
    <JsonPropertyName("fireIndex")> Public Property FireIndex As Integer?
    <JsonPropertyName("grassIndex")> Public Property Grass As Double?
    <JsonPropertyName("grassGrassIndex")> Public Property GrassGrass As Double?
    <JsonPropertyName("hailBinary")> Public Property HailProbability As Integer?
    <JsonPropertyName("iceAccumulation")> Public Property IceAccumulation As Double?
    <JsonPropertyName("mepHealthConcern")> Public Property MepHealthConcern As Integer?
    <JsonPropertyName("mepIndex")> Public Property MepIndex As Integer?
    <JsonPropertyName("mepPrimaryPollutant")> Public Property MepPrimaryPollutant As Integer?
    <JsonPropertyName("soilMoistureVolumetric0To10")> Public Property Moisture0To10 As Double?
    <JsonPropertyName("soilMoistureVolumetric0To200")> Public Property Moisture0To200 As Double?
    <JsonPropertyName("soilMoistureVolumetric100To200")> Public Property Moisture100To200 As Double?
    <JsonPropertyName("soilMoistureVolumetric10To40")> Public Property Moisture10To40 As Double?
    <JsonPropertyName("soilMoistureVolumetric40To100")> Public Property Moisture40To100 As Double?
    <JsonPropertyName("moonPhase")> Public Property MoonPhase As Integer?
    <JsonPropertyName("pollutantNO2")> Public Property NO2 As Double?
    <JsonPropertyName("pollutantO3")> Public Property O3 As Double?
    <JsonPropertyName("particulateMatter10")> Public Property PM10 As Double?
    <JsonPropertyName("particulateMatter25")> Public Property PM25 As Double?
    <JsonPropertyName("precipitationIntensity")> Public Property PrecipIntensity As Double?
    <JsonPropertyName("rainIntensity")> Public Property RainIntensity As Double?
    <JsonPropertyName("freezingRainIntensity")> Public Property FreezingRainIntensity As Double?
    <JsonPropertyName("snowIntensity")> Public Property SnowIntensity As Double?
    <JsonPropertyName("sleetIntensity")> Public Property SleetIntensity As Double?
    <JsonPropertyName("precipitationProbability")> Public Property PrecipPct As Double?
    <JsonPropertyName("precipitationType")> Public Property PrecipType As Integer?
    <JsonPropertyName("pressureSeaLevel")> Public Property PressureSeaLevel As Double?
    <JsonPropertyName("pressureSurfaceLevel")> Public Property PressureSurfaceLevel As Double?
    <JsonPropertyName("primarySwellDirection")> Public Property PrimarySwellDirection As Double?
    <JsonPropertyName("PrimarySwellMeanPeriod")> Public Property PrimarySwellMeanPeriod As Double?
    <JsonPropertyName("primarySwellSignificantHeight")> Public Property PrimarySwellSignificantHeight As Double?
    <JsonPropertyName("humidity")> Public Property RH As Double?
    <JsonPropertyName("secondarySwellDirection")> Public Property SecondarySwellDirection As Double?
    <JsonPropertyName("secondarySwellMeanPeriod")> Public Property SecondarySwellMeanPeriod As Double?
    <JsonPropertyName("secondarySwellSignificantHeight")> Public Property SecondarySwellSignificantHeight As Double?
    <JsonPropertyName("snowAccumulation")> Public Property SnowAccumulation As Double?
    <JsonPropertyName("sleetAccumulation")> Public Property SleetAccumulation As Double?
    <JsonPropertyName("pollutantSO2")> Public Property SO2 As Double?
    <JsonPropertyName("soilTemperature0To10")> Public Property SoilTemp0To10 As Double?
    <JsonPropertyName("soilTemperature0To200")> Public Property SoilTemp0To200 As Double?
    <JsonPropertyName("soilTemperature100To200")> Public Property SoilTemp100To200 As Double?
    <JsonPropertyName("soilTemperature10To40")> Public Property SoilTemp10To40 As Double?
    <JsonPropertyName("soilTemperature40To100")> Public Property SoilTemp40To100 As Double?
    <JsonPropertyName("solarDHI")> Public Property SolarDHI As Double?
    <JsonPropertyName("solarDNI")> Public Property SolarDNI As Double?
    <JsonPropertyName("solarGHI")> Public Property SolarGHI As Double?
    <JsonPropertyName("sunriseTime")> Public Property Sunrise As Date
    <JsonPropertyName("sunsetTime")> Public Property Sunset As Date
    <JsonPropertyName("temperature")> Public Property Temp As Double?
    <JsonPropertyName("temperatureApparent")> Public Property TempApparent As Double?
    <JsonPropertyName("temperatureMax")> Public Property TempMax As Double?
    <JsonPropertyName("temperatureMin")> Public Property TempMin As Double?
    <JsonPropertyName("tertiarySwellDirection")> Public Property TertiarySwellDirection As Double?
    <JsonPropertyName("tertiarySwellMeanPeriod")> Public Property TertiarySwellMeanPeriod As Double?
    <JsonPropertyName("tertiarySwellSignificantHeight")> Public Property TertiarySwellSignificantHeight As Double?
    <JsonPropertyName("treeIndex")> Public Property Tree As Double?
    <JsonPropertyName("treeAcaciaIndex")> Public Property TreeAcacia As Double?
    <JsonPropertyName("treeAshIndex")> Public Property TreeAsh As Double?
    <JsonPropertyName("treeBeechIndex")> Public Property TreeBeech As Double?
    <JsonPropertyName("treeBirchIndex")> Public Property TreeBirch As Double?
    <JsonPropertyName("treeCedarIndex")> Public Property TreeCedar As Double?
    <JsonPropertyName("treeCottonwoodIndex")> Public Property TreeCottonwood As Double?
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
    <JsonPropertyName("treeSpruceIndex")> Public Property TreeSpruce As Double?
    <JsonPropertyName("treeSycamoreIndex")> Public Property TreeSycamore As Double?
    <JsonPropertyName("treeWalnutIndex")> Public Property TreeWalnut As Double?
    <JsonPropertyName("treeWillowIndex")> Public Property TreeWillow As Double?
    <JsonPropertyName("uvHealthConcern")> Public Property UvHealthConcern As Double?
    <JsonPropertyName("uvIndex")> Public Property UvIndex As Double?
    <JsonPropertyName("visibility")> Public Property Visibility As Double?
    <JsonPropertyName("waveDirection")> Public Property WaveDirection As Double?
    <JsonPropertyName("waveMeanPeriod")> Public Property WaveMeanPeriod As Double?
    <JsonPropertyName("waveSignificantHeight")> Public Property WaveSignificantHeight As Double?
    <JsonPropertyName("weedIndex")> Public Property Weed As Double?
    <JsonPropertyName("weedRagweedIndex")> Public Property WeedRagweed As Double?
    <JsonPropertyName("windDirection")> Public Property WindDir As Double?
    <JsonPropertyName("windGust")> Public Property WindGust As Double?
    <JsonPropertyName("windSpeed")> Public Property WindSpeed As Double?
    <JsonPropertyName("windWaveDirection")> Public Property WindWaveDirection As Double?
    <JsonPropertyName("windWaveMeanPeriod")> Public Property WindWaveMeanPeriod As Double?
    <JsonPropertyName("windWaveSignificantHeight")> Public Property WindWaveSignificantHeight As Double?
    <JsonPropertyName("weatherCode")> Public Property WxCode As Integer?
    <JsonPropertyName("weatherCodeFullDay")> Public Property WxCodeFullDay As Integer?
    <JsonPropertyName("weatherCodeDay")> Public Property WxCodeDay As Integer?
    <JsonPropertyName("weatherCodeNight")> Public Property WxCodeNight As Integer?
    <JsonPropertyName("floodIndex")> Public Property FloodIndex As Integer?
    <JsonPropertyName("streamFlow")> Public Property StreamFlow As Double?
    <JsonPropertyName("rainAccumulation")> Public Property RainAccumulation As Double?
    <JsonPropertyName("lightningFlashRateDensity")> Public Property LightningFlashRateDensity As Double?
End Class

Partial Public Class Warning

    <JsonPropertyName("code")> Public Property Code() As Long
    <JsonPropertyName("message")> Public Property Message() As String
    <JsonPropertyName("meta")> Public Property Meta() As Meta
    <JsonPropertyName("type")> Public Property Type() As String
End Class

Partial Public Class WxData
    <JsonPropertyName("timelines")> Public Property TimeLines() As List(Of Timeline)
End Class