namespace WebAPI.DataAccess;

public class DataRepository
{
    private DatabaseContext _context;

    public DataRepository(DatabaseContext context)
    {
        _context = context;
    }
    
}