namespace BlazorApp1.Data.Models
{
    public partial class NewHire
    {
        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }
    }
}
