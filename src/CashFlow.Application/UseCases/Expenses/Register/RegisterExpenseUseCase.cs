using CashFlow.Communication.Requests;
using CashFlow.Communication.Responses;

namespace CashFlow.Application.UseCases.Expenses.Register
{
    public class RegisterExpenseUseCase
    {
        public ResponseRegisterExpenseJson Execute(RequestExpenseJson request)
        {
            var useCase = new RegisterExpenseUseCase();

            var response = useCase.Execute(request);

            return new ResponseRegisterExpenseJson();
        }
    }
}
