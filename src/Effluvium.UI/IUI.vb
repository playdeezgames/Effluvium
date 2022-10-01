Public Interface IUI
    Sub Clear()
    Sub WriteLine(line As String)
    Function Prompt(title As String, ParamArray choices As String()) As String
End Interface
