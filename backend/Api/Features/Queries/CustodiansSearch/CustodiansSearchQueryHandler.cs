using MediatR;

namespace Api.Features.Queries.GetAllProducts
{

    public record CustodiansSearchQuery(int limit, int offset, string searchText) : IRequest<CustodiansSearchQueryResponse>;

    public record CustodiansSearchQueryResponse(IEnumerable<CustodianQueryModel> custodians, int offset);

    public record Address(string addressLine1, string addressLine2, string postCode, string phoneNumber, string city, string state);

    public record CustodianQueryModel(Guid id, string name, Address address);

    public class CustodiansSearchQueryHandler : IRequestHandler<CustodiansSearchQuery, CustodiansSearchQueryResponse>
    {
        public CustodiansSearchQueryHandler() { }

        public Task<CustodiansSearchQueryResponse> Handle(CustodiansSearchQuery request, CancellationToken cancellationToken)
        {

            var custodians = new List<CustodianQueryModel>()
            {
                new CustodianQueryModel(Guid.NewGuid(), "Custodian Name", new Address("", "", "", "", "", ""))
            };

            return Task.FromResult(new CustodiansSearchQueryResponse(custodians, 0));
        }
    }
}
