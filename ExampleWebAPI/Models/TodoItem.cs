namespace ExampleWebAPI.Models
{
    public class TodoItem
    {
        // The Id property functions as the unique key in a relational database.
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }

        // Data Transfer Object (DTO), prevent over-posting.
        // Demonstrate the DTO approach by include a secret field.
        public string Secret { get; set; }
    }
}