namespace aula21.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base (message) {
            
        }
    }
}