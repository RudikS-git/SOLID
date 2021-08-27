namespace SOLID._3._The_Liskov_Substitution_Principle.Bad_implementation
{
    public abstract class Document
    {
        public abstract void EditDocument(string nextText);
        public abstract void ShowDocument();
    }
}
