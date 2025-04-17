class Program
{
    static void Main(string[] args)
    {
        var config = BankTransferConfig.LoadConfig();
        bool isEnglish = config.lang == "en";

        Console.WriteLine(isEnglish ? "Please insert the amount of money to transfer:" : "Masukkan jumlah uang yang akan di-transfer:");
        int amount = int.Parse(Console.ReadLine());

        int fee = amount <= config.transfer.threshold ? config.transfer.low_fee : config.transfer.high_fee;
        int total = amount + fee;

        if (isEnglish)
        {
            Console.WriteLine($"Transfer fee = {fee}");
            Console.WriteLine($"Total amount = {total}");
            Console.WriteLine("Select transfer method:");
        }
        else
        {
            Console.WriteLine($"Biaya transfer = {fee}");
            Console.WriteLine($"Total biaya = {total}");
            Console.WriteLine("Pilih metode transfer:");
        }

        for (int i = 0; i < config.methods.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {config.methods[i]}");
        }

        Console.ReadLine(); // Input pilihan metode (tidak digunakan lebih lanjut)

        string confirmationText = isEnglish ? config.confirmation.en : config.confirmation.id;
        Console.WriteLine(isEnglish ? $"Please type \"{confirmationText}\" to confirm the transaction:" : $"Ketik \"{confirmationText}\" untuk mengkonfirmasi transaksi:");
        string confirmationInput = Console.ReadLine();

        if (confirmationInput.ToLower() == confirmationText.ToLower())
        {
            Console.WriteLine(isEnglish ? "The transfer is completed" : "Proses transfer berhasil");
        }
        else
        {
            Console.WriteLine(isEnglish ? "Transfer is cancelled" : "Transfer dibatalkan");
        }
    }
}
