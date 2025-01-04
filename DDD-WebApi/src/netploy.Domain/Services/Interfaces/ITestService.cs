using System;
using netploy.Domain.Entitites;

namespace netploy.Domain.Services.Interfaces;

public interface ITestService
{
    Task DoSomething(TestEntity entity);
}

