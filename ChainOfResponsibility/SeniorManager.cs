namespace ChainOfResponsibility
{
    public class SeniorManager : IManager
    {
        private IManager manager;
        public void ApproveRequest(ExpenseReport expenseReport)
        {
            if (expenseReport.Amount < 500) Console.WriteLine("Approved by Manager");
            else manager?.ApproveRequest(expenseReport);
        }

        public void SetSupervisor(IManager manager)
        {
            this.manager = manager;
        }
    }
}
