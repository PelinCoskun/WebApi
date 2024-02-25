using Business.Abstracts;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using DataAccess.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes;

public class BrandManager : IBrandService
{
    IBrandDal _brandDal;

    public BrandManager(IBrandDal brandDal)
    {
        _brandDal = brandDal;
    }

    public CreateBrandRequest Add(CreateBrandRequest createBrandRequest)
    {
        throw new NotImplementedException();
    }

    public List<GetAllBrandResponse> GetAll()
    {
        throw new NotImplementedException();
    }
}
