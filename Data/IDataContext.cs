using Microsoft.EntityFrameworkCore;

namespace PracticaParcial2.Data
{
    public interface IDataContext
    {
        DbContext DbContext { get; }
    }
}
