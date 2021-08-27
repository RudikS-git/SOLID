namespace SOLID._4._The_interface_Segregation_Principle.Good_implementation
{
    interface IMailSender : ITextSender
    {
        public string Subject { get; set; }
    }
}
