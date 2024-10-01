page 50100 MyPage
{
    Editable = false;

    layout
    {
        area(Content)
        {
            field(myInt; myInt)
            {
                [|Editable = true;|]
            }
        }
    }
    var
        myInt: Integer;
}

pageextension 50100 MyExtension extends MyPage
{
    layout
    {
        addlast(Content)
        {
            field(MyText; MyText)
            {
                [|Editable = true;|]
            }
        }

        modify(myInt)
        {
            [|Editable = true;|]
        }
    }

    var
        MyText: Text[100];
}