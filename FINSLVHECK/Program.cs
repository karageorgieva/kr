using System;
using static System.Console;
Clear();

string[] array = EnteredArray();

string[] result = FindLessThree(array, 3);

WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", result)}]");

string[] EnteredArray() {
    Write("Введите строки через пробел: ");
    return ReadLine().Split(" ");
}
string[] FindLessThree(string[] input, int n) {
    string[] output = new string[CountLessThree(input, n)];

    for(int i = 0, a = 0; i < input.Length; i++) {
        if(input[i].Length <= n) {
            output[a] = input[i];
            a++;
        }
    }

    return output;
}
int CountLessThree(string[] input, int n) {
    int count = 0;

    for(int i = 0; i < input.Length; i++) {
        if(input[i].Length <= n) {
            count++;
        }
    }

    return count;
}