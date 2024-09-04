namespace TestGenericClass
{
    public class GenericClass<T> where T:struct
    {
        private readonly ICollection<T> _collection;
        public GenericClass()
        {
            _collection = new List<T>();
        }
        public void Add(T item)
        {
            _collection.Add(item);
        }
        public T GetItem(int index)
        {
            var list = _collection.ToList();
            return list[index];
        }

        public List<T> SortDescending()
        {
            var list = _collection.ToList();
            return list.OrderByDescending(w => w).ToList();
        }
    }
}
