namespace CustomValidator
{
    public class MyValidator
    {

        public bool IsValidUsername(string name)
        {
            return name.Length >= 8;
        }
    }
}