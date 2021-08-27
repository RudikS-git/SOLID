namespace SOLID._4._The_interface_Segregation_Principle.Good_implementation
{
    public interface ISender
    {
        string ToAddress { get; set; }
        string FromAddress { get; set; }
        public void Send();
    }
}
