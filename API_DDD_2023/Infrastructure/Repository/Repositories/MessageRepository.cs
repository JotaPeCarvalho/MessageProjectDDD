using Domain;
using Entities.Entities;
using Infrastructure.Configuration;
using Infrastructure.Repository.Generics;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository.Repositories
{
    public class MessageRepository : RepositoryGeneric<Message>, IMessage
    {
        private readonly DbContextOptions<ContextBase> _OptionsBuilder;
        public MessageRepository()
        {
            _OptionsBuilder = new DbContextOptions<ContextBase>();
        }

        public async Task<List<Message>> ListarMessage(Expression<Func<Message, bool>> exMessage)
        {
            using(var banco = new ContextBase(_OptionsBuilder)) 
            {
                return await banco.Messages.Where(exMessage)
                                           .AsNoTracking()
                                           .ToListAsync();
            }
        }
    }
}
