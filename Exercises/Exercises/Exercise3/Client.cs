using System;

namespace Exercises.Exercise3
{
    public sealed class Client
    {
        public Client(ClientType clientType, string surname, string name, Guid id)
        {
            ClientType = clientType;
            Surname = surname;
            Name = name;
            Id = id;
        }

        public Guid Id { get; }

        public ClientType ClientType { get; }

        public string Surname { get; }

        public string Name { get; }
    }
}