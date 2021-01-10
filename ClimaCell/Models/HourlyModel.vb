Imports System.Text.Json.Serialization

Namespace Models
    'Partial Public Class CcHourData
    '    Public Property HourNum() As HourNum
    'End Class

    Partial Public Class HourNum

        <JsonPropertyName("lon")>
        Public Property Lon As Single

        <JsonPropertyName("lat")>
        Public Property Lat As Single

        <JsonPropertyName("temp")>
        Public Property Temp As Dv2

        <JsonPropertyName("precipitation")>
        Public Property Precip As Dv2

        <JsonPropertyName("precipitation_type")>
        Public Property PrecipType As Dv1

        <JsonPropertyName("precipitation_probability")>
        Public Property PrecipiProb As Dv2

        <JsonPropertyName("feels_like")>
        Public Property FeelsLike As Dv2

        <JsonPropertyName("humidity")>
        Public Property RH As Dv2

        <JsonPropertyName("baro_pressure")>
        Public Property BP As Dv2

        <JsonPropertyName("dewpoint")>
        Public Property Dewpoint As Dv2

        <JsonPropertyName("wind_speed")>
        Public Property WindSpeed As Dv2

        <JsonPropertyName("wind_gust")>
        Public Property WindGust As Dv2

        <JsonPropertyName("wind_direction")>
        Public Property WindDir As Dv2

        <JsonPropertyName("visibility")>
        Public Property Visibility As Dv2

        <JsonPropertyName("cloud_cover")>
        Public Property CloudCover As Dv2

        <JsonPropertyName("cloud_base")>
        Public Property CloudBase As Dv2

        <JsonPropertyName("cloud_ceiling")>
        Public Property CloudCeiling As Dv2

        <JsonPropertyName("surface_shortwave_radiation")>
        Public Property SSR As Dv2

        <JsonPropertyName("sunrise")>
        Public Property Sunrise As Dv1

        <JsonPropertyName("sunset")>
        Public Property Sunset As Dv1

        <JsonPropertyName("weather_code")>
        Public Property WxCode As Dv1

        <JsonPropertyName("observation_time")>
        Public Property ObservationTime As Dv1

        <JsonPropertyName("pollen_tree")>
        Public Property TreePollen As Dv2

        <JsonPropertyName("pollen_weed")>
        Public Property WeedPollen As Dv2

        <JsonPropertyName("pollen_grass")>
        Public Property GrassPollen As Dv2

        <JsonPropertyName("pollen_tree_ash")>
        Public Property TreeAsh As Dv2

        <JsonPropertyName("pollen_tree_acacia")>
        Public Property TreeAcacia As Dv2

        <JsonPropertyName("pollen_tree_beech")>
        Public Property TreeBeech As Dv2

        <JsonPropertyName("pollen_tree_birch")>
        Public Property TreeBirch As Dv2

        <JsonPropertyName("pollen_tree_cedar")>
        Public Property TreeCedar As Dv2

        <JsonPropertyName("pollen_tree_cypress")>
        Public Property TreeCypress As Dv2

        <JsonPropertyName("pollen_tree_elder")>
        Public Property TreeElder As Dv2

        <JsonPropertyName("pollen_tree_elm")>
        Public Property TreeElm As Dv2

        <JsonPropertyName("pollen_tree_hemlock")>
        Public Property TreeHemlock As Dv2

        <JsonPropertyName("pollen_tree_hickory")>
        Public Property TreeHickory As Dv2

        <JsonPropertyName("pollen_tree_juniper")>
        Public Property TreeJuniper As Dv2

        <JsonPropertyName("pollen_tree_mahogany")>
        Public Property TreeMahogany As Dv2

        <JsonPropertyName("pollen_tree_maple")>
        Public Property TreeMaple As Dv2

        <JsonPropertyName("pollen_tree_mulberry")>
        Public Property TreeMulberry As Dv2

        <JsonPropertyName("pollen_tree_oak")>
        Public Property TreeOak As Dv2

        <JsonPropertyName("pollen_tree_pine")>
        Public Property TreePine As Dv2

        <JsonPropertyName("pollen_tree_cottonwood")>
        Public Property TreeCottonwood As Dv2

        <JsonPropertyName("pollen_tree_spruce")>
        Public Property TreeSpruce As Dv2

        <JsonPropertyName("pollen_tree_sycamore")>
        Public Property TreeSycamore As Dv2

        <JsonPropertyName("pollen_tree_walnut")>
        Public Property TreeWalnut As Dv2

        <JsonPropertyName("pollen_tree_willow")>
        Public Property TreeWillow As Dv2

        <JsonPropertyName("pollen_weed_ragweed")>
        Public Property PollenRagweed As Dv2

        <JsonPropertyName("pollen_grass_grass")>
        Public Property PollenGrassGrass As Dv2

        <JsonPropertyName("pm25")>
        Public Property Pm25 As Dv2

        <JsonPropertyName("pm10")>
        Public Property Pm10 As Dv2

        <JsonPropertyName("o3")>
        Public Property O3 As Dv2

        <JsonPropertyName("no2")>
        Public Property No2 As Dv2

        <JsonPropertyName("co")>
        Public Property Co As Dv2

        <JsonPropertyName("so2")>
        Public Property So2 As Dv2

        <JsonPropertyName("epa_aqi")>
        Public Property EpaAqi As Dv3

        <JsonPropertyName("epa_primary_pollutant")>
        Public Property EpaPrimaryPollutant As Dv1

        <JsonPropertyName("epa_health_concern")>
        Public Property EpaHealthConcern As Dv1

        <JsonPropertyName("china_aqi")>
        Public Property ChinaAqi As Dv3

        <JsonPropertyName("china_primary_pollutant")>
        Public Property ChinaPrimaryPollutant As Dv1

        <JsonPropertyName("china_health_concern")>
        Public Property ChinaHealthConcern As Dv1

        <JsonPropertyName("road_risk")>
        Public Property RoadRisk As Dv1

        <JsonPropertyName("road_risk_score")>
        Public Property RoadRiskScore As Dv4

        <JsonPropertyName("road_risk_confidence")>
        Public Property RoadRiskConfidence As Dv2

        <JsonPropertyName("road_risk_condition")>
        Public Property RoadRiskCondition As Dv4

        <JsonPropertyName("hail_binary")>
        Public Property HailRisk As Dv2

    End Class

    Partial Public Class Dv1

        <JsonPropertyName("value")>
        Public Property Value As String

    End Class

    Partial Public Class Dv2

        <JsonPropertyName("value")>
        Public Property Value As Double?

        <JsonPropertyName("units")>
        Public Property Units As String

    End Class

    Partial Public Class Dv3

        <JsonPropertyName("value")>
        Public Property Value As Double?

    End Class

    Partial Public Class Dv4

        <JsonPropertyName("value")>
        Public Property Value As String

        <JsonPropertyName("units")>
        Public Property Units As String

    End Class

End Namespace