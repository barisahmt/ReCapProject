﻿using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccsess.Abstract;
using Entities.Concrete;

namespace Business.Concrate;

public class ColorManager : IColorService
{
    private readonly IColorDal _colorDal;

    public ColorManager(IColorDal colorDal)
    {
        _colorDal = colorDal;
    }

    public IResult Add(Color color)
    {
        if (color.ColorName.Length < 5) return new ErrorResult(Messages.InvalidColor);
        _colorDal.Add(color);
        return new Result(true, Messages.ColorAdded);
    }

    public IResult Delete(Color color)
    {
        _colorDal.Delete(color);
        return new Result(true, Messages.ColorDeleted);
    }

    public IDataResult<List<Color>> GetAll()
    {
        return new SuccessDataResult<List<Color>>(_colorDal.GetAll(), Messages.ColorListed);
    }

    public IDataResult<List<Color>> GetByColor(int colorId)
    {
        return new SuccessDataResult<List<Color>>(_colorDal.GetAll(co => co.Id == colorId));
    }

    public IDataResult<Color> GetById(int İd)
    {
        return new SuccessDataResult<Color>(_colorDal.Get());
    }

    public IResult Update(Color color)
    {
        if (color.ColorName.Length < 4) return new ErrorResult(Messages.InvalidColor);
        return new Result(true, Messages.ColorAdded);
    }
}