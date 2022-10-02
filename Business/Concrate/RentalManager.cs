﻿using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccsess.Abstract;
using Etities.Concrate;

namespace Business.Concrate;

public class RentalManager : IRentalService
{
    private IRentalDal _rentalDal;

    public RentalManager(IRentalDal rentalDal)
    {
        _rentalDal = rentalDal;
    }

    public IResult Delivery(Rental rental)
    {
        if (DateTime.Now.Hour >= 15 && DateTime.Now.Hour <= 7)
            return new ErrorResult(Messages.InvalidDalivaryTime);
        return new SuccessResult(Messages.Delivery);
    }

    public IResult Rental(Rental rental)
    {
        if (rental.CustomerAge < 19)
            return new ErrorResult(Messages.AgeInvalid);
        if (rental.CustomerMoney < rental.CarPrice) return new ErrorResult(Messages.Insufficient);
        return new Result(true, Messages.Rental);
    }


    public IResult Return(Rental rental)
    {
        if (rental.RentalHour >= 24) return new ErrorResult(Messages.BigRental);
        return new Result(true, Messages.Return);
    }
}