using System;
using Entities.Concretes;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Dtos.Requests;
using Business.Dtos.Responses;

namespace Business.Abstracts;

public interface IBrandService
{
    CreateBrandRequest Add(CreateBrandRequest createBrandRequest);
    List<GetAllBrandResponse> GetAll();
}
