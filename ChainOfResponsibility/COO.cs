namespace ChainOfResponsibility
{
    internal class COO : IManager
    {
        private IManager manager;
        public void ApproveRequest(ExpenseReport expenseReport)
        {
            if (expenseReport.Amount < 5000) Console.WriteLine("Approved by COO");
            else Console.WriteLine("No approved");
        }

        public void SetSupervisor(IManager manager)
        {
            this.manager = manager;
        }
    }
}
