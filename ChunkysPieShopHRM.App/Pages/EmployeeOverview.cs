using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChunkysPieShopHRM.App.Services;
using ChunkysPieShopHRM.Shared;
using Microsoft.AspNetCore.Components;

namespace ChunkysPieShopHRM.App.Pages
{
    public partial class EmployeeOverview
    {
        public IEnumerable<Employee> Employees { get; set; }

        [Inject]
        public IEmployeeDataService EmployeeDataService { get; set; }
        protected override async Task OnInitializedAsync()
        {
            Employees = (await EmployeeDataService.GetAllEmployees()).ToList();
        }
    }
}
