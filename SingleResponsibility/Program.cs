namespace SingleResponsibility;

// Good Example

public class MailAddressValidation
{
    public bool IsMailAddressValid(string mail)
    {
        return true;
    }
}



public class SendEmail
{
    private MailAddressValidation _validation = new();
    public bool Send(string mail, string message)
    {
        if (!_validation.IsMailAddressValid(mail))
        {
            return false;
        }

        // Send mail
        return true;
    }
}