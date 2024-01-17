using NoorasKalender.Common.Classes;
using NoorasKalender.Data.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoorasKalender.Logic.Classes;

public class BusinessLogic
{
    private readonly IData _db;

    public BusinessLogic(IData data)
    {
        _db = data;
    }

    public IEnumerable<Day> GetDays() => _db.GetDays();
}

