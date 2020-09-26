namespace CH13_Exceptions_Demo
{
    public class CannotBeZeroException : System.ArgumentOutOfRangeException
    {
        public CannotBeZeroException(string parameter): base(parameter, "value cannot be 0")
        {
            // empty
        }
    }
}
