using Business.DTOs;
using Music_Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IGuitarService
    {
        IEnumerable<GuitarDTO> ShowAll();
        void Add(GuitarDTO guitar);
        void Edit(GuitarDTO guitar);
        void Delete(int id);

    }
}
