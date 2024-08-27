using System;
using System.ComponentModel.DataAnnotations;

namespace netploy.Domain.Entitites;

public abstract class BaseEntity<TKey>
{
    [Key]
    public virtual TKey Id { get; set; }
}

