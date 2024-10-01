codeunit 50100 MyCodeunit
{
    procedure MyProcedure()
    var
        MyTable: Record MyTable;
    begin
        [|MyTable.Get(1, 2);|]
    end;
}

table 50100 MyTable
{
    fields
    {
        field(1; MyField; Integer) { }
        field(2; MyField2; Integer) { }
    }

    keys
    {
        key(Key1; MyField, MyField2) { Clustered = true; }
    }
}