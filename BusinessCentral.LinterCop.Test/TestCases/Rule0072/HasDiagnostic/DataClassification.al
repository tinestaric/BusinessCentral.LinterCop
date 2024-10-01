table 50100 MyTable
{
    DataClassification = CustomerContent;
    fields
    {
        field(1; MyField; Code[20])
        {
            [|DataClassification = CustomerContent;|]
        }
    }

    keys
    {
        key(Key1; MyField) { Clustered = true; }
    }
}