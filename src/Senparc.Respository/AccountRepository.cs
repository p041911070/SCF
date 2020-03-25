﻿using Senparc.Core.Models;
using Senparc.Scf.Core.Models;
using Senparc.Scf.Repository;

namespace Senparc.Repository
{
    public interface IAccountRepository : IClientRepositoryBase<Account>
    {
    }

    public class AccountRepository : ClientRepositoryBase<Account>, IAccountRepository
    {
        public AccountRepository(ISqlClientFinanceData sqlClientFinanceData) : base(sqlClientFinanceData)
        {

        }
    }
}

