var twoXSquare = Extensions.Compose((int x) => x * 2, (int y) => y * y + 1); // (2x)^2
var maybeSmth = Maybe<int>.FromValue(10);
Console.WriteLine(maybeSmth.GetValue);
Console.WriteLine($"1) From value: {maybeSmth.GetValue}");
Console.WriteLine($"1) Mapped: {maybeSmth.Map(twoXSquare).GetValue}");
var maybeSmth2 = Maybe<int>.None(); // Since an int is not a reference (it's a struct), we'll get 0 as default value of type T
Console.WriteLine($"2) From value: {maybeSmth2.GetValue}");
Console.WriteLine($"2) Mapped: {maybeSmth2.Map(twoXSquare).GetValue}");
var maybeSmth3 = Maybe<Amount>.None(); // Since an Amount is a reference (it's a class), we'll get null as default value of type T
Console.WriteLine($"3) From value: {maybeSmth3.GetValue}");
Console.WriteLine($"3) Mapped: {maybeSmth3.Map((Amount t) => new Amount(twoXSquare(t.Quantity))).GetValue}");
var maybeSmth4 = Maybe<Amount>.FromValue(new Amount(250));
Console.WriteLine($"4) From value: {maybeSmth4.GetValue}");
Console.WriteLine($"4) Mapped: {maybeSmth4.Map((Amount t) => twoXSquare(t.Quantity)).GetValue}");