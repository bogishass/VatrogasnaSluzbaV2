using VatrogasnaSluzba;

public static class SessionHelper
{
    public static void WithSession(Action<ISession> work)
    {
        using var s = DataLayer.GetSession();
        using var tx = s.BeginTransaction();
        try
        {
            work(s);
            tx.Commit();        // Commit triggers flush in FlushMode.Auto
        }
        catch
        {
            if (tx.IsActive) tx.Rollback();
            throw;
        }
        // using{} disposes/close session automatically
    }

    public static T WithSession<T>(Func<ISession, T> work)
    {
        using var s = DataLayer.GetSession();
        using var tx = s.BeginTransaction();
        try
        {
            var result = work(s);
            tx.Commit();
            return result;
        }
        catch
        {
            if (tx.IsActive) tx.Rollback();
            throw;
        }
    }

    public static async Task WithSessionAsync(Func<ISession, Task> work)
    {
        using var s = DataLayer.GetSession();
        using var tx = s.BeginTransaction();
        try
        {
            await work(s);
            await tx.CommitAsync();
        }
        catch
        {
            if (tx.IsActive) await tx.RollbackAsync();
            throw;
        }
    }
}
