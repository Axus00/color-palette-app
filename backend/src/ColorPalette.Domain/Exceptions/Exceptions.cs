namespace ColorPalette.Domain.Exceptions;

public class Exceptions
{
    //Exceptions
    public class CreateInternalServerError : Exception
    {
        public CreateInternalServerError(string message) : base(message){}
        public CreateInternalServerError(Exception inner) : base(inner.Message){}
    }
}