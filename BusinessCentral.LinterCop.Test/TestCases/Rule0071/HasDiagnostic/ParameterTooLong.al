codeunit 50100 MyCodeunit
{
    procedure MyProcedure()
    var
        MyTable: Record MyTable;
        MyCode: Code[50];
    begin
        MyCode := 'Dummy';
        [|MyTable.Get(MyCode);|]
    end;
}

table 50100 MyTable
{
    fields
    {
        field(1; MyField; Code[20]) { }
    }

    keys
    {
        key(Key1; MyField) { Clustered = true; }
    }
}