namespace FrameSample.Data
{
    internal class Author : Entity
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string FullName { get => $"{FirstName} {LastName}"; }
    }
}
