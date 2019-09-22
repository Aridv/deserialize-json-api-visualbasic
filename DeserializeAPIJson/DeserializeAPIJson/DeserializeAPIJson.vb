Imports Newtonsoft.Json.Linq

Module DeserializeAPIJson

    Sub Main()

        Dim objectData = "{ '_name': 'Cristina', '_age': '26', '_country': 'ES', '_mobile': '123456789', '_email': 'git_test@example.com' }"
        Dim arrayData = "[{ '_name': 'Cristina', '_age': '26', '_country': 'ES', '_mobile': '123456789', '_email': 'git_test@example.com' }]"

        Dim jObj = JObject.Parse(objectData)
        Dim jArr = JArray.Parse(arrayData)

        Dim personResult = jObj.ToObject(Of Person)
        Dim personListResult = jArr.ToObject(Of List(Of Person))

        Console.WriteLine(personResult)
        Console.WriteLine(personListResult)
        Console.ReadLine()

    End Sub

End Module
