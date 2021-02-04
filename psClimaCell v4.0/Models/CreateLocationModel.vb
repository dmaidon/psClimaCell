Imports System.Text.Json.Serialization

Partial Public Class CcLocationModel
    <JsonPropertyName("data")> Public Property LocData As LocData
    <JsonPropertyName("meta")> Public Property Meta As Meta
    <JsonPropertyName("links")> Public Property Links As Links
End Class

Partial Public Class LocData
    <JsonPropertyName("locations")> Public Property Locations() As List(Of Location)
End Class

Partial Public Class Location
    <JsonPropertyName("id")> Public Property Id As String
    <JsonPropertyName("name")> Public Property Name As String
    <JsonPropertyName("geometry")> Public Property Geometry As Geometry
    <JsonPropertyName("timeZone")> Public Property TZ As String
    <JsonPropertyName("createdAt")> Public Property CreatedAt As Date
    <JsonPropertyName("updatedAt")> Public Property UpdatedAt As Date
End Class

Partial Public Class Geometry
    <JsonPropertyName("type")> Public Property Type As String
    <JsonPropertyName("coordinates")> Public Property Coordinates() As List(Of Double)
End Class

Partial Public Class Meta
    <JsonPropertyName("totalItems")> Public Property TotalItems As Long
End Class

Partial Public Class Links
    <JsonPropertyName("self")> Public Property Self As String
End Class