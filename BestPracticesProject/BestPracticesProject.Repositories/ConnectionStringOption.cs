using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestPracticesProject.Repositories
{
    public class ConnectionStringOption
    {
        public const string Key = "ConnectionStrings";
        public string SqlConnection { get; set; } = default!;
    }
}
