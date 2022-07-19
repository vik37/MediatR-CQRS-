﻿using DemoLibrary.DataAccess;
using DemoLibrary.Models;
using DemoLibrary.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemoLibrary.Hadlers
{
    public class GetPersonListHandler : IRequestHandler<GetPersoListQuiery, List<PersonModel>>
    {
        private readonly IDataAccess _data;
        public GetPersonListHandler(IDataAccess data)
        {
            _data = data;
        }
        public Task<List<PersonModel>> Handle(GetPersoListQuiery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.Get());
        }
    }
}
