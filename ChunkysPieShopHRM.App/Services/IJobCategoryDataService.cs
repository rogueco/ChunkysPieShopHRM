using System.Collections.Generic;
using System.Threading.Tasks;
using ChunkysPieShopHRM.Shared;

namespace ChunkysPieShopHRM.App.Services
{
    public interface IJobCategoryDataService
    {
        Task<IEnumerable<JobCategory>> GetAllJobCategories();
        Task<JobCategory> GetJobCategoryById(int jobCategoryId);
    }
}
