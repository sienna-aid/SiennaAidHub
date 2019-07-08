using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiennaAidHub.Models
{
    public class SiennaDatabaseSettings : ISiennaDatabaseSettings
    {
	public string SiennaCollectionName { get; set; }
	public string ConnectionString { get; set; }
	public string DatabaseName { get; set; }
    }
}
