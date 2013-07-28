﻿namespace Nancy.SimpleRpc
{
    using System.Threading;
    using System.Threading.Tasks;

    public interface IService<TRequest, TResponse>
        where TRequest: new()
        where TResponse: new()
    {
        Task<TResponse> Execute(TRequest request, CancellationToken cancellationToken);
    }
}