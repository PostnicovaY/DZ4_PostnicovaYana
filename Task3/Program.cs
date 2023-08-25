// Задача 29: Напишите программу, которая 
// задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

string ArrayOutput (int[] arr){
    string arrayOutput = String.Join(" ", arr);
    string arrayOutput2 = String.Join(", ", arr);
    Console.WriteLine(arrayOutput + " -> [" + arrayOutput2 + "]");
    return arrayOutput;
}

int[] Array (int number, int range){
    int[] arr = new int[number];
    Random rand = new Random();
    
    for (int i = 0; i < number; i++){
        arr[i] = rand.Next(range);
        Console.Write($"{arr[i]} "); // вывожу для наглядности    
    }

    int mid = 5;
    int[] first = arr.Take(mid).ToArray();
    int[] second = arr.Skip(mid).ToArray();
 
    Console.WriteLine();
    ArrayOutput(first);
    ArrayOutput(second);    
    return arr;
}

Array(8, 32);
