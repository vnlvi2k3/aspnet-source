using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MyCompanyName.AbpZeroTemplate.EntityFrameworkCore
{
	public class CompanyDbContext : AbpDbContext
	{
		public CompanyDbContext(DbContextOptions<CompanyDbContext> options)
			: base(options)
		{
		}
	}
}