using System;
using System.ComponentModel.DataAnnotations;

namespace pdouelle.Entity
{
    public class Entity : IEntity
    {
        [Key] public Guid Id { get; set; }
    }
}