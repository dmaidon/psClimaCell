Imports System.Text.Json.Serialization

Namespace Models

    Partial Public Class Crs

        <JsonPropertyName("properties")> Public Property Properties() As CrsProperties

        <JsonPropertyName("type")> Public Property Type() As String

    End Class

    Partial Public Class CrsProperties

        <JsonPropertyName("name")> Public Property Name() As String

    End Class

    Partial Public Class Feature

        <JsonPropertyName("geometry")> Public Property Geometry() As Geometry

        <JsonPropertyName("properties")> Public Property Properties() As FeatureProperties

        <JsonPropertyName("type")> Public Property Type() As String

    End Class

    Partial Public Class FeatureProperties

        <JsonPropertyName("ABCDMisc")> Public Property AbcdMisc() As String

        <JsonPropertyName("ADSPermissionState")> Public Property AdsPermissionState() As String

        <JsonPropertyName("CalculatedAcres")> Public Property CalculatedAcres() As Double?

        <JsonPropertyName("ContainmentDateTime")> Public Property ContainmentDateTime() As Object

        <JsonPropertyName("ControlDateTime")> Public Property ControlDateTime() As Object

        <JsonPropertyName("CreatedBySystem")> Public Property CreatedBySystem() As String

        <JsonPropertyName("CreatedOnDateTime_dt")> Public Property CreatedOnDateTimeDt() As DateTimeOffset

        <JsonPropertyName("DailyAcres")> Public Property DailyAcres() As Double?

        <JsonPropertyName("DiscoveryAcres")> Public Property DiscoveryAcres() As Double?

        <JsonPropertyName("DispatchCenterID")> Public Property DispatchCenterId() As String

        <JsonPropertyName("EstimatedCostToDate")> Public Property EstimatedCostToDate() As Double?

        <JsonPropertyName("FinalFireReportApprovedByTitle")> Public Property FinalFireReportApprovedByTitle() As Object

        <JsonPropertyName("FinalFireReportApprovedByUnit")> Public Property FinalFireReportApprovedByUnit() As Object

        <JsonPropertyName("FinalFireReportApprovedDate")> Public Property FinalFireReportApprovedDate() As DateTimeOffset?

        <JsonPropertyName("FireBehaviorGeneral")> Public Property FireBehaviorGeneral() As String

        <JsonPropertyName("FireBehaviorGeneral1")> Public Property FireBehaviorGeneral1() As String

        <JsonPropertyName("FireBehaviorGeneral2")> Public Property FireBehaviorGeneral2() As String

        <JsonPropertyName("FireBehaviorGeneral3")> Public Property FireBehaviorGeneral3() As String

        <JsonPropertyName("FireCause")> Public Property FireCause() As String

        <JsonPropertyName("FireCauseGeneral")> Public Property FireCauseGeneral() As String

        <JsonPropertyName("FireCauseSpecific")> Public Property FireCauseSpecific() As String

        <JsonPropertyName("FireCode")> Public Property FireCode() As String

        <JsonPropertyName("FireDepartmentID")> Public Property FireDepartmentId() As String

        <JsonPropertyName("FireDiscoveryDateTime")> Public Property FireDiscoveryDateTime() As DateTimeOffset

        <JsonPropertyName("FireMgmtComplexity")> Public Property FireMgmtComplexity() As String

        <JsonPropertyName("FireOutDateTime")> Public Property FireOutDateTime() As Object

        <JsonPropertyName("FireStrategyConfinePercent")> Public Property FireStrategyConfinePercent() As Long?

        <JsonPropertyName("FireStrategyFullSuppPercent")> Public Property FireStrategyFullSuppPercent() As Long?

        <JsonPropertyName("FireStrategyMonitorPercent")> Public Property FireStrategyMonitorPercent() As Long?

        <JsonPropertyName("FireStrategyPointZonePercent")> Public Property FireStrategyPointZonePercent() As Long?

        <JsonPropertyName("FSJobCode")> Public Property FsJobCode() As String

        <JsonPropertyName("FSOverrideCode")> Public Property FsOverrideCode() As String

        <JsonPropertyName("GACC")> Public Property Gacc() As String

        <JsonPropertyName("GlobalID")> Public Property GlobalId() As String

        <JsonPropertyName("ICS209ReportDateTime")> Public Property Ics209ReportDateTime() As DateTimeOffset?

        <JsonPropertyName("ICS209ReportForTimePeriodFrom")> Public Property Ics209ReportForTimePeriodFrom() As DateTimeOffset?

        <JsonPropertyName("ICS209ReportForTimePeriodTo")> Public Property Ics209ReportForTimePeriodTo() As DateTimeOffset?

        <JsonPropertyName("ICS209ReportStatus")> Public Property Ics209ReportStatus() As String

        <JsonPropertyName("IncidentManagementOrganization")> Public Property IncidentManagementOrganization() As String

        <JsonPropertyName("IncidentName")> Public Property IncidentName() As String

        <JsonPropertyName("IncidentShortDescription")> Public Property IncidentShortDescription() As String

        <JsonPropertyName("IncidentTypeCategory")> Public Property IncidentTypeCategory() As String

        <JsonPropertyName("IncidentTypeKind")> Public Property IncidentTypeKind() As String

        <JsonPropertyName("InitialLatitude")> Public Property InitialLatitude() As Double?

        <JsonPropertyName("InitialLongitude")> Public Property InitialLongitude() As Double?

        <JsonPropertyName("InitialResponseAcres")> Public Property InitialResponseAcres() As Double?

        <JsonPropertyName("InitialResponseDateTime")> Public Property InitialResponseDateTime() As DateTimeOffset?

        <JsonPropertyName("IrwinID")> Public Property IrwinId() As String

        <JsonPropertyName("IsDispatchComplete")> Public Property IsDispatchComplete() As Long

        <JsonPropertyName("IsFireCauseInvestigated")> Public Property IsFireCauseInvestigated() As Long?

        <JsonPropertyName("IsFireCodeRequested")> Public Property IsFireCodeRequested() As Long

        <JsonPropertyName("IsFSAssisted")> Public Property IsFsAssisted() As Long?

        <JsonPropertyName("IsMultiJurisdictional")> Public Property IsMultiJurisdictional() As Long?

        <JsonPropertyName("IsReimbursable")> Public Property IsReimbursable() As Long?

        <JsonPropertyName("IsTrespass")> Public Property IsTrespass() As Long?

        <JsonPropertyName("IsUnifiedCommand")> Public Property IsUnifiedCommand() As Long?

        <JsonPropertyName("LocalIncidentIdentifier")> Public Property LocalIncidentIdentifier() As String

        <JsonPropertyName("ModifiedBySystem")> Public Property ModifiedBySystem() As String

        <JsonPropertyName("ModifiedOnDateTime_dt")> Public Property ModifiedOnDateTimeDt() As DateTimeOffset

        <JsonPropertyName("OBJECTID")> Public Property Objectid() As Long

        <JsonPropertyName("OrganizationalAssessment")> Public Property OrganizationalAssessment() As String

        <JsonPropertyName("PercentContained")> Public Property PercentContained() As Double?

        <JsonPropertyName("PercentPerimeterToBeContained")> Public Property PercentPerimeterToBeContained() As Double?

        <JsonPropertyName("POOCity")> Public Property PooCity() As String

        <JsonPropertyName("POOCounty")> Public Property PooCounty() As String

        <JsonPropertyName("POODispatchCenterID")> Public Property PooDispatchCenterId() As String

        <JsonPropertyName("POOFips")> Public Property PooFips() As String

        <JsonPropertyName("POOJurisdictionalAgency")> Public Property PooJurisdictionalAgency() As String

        <JsonPropertyName("POOJurisdictionalUnit")> Public Property PooJurisdictionalUnit() As String

        <JsonPropertyName("POOJurisdictionalUnitParentUnit")> Public Property PooJurisdictionalUnitParentUnit() As Object

        <JsonPropertyName("POOLandownerCategory")> Public Property PooLandownerCategory() As String

        <JsonPropertyName("POOLandownerKind")> Public Property PooLandownerKind() As String

        <JsonPropertyName("POOLegalDescPrincipalMeridian")> Public Property PooLegalDescPrincipalMeridian() As String

        <JsonPropertyName("POOLegalDescQtr")> Public Property PooLegalDescQtr() As String

        <JsonPropertyName("POOLegalDescQtrQtr")> Public Property PooLegalDescQtrQtr() As String

        <JsonPropertyName("POOLegalDescRange")> Public Property PooLegalDescRange() As String

        <JsonPropertyName("POOLegalDescSection")> Public Property PooLegalDescSection() As Long?

        <JsonPropertyName("POOLegalDescTownship")> Public Property PooLegalDescTownship() As String

        <JsonPropertyName("POOPredictiveServiceAreaID")> Public Property PooPredictiveServiceAreaId() As String

        <JsonPropertyName("POOProtectingAgency")> Public Property PooProtectingAgency() As String

        <JsonPropertyName("POOProtectingUnit")> Public Property PooProtectingUnit() As String

        <JsonPropertyName("POOState")> Public Property PooState() As String

        <JsonPropertyName("PredominantFuelGroup")> Public Property PredominantFuelGroup() As String

        <JsonPropertyName("PredominantFuelModel")> Public Property PredominantFuelModel() As String

        <JsonPropertyName("PrimaryFuelModel")> Public Property PrimaryFuelModel() As String

        <JsonPropertyName("SecondaryFuelModel")> Public Property SecondaryFuelModel() As String

        <JsonPropertyName("Source")> Public Property Source() As String

        <JsonPropertyName("StrategicDecisionPublishDate")> Public Property StrategicDecisionPublishDate() As DateTimeOffset?

        <JsonPropertyName("TotalIncidentPersonnel")> Public Property TotalIncidentPersonnel() As Long?

        <JsonPropertyName("UniqueFireIdentifier")> Public Property UniqueFireIdentifier() As String

        <JsonPropertyName("WFDSSDecisionStatus")> Public Property WfdssDecisionStatus() As String

    End Class

    Partial Public Class FireApiData

        <JsonPropertyName("crs")> Public Property Crs() As Crs

        <JsonPropertyName("features")> Public Property Features() As List(Of Feature)

        <JsonPropertyName("name")> Public Property Name() As String

        <JsonPropertyName("type")> Public Property Type() As String

    End Class

    Partial Public Class Geometry

        <JsonPropertyName("coordinates")> Public Property Coordinates() As List(Of Double)

        <JsonPropertyName("type")> Public Property Type() As String

    End Class

End Namespace