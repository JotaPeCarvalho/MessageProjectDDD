using Domain.Interfaces.InterfaceServices;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class ServiceMessage : IServiceMessage
    {
        private readonly IMessage _IMessage;

        public ServiceMessage(IMessage iMessage)
        {
            _IMessage = iMessage;
        }

        public async Task Adicionar(Message Objeto)
        {
            var validarTitulo = Objeto.ValidarPropriedadeStrig(Objeto.Titulo, "Titulo");
            if (validarTitulo)
            {
                Objeto.DataCadastro = DateTime.Now;
                Objeto.DataAlteracao = DateTime.Now;
                Objeto.Ativo = true;
                await _IMessage.Add(Objeto);
            }
        }

        public async Task Atualziar(Message Objeto)
        {
            var validarTitulo = Objeto.ValidarPropriedadeStrig(Objeto.Titulo, "Titulo");
            if (validarTitulo)
            {
                Objeto.DataAlteracao = DateTime.Now;
                await _IMessage.Update(Objeto);
            }
        }

        public async Task<List<Message>> ListarMensagensAtivas()
        {
            return await _IMessage.ListarMessage(n => n.Ativo);
        }
    }
}
