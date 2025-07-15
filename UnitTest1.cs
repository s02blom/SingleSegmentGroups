using indice.Edi;
using System.Text;

namespace SingleSegmentGroups;

public class UnitTest1
{
    private readonly IEdiGrammar grammar = EdiGrammar.NewEdiFact();
    private readonly EdiSerializer serializer = new EdiSerializer();

    [Fact]
    public void Test1()
    {
        var interchange = new Interchange()
        {
            DateOfPreparation = new DateTime(2025, 01, 02, 03, 04, 00, DateTimeKind.Utc),
            Message = new()
            {
                MessageRef = "1",
                Dates =
                [
                    new ()
                    {
                        DateTimeQualifier = "137",
                        DateTime = "202506150701",
                        FormatCode = "203",
                    },
                    new ()
                    {
                        DateTimeQualifier = "ZZZ",
                        DateTime = "1",
                        FormatCode = "805"
                    }
                ],
                References =
                [
                    new ()
                    {
                        ReferenceCodeQualifier = "Z05",
                        ReferenceIdentifier = "SYL",
                    },
                    new ()
                    {
                        ReferenceCodeQualifier = "LI",
                        ReferenceIdentifier = "02382812480014",
                    },
                    new ()
                    {
                        ReferenceCodeQualifier = "Z09",
                        ReferenceIdentifier = "P015673",
                    }
                ],
                Parties =
                [
                    new ()
                    {
                        PartyFunctionCodeQualifier = "FR",
                        PartyIdentifier = "22222",
                        CodeListIdentificationCode = "160",
                        CodeListResponsibleAgencyCode = "SVK",
                        CountryIdentifier = "SE",
                    },
                    new ()
                    {
                        PartyFunctionCodeQualifier = "DO",
                        PartyIdentifier = "11111",
                        CodeListIdentificationCode = "160",
                        CodeListResponsibleAgencyCode = "SVK",
                        CountryIdentifier = "SE",
                    }
                ],
                Unt = new()
                { 
                    MessageRefNum = "1",
                    SegmentCount = 10
                }
            }            
        };
        var actual = SerializerDeserializer(interchange);
        actual.Should().BeEquivalentTo(interchange);
    }

    private Interchange SerializerDeserializer(Interchange interchange)
    {

        var edifact = Serialize(interchange);

        return Deserialize<Interchange>(edifact);
    }

    private string Serialize<T>(T interchange)
    {
        var writer = new StringWriter();
        serializer.Serialize(writer, grammar, interchange);
        return writer.ToString();
    }

    private T Deserialize<T>(string edifact)
    {
        var mem = new MemoryStream(Encoding.ASCII.GetBytes(edifact));
        var reader = new StreamReader(mem);
        return serializer.Deserialize<T>(reader, grammar);
    }
}
