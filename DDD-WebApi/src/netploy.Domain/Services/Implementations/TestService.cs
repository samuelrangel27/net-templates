using System;
using netploy.Domain.Entitites;
using netploy.Domain.Services.Interfaces;

namespace netploy.Domain.Services.Implementations;

public class TestService : ITestService
{
    public Task DoSomething(TestEntity entity)
    {
        Thread.Sleep(100);
        return Task.CompletedTask;
    }
}

