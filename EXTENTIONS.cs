namespace File_Transfer
{
    public static class EXTENTIONS
    {
        public static List<T> AsList<T>(this IEnumerable<T> source) =>
                 (source is null or List<T>) ? (List<T>)source : source.ToList();
    }
}
