using DemoLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Queries
{
    public record GetPersoListQuiery() :  IRequest<List<PersonModel>>;

    //public class GetPersonQueryClass : IRequest<List<PersonModel>>
    //{

    //}
    
}
