using System;
using static System.Console;
Clear();

string[] array = EnteredArray();



string[] EnteredArray() {
    Write("Введите строки через пробел: ");
    return ReadLine().Split(" ");
}