using CashFlow.Communication.Requests;
using CommonTestUtilities.Requests;

namespace Validators.Test.Expenses.Register
{
    public class RegisterExpensesValidatorTests
    {
        [Fact]
        public void Success()
        {
            //Arrange
            var validator = new RegisterExpensesValidatorTests();
            var request = RequestExpenseJsonBuilder.Build();


            //Act
            /*var result = validator.Validate(request);*/

            //Assert
            /* Assert.True(result.IsValid);*/
        }
    }
}
