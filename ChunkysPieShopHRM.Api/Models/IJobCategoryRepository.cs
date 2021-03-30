using System.Collections.Generic;
using ChunkysPieShopHRM.Shared;

namespace ChunkysPieShopHRM.Api.Models
{
    public interface IJobCategoryRepository
    {
        IEnumerable<JobCategory> GetAllJobCategories();
        JobCategory GetJobCategoryById(int jobCategoryId);
    }
}
