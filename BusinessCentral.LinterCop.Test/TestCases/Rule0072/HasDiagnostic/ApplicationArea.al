page 50100 MyPage
{
    ApplicationArea = All;

    layout
    {
        area(Content)
        {
            field(myInt; myInt)
            {
                [|ApplicationArea = All;|]
            }
        }
    }
    var
        myInt: Integer;
}