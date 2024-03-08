namespace FrameSample.Data
{
    internal abstract class Entity
    {
        //[Key, StringLength(32)]
        public string? ID { get; set; }
        public void GenID()
        {
            ID = Guid.NewGuid().ToString("N"); //32
        }
    }
}
