page 50100 MyPage
{

    layout
    {
        area(Content)
        {
            field(myInt; myInt)
            {
                [|Editable = false;|]
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
                [|Editable = false;|]
            }
        }

        modify(myInt)
        {
            [|Editable = false;|]
        }
    }

    var
        MyText: Text[100];
}