page 50100 MyPage
{
    ApplicationArea = AccountData;

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