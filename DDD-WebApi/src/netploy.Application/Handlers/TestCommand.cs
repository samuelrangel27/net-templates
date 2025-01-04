using System;
using AutoMapper;
using MediatR;
using netploy.Common.Models.Inputs;
using netploy.Common.Results;
using netploy.Domain.Entitites;
using netploy.Domain.Services.Interfaces;

namespace netploy.Application.Handlers;

public class TestCommand : TestActionInput, IRequest<Result<TestEntity>>
{
}
public class TestCommandHandler
    : IRequestHandler<TestCommand, Result<TestEntity>>
{
    private readonly ITestService _testService;
    private readonly IMapper _mapper;

    public TestCommandHandler(ITestService testService,
        IMapper mapper)
    {
        this._testService = testService;
        this._mapper = mapper;
    }

    public async Task<Result<TestEntity>> Handle(TestCommand request, CancellationToken cancellationToken)
    {
        var obj = _mapper.Map<TestEntity>(request);
        await _testService.DoSomething(obj);
        return Result<TestEntity>.Ok("Test success");
    }
}