using Core.Utilities.Results;
using Etities.Concrate;

namespace Business.Abstract;

public interface IRentalService
{
    IResult Rental(Rental rental);
    IResult Return(Rental rental);
    IResult Delivery(Rental rental);

    //IDataResult<List<Rental>> RentalList( );
}