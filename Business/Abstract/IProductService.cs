﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.DTOs;

namespace Business.Abstract
{
    public   interface IProductService
    {
        IDataResult<List<Product>> GetAll();
        IDataResult<List<Product>>GetAllByCategoryId(int id);
        IDataResult<List<Product>>GetByUnitPrice(decimal min, decimal max);

        IDataResult<Product> GetById(int productId);

        IDataResult<List<ProductDetailDto>> GetProductDetail();

        IResult Add(Product product);
    }
}
