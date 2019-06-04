﻿using System;
using System.Collections.Generic;
using EvenCart.Core.Services;
using EvenCart.Data.Entity.Addresses;
using EvenCart.Data.Extensions;

namespace EvenCart.Services.Addresses
{
    public class CountryService : FoundationEntityService<Country>, ICountryService
    {
        public IEnumerable<Country> GetCountries(out int totalResults, string search = null, int page = 1, int count = Int32.MaxValue)
        {
            var query = Repository;
            if (!search.IsNullEmptyOrWhiteSpace())
                query = query.Where(x => x.Name.Contains(search));
            query = query.OrderBy(x => x.Name);
            return query.SelectWithTotalMatches(out totalResults, page, count);
        }
    }
}