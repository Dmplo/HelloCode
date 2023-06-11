int[] arr = {1, 12, 31, 4, 15, 61, 71, 84};

int count = arr.Length;

int find = 84;

int index = 0;

while (index < count) {
    if(arr[index] == find) {
        Console.WriteLine(index);
    }
    index++;
}

