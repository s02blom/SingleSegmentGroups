using indice.Edi.Serialization;

namespace SingleSegmentGroups;

[EdiSegment, EdiPath("FTX")]
public class FTX
{

    [EdiValue("X(3)", Path = "FTX/0", Mandatory = true)]
    public required string TextSubjectQualifier { get; set; }

    [EdiValue("X(3)", Path = "FTX/1", Mandatory = false)]
    public string? TextFunctionCode { get; set; }

    [EdiValue("X(17)", Path = "FTX/2/0", Mandatory = false)]
    public string? TextDescriptionCode { get; set; }

    [EdiValue("X(17)", Path = "FTX/2/1", Mandatory = false)]
    public string? CodeListIdentificationCode { get; set; }

    [EdiValue("X(3)", Path = "FTX/2/2", Mandatory = false)]
    public string? CodeListAgencyCode { get; set; }

    [EdiValue("X(512)", Path = "FTX/3/0", Mandatory = false)]
    public string? FreeText1 { get; set; }

    [EdiValue("X(512)", Path = "FTX/3/1", Mandatory = false)]
    public string? FreeText2 { get; set; }

    [EdiValue("X(512)", Path = "FTX/3/2", Mandatory = false)]
    public string? FreeText3 { get; set; }

    [EdiValue("X(512)", Path = "FTX/3/3", Mandatory = false)]
    public string? FreeText4 { get; set; }

    [EdiValue("X(512)", Path = "FTX/3/4", Mandatory = false)]
    public string? FreeText5 { get; set; }

    [EdiValue("X(3)", Path = "FTX/4", Mandatory = false)]
    public string? LanguageNameCode { get; set; }

    [EdiValue("X(3)", Path = "FTX/5", Mandatory = false)]
    public string? FormatCode { get; set; }
}