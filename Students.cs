namespace C_sharp_memory_array_lists
{
    public class Students
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public Students(string nome, string email)
        {
            Name = nome;
            Email = email;
        }

        public override string ToString()
        {
            return Name + ", " + Email;
        }
    }
}