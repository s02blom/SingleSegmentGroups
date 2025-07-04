using indice.Edi.Serialization;

namespace SingleSegmentGroups;

[EdiMessage]
public class PRODAT
{

    [EdiValue("X(14)", Path = "UNH/0/0")]
    public string MessageRef { get; set; }


    [EdiValue("X(6)", Path = "UNH/1/0")]
    public string MessageType { get; set; }

    [EdiValue("X(3)", Path = "UNH/1/1")]
    public string Version { get; set; }

    [EdiValue("X(3)", Path = "UNH/1/2")]
    public string ReleaseNumber { get; set; }

    [EdiValue("X(2)", Path = "UNH/1/3")]
    public string ControllingAgency { get; set; }

    [EdiValue("X(6)", Path = "UNH/1/4")]
    public string AssociationAssignedCode { get; set; }

    [EdiValue("X(35)", Path = "UNH/2/0")]
    public string CommonAccessRef { get; set; }

    [EdiValue("X(3)", Path = "BGM/0/0")]
    public string MessageName { get; set; }

    [EdiValue("X(35)", Path = "BGM/1/0")]
    public string DocumentNumber { get; set; }

    [EdiValue("X(3)", Path = "BGM/2/0", Mandatory = false)]
    public string MessageFunction { get; set; }

    [EdiValue("X(3)", Path = "BGM/3/0")]
    public string ResponseType { get; set; }

    public IList<DTM>? Dates { get; set; }

    public IList<FTX>? FTX { get; set; }

    //[EdiSegmentGroup("RFF")]
    //public IList<RFF>? References { get; set; }
    public IList<SegmentGroup3>? References { get; set; }

    public IList<SegmentGroup4>? Parties { get; set; }

    public required UNT Unt { get; set; }

    [EdiSegmentGroup("NAD", "CTA", "RFF")]
    public record class SegmentGroup4 : NAD
    {
        public IList<SegmentGroup5>? Contacts { get; set; }
        public IList<SegmentGroup6>? References { get; set; }
    }


    [EdiSegmentGroup("CTA", "COM")]
    public class SegmentGroup5 : CTA
    {
        public IList<COM>? COM { get; set; }
    }

    [EdiSegmentGroup("RFF")]
    public record class SegmentGroup6 : RFF
    {
    }

    [EdiSegmentGroup("RFF")]
    public record class SegmentGroup3 : RFF
    {
    }

}