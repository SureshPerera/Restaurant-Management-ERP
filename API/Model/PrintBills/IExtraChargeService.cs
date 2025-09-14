using ResortManagementApp.Models.Administration.ManageExtra;

namespace API.Model.PrintBills
{
    public interface IExtraChargeService
    {
        Task<ExtraChanrgers?> GetByIdAsync(Guid id);
    }
}
