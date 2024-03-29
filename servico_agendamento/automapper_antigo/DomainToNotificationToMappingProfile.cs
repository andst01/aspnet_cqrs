using AutoMapper;
using SGAS.Domain.Entity;
using SGAS.Domain.Notifications;
using SGAS.Domain.Notifications.AspNetUserRoleEvent;

namespace SGAS.Infra.CrossCuting.AutoMapper
{
    public class DomainToNotificationToMappingProfile : Profile
    {
        public DomainToNotificationToMappingProfile() 
        {
            CreateMap<Agenda, AgendaNotification>();
            //CreateMap<Agenda, AgendaCreateNotification>();
            //CreateMap<Agenda, AgendaUpdateNotification>();
            //CreateMap<Agenda, AgendaDeleteNotification>();

            CreateMap<Agendamento, AgendamentoNotification>();
            //CreateMap<Agendamento, AgendamentoCreateNotification>();
            //CreateMap<Agendamento, AgendamentoUpdateNotification>();
            //CreateMap<Agendamento, AgendamentoDeleteNotification>();

            CreateMap<Cargo, CargoNotification>();
            //CreateMap<Cargo, CargoCreateNotification>();
            //CreateMap<Cargo, CargoUpdateNotification>();
            //CreateMap<Cargo, CargoDeleteNotification>();

            CreateMap<CargoFuncionario, CargoFuncionarioNotification>();
            //CreateMap<CargoFuncionario, CargoFuncionarioCreateNotification>();
            //CreateMap<CargoFuncionario, CargoFuncionarioUpdateNotification>();
            //CreateMap<CargoFuncionario, CargoFuncionarioDeleteNotification>();

            CreateMap<Cep, CepNotification>();
            //CreateMap<Cep, CepCreateNotification>();
            //CreateMap<Cep, CepUpdateNotification>();
            //CreateMap<Cep, CepDeleteNotification>();

            CreateMap<Cidade, CidadeNotification>();
            //CreateMap<Cidade, CidadeCreateNotification>();
            //CreateMap<Cidade, CidadeUpdateNotification>();
            //CreateMap<Cidade, CidadeDeleteNotification>();

            CreateMap<Cliente, ClienteNotification>();
            //CreateMap<Cliente, ClienteCreateNotification>();
            //CreateMap<Cliente, ClienteUpdateNotification>();
            //CreateMap<Cliente, ClienteDeleteNotification>();

            CreateMap<Empresa, EmpresaNotification>();
            //CreateMap<Empresa, EmpresaCreateNotification>();
            //CreateMap<Empresa, EmpresaUpdateNotification>();
            //CreateMap<Empresa, EmpresaDeleteNotification>();

            CreateMap<Endereco, EnderecoNotification>();
            //CreateMap<Endereco, EnderecoCreateNotication>();
            //CreateMap<Endereco, EnderecoUpdateNotification>();
            //CreateMap<Endereco, EnderecoDeleteNotification>();

            CreateMap<Fornecedor, FornecedorNotification>();
            //CreateMap<Fornecedor, FornecedorCreateNotification>();
            //CreateMap<Fornecedor, FornecedorUpdateNotification>();
            //CreateMap<Fornecedor, FornecedorDeleteNotification>();

            CreateMap<Funcionario, FuncionarioNotification>();
            //CreateMap<Funcionario, FuncionarioCreateNotification>();
            //CreateMap<Funcionario, FuncionarioUpdateNotification>();
            //CreateMap<Funcionario, FuncionarioDeleteNotification>();

            CreateMap<Funcao, FuncaoNotification>();
            //CreateMap<Funcao, FuncaoCreateNotification>();
            //CreateMap<Funcao, FuncaoUpdateNotification>();
            //CreateMap<Funcao, FuncaoDeleteNotification>();

            CreateMap<Usuario, UsuarioNotification>();
            //CreateMap<Usuario, UsuarioCreateNotification>();
            //CreateMap<Usuario, UsuarioUpdateNotification>();
            //CreateMap<Usuario, UsuarioDeleteNotification>();

            CreateMap<FuncaoUsuario, FuncaoUsuarioNotification>();
            //CreateMap<FuncaoUsuario, FuncaoUsuarioCreateNotification>();
            //CreateMap<FuncaoUsuario, FuncaoUsuarioUpdateNotification>();
            //CreateMap<FuncaoUsuario, FuncaoUsuarioDeleteNotification>();

            CreateMap<Fornecedor, FornecedorNotification>();
            //CreateMap<Fornecedor, FornecedorCreateNotification>();
            //CreateMap<Fornecedor, FornecedorUpdateNotification>();
            //CreateMap<Fornecedor, FornecedorDeleteNotification>();

            CreateMap<MesoRegiao, MesoRegiaoNotification>();
            //CreateMap<MesoRegiao, MesoRegiaoCreateNotification>();
            //CreateMap<MesoRegiao, MesoRegiaoUpdateNotification>();
            //CreateMap<MesoRegiao, MesoRegiaoDeleteNotification>();

            CreateMap<MicroRegiao, MicroRegiaoNotification>();
            //CreateMap<MicroRegiao, MicroRegiaoCreateNotification>();
            //CreateMap<MicroRegiao, MicroRegiaoUpdateNotification>();
            //CreateMap<MicroRegiao, MicroRegiaoDeleteNotification>();

            CreateMap<Regiao, RegiaoNotification>();
            //CreateMap<Regiao, RegiaoCreateNotification>();
            //CreateMap<Regiao, RegiaoUpdateNotification>();
            //CreateMap<Regiao, RegiaoDeleteNotification>();

            CreateMap<Servico, ServicoNotification>();
            //CreateMap<Servico, ServicoCreateNotification>();
            //CreateMap<Servico, ServicoUpdateNotification>();
            //CreateMap<Servico, ServicoDeleteNotification>();

            CreateMap<UnidadeVenda, UnidadeVendaNotification>();
            //CreateMap<UnidadeVenda, UnidadeVendaCreateNotification>();
            //CreateMap<UnidadeVenda, UnidadeVendaUpdateNotification>();
            //CreateMap<UnidadeVenda, UnidadeVendaDeleteNotification>();
        }
    }
}
