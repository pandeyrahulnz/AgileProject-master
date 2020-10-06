using SQLite;

namespace AgileProject
{
    public class Ingredients
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public string RecipeName { get; set; }
        public string imageurl { get; set; }
        public string ingredients { get; set; }
        public string Recipeurl { get; set; }
    }
}
