using System;

namespace TextFileTalabucon
{
 
    public class EmptyFileException : Exception
    {
        public EmptyFileException()
            : base("The selected file is empty.")
        {
        }

        public EmptyFileException(string message)
            : base(message)
        {
        }

        public EmptyFileException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
