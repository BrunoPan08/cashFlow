using AutoMapper;
using CashFlow.Communication.Enums;
using CashFlow.Communication.Requests;
using CashFlow.Communication.Responses;
using CashFlow.Domain.Entities;
using CashFlow.Domain.Repositories;
using CashFlow.Domain.Repositories.Expenses;
using CashFlow.Exception.ExceptionsBase;
using CashFlow.Infrastructure.DataAccess;

namespace CashFlow.Application.UseCases.Expenses.Register
{
    public class RegisterExpenseUseCase : IRegisterExpenseUseCase
    {
        private readonly IExpenseRepository _repository;

        private readonly IUnitOfWork _unitOfWork;

        private readonly IMapper _mapper;

        public RegisterExpenseUseCase(
            IExpenseRepository repository, 
            IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ResponseRegisterExpenseJson> Execute(RequestExpenseJson request)
        {
            Validate(request);


            var entity = _mapper.Map<Expense>(request);

            await _repository.Add(entity);

            await _unitOfWork.Commit();

            return _mapper.Map<ResponseRegisterExpenseJson>(entity);
        }

        private void Validate(RequestExpenseJson request)
        {
            var validator = new RegisterExpenseValidator();

            var result = validator.Validate(request);

            if (result.IsValid == false)
            {
                var errorMessages = result.Errors.Select(f => f.ErrorMessage).ToList();

                throw new ArgumentException("This message is invalid");

                //throw new ErrorOnValidationException(errorMessages);
            }
        }
    }
}
