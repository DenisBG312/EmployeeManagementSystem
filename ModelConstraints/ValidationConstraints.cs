namespace ModelConstraints
{
    public static class ValidationConstraints
    {
        //Employee
        public const byte EmployeeNameMinLength = 3;
        public const byte EmployeeNameMaxLength = 50;
        public const byte EmployeeEmailMinLength = 5;
        public const byte EmployeeEmailMaxLength = 100;
        public const string EmployeeEmailRegex = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";

        public const string EmployeePhoneRegex =
            @"^\+?(\d{1,4}[-.\s]?)?(\(?\d{1,5}\)?[-.\s]?)?(\d{1,4}[-.\s]?)?(\d{1,9})$";
    }
}
