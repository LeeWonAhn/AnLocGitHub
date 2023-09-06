public class BankAccount
{
    public static string specialName;
    private String name ;
    private double moneyCount;
    private String address;
    private double phoneNumber;
    public string Name => name;
    public double MoneyCount => moneyCount;
    public string Address => address;
    public double PhoneNumber => phoneNumber;
    public BankAccount(){
        
    }

    // BankAccount account1 = new BankAccount("ten, 100000, 0906669985)
    public BankAccount(string Name, double moneyCount, double phoneNumber){
        this.moneyCount = moneyCount;
        this.name = Name;
        this.phoneNumber = phoneNumber;
    }

    public bool MakeWithdraw(double amount)
    {
        if (moneyCount<amount)
        {
            return false;
        }else
        {
             moneyCount -= amount;
             return true;
        }
    }

    public bool MakeWithdraw(double amount, double amount2){
        if (moneyCount<amount)
        {
            return false;
        }else
        {
             moneyCount -= amount;
             return true;
        }
        }
}