using CashFlow.Communication.Responses;
using CashFlow.Domain.Repositories.Expenses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashFlow.Application.UseCases.Expenses.GetAll
{
    public class GetAllExpenseUseCase : IGetAllExpenseUseCase
    {
        private readonly IExpenseRepository _repository;
        public GetAllExpenseUseCase(IExpenseRepository repository)
        {
            _repository = repository;
        }

        /*public async Task<ResponseRegisterExpenseJson> Execute()
        {
            var result = await _repository.GetAll();
        }*/
    }
}
