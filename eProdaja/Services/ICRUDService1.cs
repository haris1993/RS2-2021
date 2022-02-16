namespace eProdaja.Services
{
    internal interface ICRUDService<T, TSearch, TDb, TInsert, TUpdate>
        where T : class
        where TSearch : class
        where TDb : class
        where TInsert : class
        where TUpdate : class
    {
    }
}