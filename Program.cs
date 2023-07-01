

// See https://aka.ms/new-console-template for more information
Console.WriteLine(string.Format("Calc01Before : {0:F4}", (new Calc01Before()).Energy_J()));
Console.WriteLine(string.Format("Calc02Working : {0:F4}", (new Calc02Working()).Energy_J().Value));
Console.WriteLine(string.Format("Calc03WorkingWithMistake : {0:F4}", (new Calc03WorkingWithMistake()).Energy_J().Value));
Console.WriteLine(string.Format("Calc10DoneWithError : {0:F4}", (new Calc10DoneWithError()).Energy_J().Value));
Console.WriteLine(string.Format("Calc11Done : {0:F4}", (new Calc11Done()).Energy_J().Value));
