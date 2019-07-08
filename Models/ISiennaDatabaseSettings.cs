using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiennaAidHub.Models
{
    public interface ISiennaDatabaseSettings
    {
	string SiennaCollectionName { get; set; }
	string ConnectionString { get; set; }
	string DatabaseName { get; set; }
    }
}
