using MediatR;

namespace Api.Features.Queries.GetAllProducts
{

    public record GetAllProductsQuery(int limit, int offset, GetAllProductsQueryFilter filter) : IRequest<GetAllProductsQueryResponse>;

    public record GetAllProductsQueryFilter(Guid? categoryId, string searchText);

    public record GetAllProductsQueryResponse(Guid id, string name, string description, Uri imageUri);

    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, GetAllProductsQueryResponse>
    {
        public GetAllProductsQueryHandler() { }

        public Task<GetAllProductsQueryResponse> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
