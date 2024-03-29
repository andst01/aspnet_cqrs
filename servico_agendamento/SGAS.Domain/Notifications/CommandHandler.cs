using FluentValidation.Results;
using SGAS.Domain.Interfaces.Repository;
using System;
using System.Threading.Tasks;

namespace SGAS.Domain.Notifications
{
    public abstract class CommandHandler 
    {
        protected ValidationResult ValidationResult;

        protected CommandHandler()
        {
            ValidationResult = new ValidationResult();
        }

        protected void AddError(string mensagem)
        {
            ValidationResult.Errors.Add(new ValidationFailure(string.Empty, mensagem));
        }

        protected async Task<ValidationResult> Commit<T>(IBaseRepository<T> uow, string message) where T : class
        {
            if (!await uow.Commit()) AddError(message);

            return ValidationResult;
        }
        protected async Task<ValidationResult> Commit<T>(IBaseRepository<T> uow) where T : class
        {
            var objeto = Activator.CreateInstance<T>();
            string nome = objeto.GetType().Name;
            return await Commit(uow, "There was an error saving data").ConfigureAwait(false);
        }

        //protected async Task<ValidationResult> PublisEvent<T>(IBaseRepository<T> uow) where T : class
        //{
        //    var objeto = Activator.CreateInstance<T>();
        //    string nome = objeto.GetType().Name;
        //    if (!await uow.PublishEvent() ?? false) AddError("There was an error saving data");

        //    return ValidationResult;

        //}

       
    }


}
