namespace Task_3
{
    internal interface IAccountService
    {

        void New_account(string ownerName, double initialBalance, string accountNumber);

        void Delete_account();
    }
}
