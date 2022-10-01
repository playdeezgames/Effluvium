Public Module ConfirmProcessor
    Function Confirm(ui As IUI, title As String) As Boolean
        Return ui.Prompt(title, NoChoice, YesChoice) = YesChoice
    End Function
End Module
