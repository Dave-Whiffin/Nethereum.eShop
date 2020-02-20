﻿using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace Nethereum.eShop.WebJobs.Jobs
{
    public interface IProcessEventLogs
    {
        Task ExecuteAsync(ILogger logger);
    }


}
