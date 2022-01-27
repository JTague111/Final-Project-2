namespace Challenge_1_Take_2
{
    public class Menu
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Ingredients { get; set; }
        public int Price { get; set; }

        public Menu(int number, string name, string description, string ingredients, int price)
        {
            this.Number = number;
            this.Name = name;
            this.Description = description;
            this.Ingredients = ingredients;
            this.Price = price;
        }
        public Menu(){}
    }
}
