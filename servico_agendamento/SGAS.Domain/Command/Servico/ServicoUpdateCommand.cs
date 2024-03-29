using SGAS.Domain.Validations;
using System;

namespace SGAS.Domain.Command
{
    public class ServicoUpdateCommand : ServicoCommand
    {

        //public ServicoUpdateCommand(
        //   int id,
        //   int idAgendamento,
        //   int idusuarioResponsavel,
        //   int codigoServico,
        //   DateTime dataCadastro,
        //   int idUsuarioCriacao,
        //   int quantidadeParcelas,
        //   decimal valorTotal)
        //{
        //    Id = id;
        //    IdAgendamento = idAgendamento;
        //    IdUsuarioResponsavel = idusuarioResponsavel;
        //    CodigoServico = codigoServico;
        //    DataCadastro = dataCadastro;
        //    IdUsuarioCriacao = idUsuarioCriacao;
        //    QuantidadeParcelas = quantidadeParcelas;
        //    ValorTotal = valorTotal;
        //}
        public override bool IsValid()
        {
            ValidationResult = new ServicoUpdateValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
