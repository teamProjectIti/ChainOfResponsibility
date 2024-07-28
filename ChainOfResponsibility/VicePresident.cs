namespace ChainOfResponsibility
{
    internal class VicePresident : IManager
    {
        private IManager manager;
        public void ApproveRequest(ExpenseReport expenseReport)
        {
            if (expenseReport.Amount < 1000) Console.WriteLine("Approved by VP");
            else manager?.ApproveRequest(expenseReport);
        }

        public void SetSupervisor(IManager manager)
        {
            this.manager = manager;
        }
    }
}
