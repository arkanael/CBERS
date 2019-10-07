using CBERS.Domain.Shared.Entities;
using FluentValidator;
using System;

namespace CBERS.Domain.Entities
{
    public class Customer : Entity
    {
        public Customer(string firstName, string lastName, DateTime birthDate, string password, string email, User user)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            Active = false;
            Email = email;
            User = user;

            new ValidationContract<Customer>(this)
                .IsRequired(x => x.FirstName, "O nome é obrigatorio.")
                .HasMaxLenght(x => x.FirstName,60, "O nome não pode ter mais que 60 caracteres.") 
                .HasMinLenght(x => x.FirstName, 3, "O nome não pode ter menos que 3 caracteres.")

                .IsRequired(x => x.LastName, "O sobrenome é obrigatorio.")
                .HasMaxLenght(x => x.FirstName, 60, "O sobrenome não pode ter mais que 60 caracteres.")
                .HasMinLenght(x => x.FirstName, 3, "O sobrenome não pode ter menos que 3 caracteres.");

        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public DateTime BirthDate { get; private set; }
        public bool Active { get; private set; }
        public string Password { get; private set; }
        public string Email { get; private set; }
        public User User { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
