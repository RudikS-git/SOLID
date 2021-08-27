namespace SOLID._4._The_interface_Segregation_Principle.Bad_implementation
{
    public interface ISender
    {
        public string Text { get; set; }
        public string Subject { get; set; }
        public void Send();
        string ToAddress { get; set; }
        string FromAddress { get; set; }
    }
}
