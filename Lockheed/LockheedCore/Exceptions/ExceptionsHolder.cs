namespace LockHeedCore.Exceptions
{
    using System;
    static class ExceptionsHolder
    {
        public static void CheckNullableString(string value, string message)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException(message);
            }
        }
    }
}
