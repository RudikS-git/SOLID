namespace SOLID._4._The_interface_Segregation_Principle.Good_implementation
{
    public interface ITextSender : ISender
    {
        public string Text { get; set; }
    }
}
