Console.Clear();
string[] FillArray(){
    Console.Write("Сколько слов вы хотите ввести?: ");
    int size = Convert.ToInt32 (Console.ReadLine());
    string[] array = new string [size];
    for (int i = 0; i < size; i++){
        Console.Write("Введите слово: ");
        string? word = Console.ReadLine();
        if (word == ""){
            Console.WriteLine("Ошибка: пустой ввод.\n");
            i--;
        } 
        else array[i] = word;
    }
    
    return array;
}

string[] SortedArray(string[] array){
    int size = 0;
    for (int i = 0; i < array.Length; i++){
        if(array[i].Length <= 3) size++;
    }
    if (size == 0){
        Console.WriteLine("Среди введенных слов, нет слов содержащих 3 и менее символов.");
    }

    string[] sortedArray = new string [size];
    int m = 0;
        for (int i = 0; i < array.Length; i++)
            if(array[i].Length <= 3){ 
                sortedArray[m] = array[i];
                m++;
            }

    return sortedArray;
}

void ShowArray(string[] sortedArray){
    for (int i = 0; i < sortedArray.Length; i++)
        Console.Write(sortedArray[i] + " ");
}

ShowArray(SortedArray(FillArray()));