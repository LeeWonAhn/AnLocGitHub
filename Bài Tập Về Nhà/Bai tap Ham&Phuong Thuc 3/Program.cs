namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] a = { 4, 66, 33, 63, 11 };
            xoaPhanTuKhoiMang (a,66);
        }
        private static void xoaPhanTuKhoiMang(float[] mangr, int soCanXoa){
        for (int i = 0; i < mangr.Length; i++){
            Console.Write(mangr[i] + " ");
        }

        int indexToRemove = 0;

        for(int i = 0; i < mangr.Length; i ++) {
            if(mangr[i] == soCanXoa){
                indexToRemove = 1;
            }
        }
        Console.WriteLine();
        if(indexToRemove == -1){
            Console.WriteLine("Khong tim thay gia tri " + soCanXoa);
            return;
        }
        for(int i = indexToRemove; i < mangr.Length; i ++){
            if(i== mangr.Length - 1){
                mangr[i] = 0;
            }
            else{
                mangr[i] = mangr [i+1];
                }
        }
    }
    }
}