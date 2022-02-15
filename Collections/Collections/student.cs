namespace Collections
{
    internal class student:object
    {
        public int Id { get; set; } 
        public string Name { get; set; }

        public override string ToString()
        {
            return $"student Id: {Id} student Name: {Name}";
        }
        
    }
}