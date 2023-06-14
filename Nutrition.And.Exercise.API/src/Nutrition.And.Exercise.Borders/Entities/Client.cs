﻿using Nutrition.And.Exercise.Borders.DomainObjects;
using Nutrition.And.Exercise.Borders.Interfaces.Data;

namespace Nutrition.And.Exercise.Borders.Entities
{
    public class Client : Entity, IAggregateRoot
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }

        public Client()
        {
        }

        public Client( Guid id, string nome, DateTime dataNascimento)
        {
            Id = id;
            Nome = nome;
            DataNascimento = dataNascimento;
        }
    }
}
