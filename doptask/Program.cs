Console.Clear();
Console.WriteLine("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int [] arr = new int[n];
for(int i =0; i<arr.Length; i++){
    Console.WriteLine($"Введите {i+1} элемент массива: ");
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Введите число К: ");
int K = Convert.ToInt32(Console.ReadLine());
int[] arr2 = new int[n];
if(K>0){
  for(int i = 0; i<arr.Length-1;i++){
    for(int j = 0; j<arr2.Length-1;j++){
      if(i == 0 || i == 1){ 
      j = i+K;} else j = i-2;
    }
  }
} 
// else if(K<0){
//    for(int i = 0; i<arr.Length;i++){
//     for(int j = 0; j<arr2.Length-1;j++){
//       arr[i] = arr2[j-K];
//     }
//   }
// }
Console.WriteLine($"[{string.Join(", ", arr2)}]");