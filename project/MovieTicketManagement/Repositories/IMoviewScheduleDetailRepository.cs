using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IMoviewScheduleDetailRepository
    {
        List<MoviewScheduleDetail> getAll();
        int countID();
        void addNew(MoviewScheduleDetail detail);   
        void updateEmptySlot(int id, string emptySlot);
    }
}
