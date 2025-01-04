using System;
using System.Net;

namespace netploy.Common.Results;

public class Result<T> where T : class
{
    public T? Data { get; set; }
    public string Message { get; set; }
    public HttpStatusCode State { get; set; }
    public IEnumerable<string>? Errors { get; set; } = new List<string> { };

    private Result(T? data, string message, HttpStatusCode state, IEnumerable<string>? errors = null)
    {
        this.Data = data;
        this.Message = message;
        this.State = state;
        if (errors != null)
            this.Errors = errors;
    }

    public static Result<T> Ok(string message)
    {
        return Ok(message, null);
    }

    public static Result<T> Ok(string message, T? data)
    {
        return new Result<T>(data, message, HttpStatusCode.OK);
    }

    public static Result<T> Fail(string message, HttpStatusCode state = HttpStatusCode.BadRequest)
    {
        return new Result<T>(null, message, state);
    }

    public static Result<T> Fail(string message, IEnumerable<string> errors, HttpStatusCode state = HttpStatusCode.BadRequest, T data = null)
    {
        var result = Fail(message, state);
        result.Errors = errors;
        result.Data = data;
        return result;
    }

}

