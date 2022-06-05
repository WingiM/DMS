using DMS.Core;
using Microsoft.EntityFrameworkCore;
using Npgsql;

namespace DMS.Data;

public class EfDataContext : IDataContext
{
    private readonly ApplicationContext _context;

    public EfDataContext(ApplicationContext context)
    {
        _context = context;
    }

    public int SaveChanges()
    {
        return _context.SaveChanges();
    }
}