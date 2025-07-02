using indice.Edi.Serialization;

namespace SingleSegmentGroups;

[EdiSegment, EdiPath("DTM")]
public record class DTM
{

    [EdiValue("X(3)", Path = "DTM/0/0", Mandatory = true)]
    public required string DateTimeQualifier { get; set; }

    [EdiValue("X(35)", Path = "DTM/0/1", Mandatory = false)]
    public string? DateTime { get; set; }

    [EdiValue("X(3)", Path = "DTM/0/2", Mandatory = false)]
    public string? FormatCode { get; set; }
}