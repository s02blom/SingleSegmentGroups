using indice.Edi.Serialization;

namespace SingleSegmentGroups;


[EdiSegment, EdiPath("NAD")]
public record class NAD
{
    [EdiValue("X(3)", Path = "NAD/0", Mandatory = true)]
    public string? PartyFunctionCodeQualifier { get; set; }

    [EdiValue("X(35)", Path = "NAD/1/0", Mandatory = false)]
    public string? PartyIdentifier { get; set; }

    [EdiValue("X(17)", Path = "NAD/1/1", Mandatory = false)]
    public string? CodeListIdentificationCode { get; set; }

    [EdiValue("X(3)", Path = "NAD/1/2", Mandatory = false)]
    public string? CodeListResponsibleAgencyCode { get; set; }

    [EdiValue("X(35)", Path = "NAD/2/0", Mandatory = false)]
    public string? NameAndAddress1 { get; set; }

    [EdiValue("X(35)", Path = "NAD/2/1", Mandatory = false)]
    public string? NameAndAddress2 { get; set; }

    [EdiValue("X(35)", Path = "NAD/2/2", Mandatory = false)]
    public string? NameAndAddress3 { get; set; }

    [EdiValue("X(35)", Path = "NAD/2/3", Mandatory = false)]
    public string? NameAndAddress4 { get; set; }

    [EdiValue("X(35)", Path = "NAD/2/4", Mandatory = false)]
    public string? NameAndAddress5 { get; set; }

    [EdiValue("X(70)", Path = "NAD/3/0", Mandatory = false)]
    public string? PartyName1 { get; set; }

    [EdiValue("X(70)", Path = "NAD/3/1", Mandatory = false)]
    public string? PartyName2 { get; set; }

    [EdiValue("X(70)", Path = "NAD/3/2", Mandatory = false)]
    public string? PartyName3 { get; set; }

    [EdiValue("X(70)", Path = "NAD/3/3", Mandatory = false)]
    public string? PartyName4 { get; set; }

    [EdiValue("X(70)", Path = "NAD/3/4", Mandatory = false)]
    public string? PartyName5 { get; set; }

    [EdiValue("X(3)", Path = "NAD/3/5", Mandatory = false)]
    public string? PartyNameFormatCode { get; set; }

    [EdiValue("X(256)", Path = "NAD/4/0", Mandatory = false)]
    public string? Street1 { get; set; }

    [EdiValue("X(256)", Path = "NAD/4/1", Mandatory = false)]
    public string? Street2 { get; set; }

    [EdiValue("X(256)", Path = "NAD/4/2", Mandatory = false)]
    public string? Street3 { get; set; }

    [EdiValue("X(256)", Path = "NAD/4/3", Mandatory = false)]
    public string? Street4 { get; set; }

    [EdiValue("X(35)", Path = "NAD/5", Mandatory = false)]
    public string? CityName { get; set; }

    [EdiValue("X(9)", Path = "NAD/6/0", Mandatory = false)]
    public string? CountrySubdivisionIdentifier { get; set; }

    [EdiValue("X(17)", Path = "NAD/6/1", Mandatory = false)]
    public string? CountryCodeListIdentificationCode { get; set; }

    [EdiValue("X(3)", Path = "NAD/6/2", Mandatory = false)]
    public string? CountryCodeListResponsibleAgencyCode { get; set; }

    [EdiValue("X(70)", Path = "NAD/6/3", Mandatory = false)]
    public string? CountrySubdivisionName { get; set; }

    [EdiValue("X(17)", Path = "NAD/7", Mandatory = false)]
    public string? PostalIdentificationCode { get; set; }

    [EdiValue("X(3)", Path = "NAD/8", Mandatory = false)]
    public string? CountryIdentifier { get; set; }

}