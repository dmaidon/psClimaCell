Option Infer On

Imports System.Text.Json.Serialization

Namespace Models

	Partial Public Class DailyData
		<JsonPropertyName("temp")>
		Public Property Temp() As List(Of BaroPressure)

		<JsonPropertyName("precipitation_accumulation")>
		Public Property PrecipitationAccumulation() As PrecipitationAccumulation

		<JsonPropertyName("precipitation")>
		Public Property Precipitation() As List(Of Precipitation)

		<JsonPropertyName("precipitation_probability")>
		Public Property PrecipitationProbability() As PrecipitationAccumulation

		<JsonPropertyName("feels_like")>
		Public Property FeelsLike() As List(Of BaroPressure)

		<JsonPropertyName("humidity")>
		Public Property Humidity() As List(Of BaroPressure)

		<JsonPropertyName("baro_pressure")>
		Public Property BaroPressure() As List(Of BaroPressure)

		<JsonPropertyName("dewpoint")>
		Public Property Dewpoint() As List(Of BaroPressure)

		<JsonPropertyName("wind_speed")>
		Public Property WindSpeed() As List(Of BaroPressure)

		<JsonPropertyName("wind_direction")>
		Public Property WindDirection() As List(Of BaroPressure)

		<JsonPropertyName("visibility")>
		Public Property Visibility() As List(Of BaroPressure)

		<JsonPropertyName("sunrise")>
		Public Property Sunrise() As ObservationTime

		<JsonPropertyName("sunset")>
		Public Property Sunset() As ObservationTime

		<JsonPropertyName("moon_phase")>
		Public Property MoonPhase() As WxCode

		<JsonPropertyName("weather_code")>
		Public Property WeatherCode() As WxCode

		<JsonPropertyName("observation_time")>
		Public Property ObservationTime() As ObservationTime

		<JsonPropertyName("lat")>
		Public Property Lat() As Double?

		<JsonPropertyName("lon")>
		Public Property Lon() As Double?
	End Class

	Partial Public Class BaroPressure
		<JsonPropertyName("observation_time")>
		Public Property ObservationTime() As DateTimeOffset?

		<JsonPropertyName("min")>
		Public Property Min() As PrecipitationAccumulation

		<JsonPropertyName("max")>
		Public Property Max() As PrecipitationAccumulation
	End Class

	Partial Public Class PrecipitationAccumulation
		<JsonPropertyName("value")>
		Public Property Value() As Double?

		<JsonPropertyName("units")>
		Public Property Units() As String
	End Class

	Partial Public Class WxCode
		<JsonPropertyName("value")>
		Public Property Value() As String
	End Class

	Partial Public Class ObservationTime
		<JsonPropertyName("value")>
		Public Property Value() As Date
	End Class

	Partial Public Class Precipitation
		<JsonPropertyName("observation_time")>
		Public Property ObservationTime() As DateTimeOffset?

		<JsonPropertyName("max")>
		Public Property Max() As PrecipitationAccumulation
	End Class

End Namespace
