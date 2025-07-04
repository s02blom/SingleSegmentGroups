using indice.Edi.Serialization;

namespace SingleSegmentGroups;

[EdiSegment, EdiPath("UNT")]
public record UNT
{
    [EdiValue("9(10)", Path = "UNT/0", Description = "Number of Segments in Message", Mandatory = true)]
    [EdiCount(EdiCountScope.Segments)]
    public required int SegmentCount { get; set; }

    [EdiValue("X(14)", Path = "UNT/1", Description = "Message Reference Number", Mandatory = true)]
    public required string MessageRefNum { get; set; }
}