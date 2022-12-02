Console.Clear();
int[] arr = new int[8];
for(int i =0; i<arr.Length;i++){
    Console.WriteLine($"Введите {i+1} элемент массива: ");
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"[{string.Join(", ", arr)}]");