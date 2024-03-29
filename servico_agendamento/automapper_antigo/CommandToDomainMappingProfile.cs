using AutoMapper;
using SGAS.Domain.Command;
using SGAS.Domain.Entity;

namespace SGAS.Infra.CrossCuting.AutoMapper
{
    public class CommandToDomainMappingProfile : Profile
    {
        public CommandToDomainMappingProfile()
        {
            CreateMap<AgendaCreateCommand, Agenda>();
            CreateMap<AgendaUpdateCommand, Agenda>();
            CreateMap<AgendaDeleteCommand, Agenda>();

            CreateMap<AgendamentoCreateCommand, Agendamento>();
            CreateMap<AgendamentoUpdateCommand, Agendamento>();
            CreateMap<AgendamentoDeleteCommand, Agendamento>();

            CreateMap<CargoCreateCommand, Cargo>();
            CreateMap<CargoUpdateCommand, Cargo>();
            CreateMap<CargoDeleteCommand, Cargo>();

            CreateMap<CargoFuncionarioCreateCommand, CargoFuncionario>();
            CreateMap<CargoFuncionarioUpdateCommand, CargoFuncionario>();
            CreateMap<CargoFuncionarioDeleteCommand, CargoFuncionario>();

            CreateMap<CepCreateCommand, Cep>();
            CreateMap<CepUpdateCommand, Cep>();
            CreateMap<CepDeleteCommand, Cep>();

            CreateMap<CidadeCreateCommand, Cidade>();
            CreateMap<CidadeUpdateCommand, Cidade>();
            CreateMap<CidadeDeleteCommand, Cidade>();

            CreateMap<ClienteCreateCommand, Cliente>();
            CreateMap<ClienteUpdateCommand, Cliente>();
            CreateMap<ClienteDeleteCommand, Cliente>();

            CreateMap<EmpresaCreateCommand, Empresa>();
            CreateMap<EmpresaUpdateCommand, Empresa>();
            CreateMap<EmpresaDeleteCommand, Empresa>();

            CreateMap<EnderecoCreateCommand, Endereco>();
            CreateMap<EnderecoUpdateCommand, Endereco>();
            CreateMap<EnderecoDeleteCommand, Endereco>();

            CreateMap<FornecedorCreateCommand, Fornecedor>();
            CreateMap<FornecedorUpdateCommand, Fornecedor>();
            CreateMap<FornecedorDeleteCommand, Fornecedor>();

            CreateMap<FuncionarioCreateCommand, Funcionario>();
            CreateMap<FuncionarioUpdateCommand, Funcionario>();
            CreateMap<FuncionarioDeleteCommand, Funcionario>();

            CreateMap<FuncaoCreateCommand, Funcao>();
            CreateMap<FuncaoUpdateCommand, Funcao>();
            CreateMap<FuncaoDeleteCommand, Funcao>();

            CreateMap<UsuarioCreateCommand, Usuario>();
            CreateMap<UsuarioUpdateCommand, Usuario>();
            CreateMap<UsuarioDeleteCommand, Usuario>();

            CreateMap<FuncaoUsuarioCreateCommand, FuncaoUsuario>();
            CreateMap<FuncaoUsuarioUpdateCommand, FuncaoUsuario>();
            CreateMap<FuncaoUsuarioDeleteCommand, FuncaoUsuario>();

            CreateMap<FornecedorCreateCommand, Fornecedor>();
            CreateMap<FornecedorUpdateCommand, Fornecedor>();
            CreateMap<FornecedorDeleteCommand, Fornecedor>();

            CreateMap<MesoRegiaoCreateCommand, MesoRegiao>();
            CreateMap<MesoRegiaoUpdateCommand, MesoRegiao>();
            CreateMap<MesoRegiaoDeleteCommand, MesoRegiao>();

            CreateMap<MicroRegiaoCreateCommand, MicroRegiao>();
            CreateMap<MicroRegiaoUpdateCommand, MicroRegiao>();
            CreateMap<MicroRegiaoDeleteCommand, MicroRegiao>();

            CreateMap<RegiaoCreateCommand, Regiao>();
            CreateMap<RegiaoUpdateCommand, Regiao>();
            CreateMap<RegiaoDeleteCommand, Regiao>();

            CreateMap<ServicoCreateCommand, Servico>();
            CreateMap<ServicoUpdateCommand, Servico>();
            CreateMap<ServicoDeleteCommand, Servico>();

            CreateMap<UnidadeVendaCreateCommand, UnidadeVenda>();
            CreateMap<UnidadeVendaUpdateCommand, UnidadeVenda>();
            CreateMap<UnidadeVendaDeleteCommand, UnidadeVenda>();

        }
    }
}
