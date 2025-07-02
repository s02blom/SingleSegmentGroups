using indice.Edi.Serialization;

namespace SingleSegmentGroups;

[EdiSegment, EdiPath("COM")]
public class COM
{

    [EdiValue("X(512)", Path = "COM/0/0", Mandatory = true)]
    public required string AddressIdentifier { get; set; }
    
    [EdiValue("X(3)", Path = "COM/0/1", Mandatory = true)]
    public required string CommMeansTypeCode { get; set; }
}
