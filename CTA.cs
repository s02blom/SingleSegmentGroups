using indice.Edi.Serialization;

namespace SingleSegmentGroups;

[EdiSegment, EdiPath("CTA")]
public class CTA
{

    [EdiValue("X(3)", Path = "CTA/0", Mandatory = false)]
    public string? ContactFunctionCode { get; set; }

    [EdiValue("X(17)", Path = "CTA/1/0", Mandatory = false)]
    public string? ContactIdentifier { get; set; }

    [EdiValue("X(256)", Path = "CTA/1/1", Mandatory = false)]
    public string? ContactName { get; set; }
}