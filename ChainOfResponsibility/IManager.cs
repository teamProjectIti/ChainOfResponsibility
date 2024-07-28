namespace ChainOfResponsibility
{
    public record ExpenseReport(string Name, int Amount);
    public interface IManager
    {
        void SetSupervisor(IManager manager);
        void ApproveRequest(ExpenseReport expenseReport);
    }
}
