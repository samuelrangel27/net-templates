using System;
namespace netploy.Domain.Entitites;

public class TestEntity : BaseEntity<int>
{
    public string? Foo { get; set; }
    public int Bar { get; set; }
}

