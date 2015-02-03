using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessObjects;

namespace DAL
{
    public interface IReadable
    {
        List<PersonBO> Read();
    }
}
