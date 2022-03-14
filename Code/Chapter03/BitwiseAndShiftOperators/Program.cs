int a = 10; // 0000 1010
int b = 6;  // 0000 0110

Console.WriteLine($"a = {a}");
Console.WriteLine($"b = {b}");

Console.WriteLine($"a & b = {a & b}"); // 2-bit column only
Console.WriteLine($"a | b = {a | b}"); // 8, 4, and 2-bit columns
Console.WriteLine($"a ^ b = {a ^ b}"); // 8 and 4-bit columns

Console.WriteLine($"a << 3 = {a << 3}"); // 0101 0000 left-shift by a three bit columns
Console.WriteLine($"a * 8 = {a * 8}"); // multiply a by 8
Console.WriteLine($"b >> 1 = {b >> 1}"); // right-shift b by one bit column
