using indice.Edi.Serialization;

namespace SingleSegmentGroups;


[EdiSegment, EdiPath("RFF")]
public record class RFF
{
    [EdiValue("X(3)", Path = "RFF/0/0", Mandatory = true)]
    public required string ReferenceCodeQualifier { get; set; }
 
    [EdiValue("X(70)", Path = "RFF/0/1", Mandatory = false)]
    public string? ReferenceIdentifier { get; set; }

    [EdiValue("X(6)", Path = "RFF/0/2", Mandatory = false)]
    public string? DocumentLineIdentifier { get; set; }
    
    [EdiValue("X(9)", Path = "RFF/0/3", Mandatory = false)]
    public string? VersionIdentifier { get; set; }
    
    [EdiValue("X(6)", Path = "RFF/0/4", Mandatory = false)]
    public string? RevisionIdentifier { get; set; }

}