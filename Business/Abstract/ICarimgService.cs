﻿using Core.Utilities.Results;
using Etities.Concrate;
using Microsoft.AspNetCore.Http;

namespace Business.Abstract;

public interface ICarimgService
{
    IResult Add(IFormFile formFile, Carimg carimg);
    IResult Update(IFormFile formFile, Carimg carimg);
    IResult Delete(Carimg carimg);
    IDataResult<List<Carimg>> GetAll();
    IDataResult<List<Carimg>> GetByCarId(int carId);
    IDataResult<Carimg> GetByImgId(int imgId);
}