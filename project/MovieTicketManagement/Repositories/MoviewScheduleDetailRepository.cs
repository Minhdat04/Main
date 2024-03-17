using BusinessObjects.Models;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class MoviewScheduleDetailRepository : IMoviewScheduleDetailRepository
    {
        public List<MoviewScheduleDetail> getAll() => MoviewScheduleDetailDAO.getAll();
        public int countID() => MoviewScheduleDetailDAO.countID();
        public void addNew(MoviewScheduleDetail detail) => MoviewScheduleDetailDAO.AddScheduleDetail(detail);
        public void updateEmptySlot(int id, string emptySlot) => MoviewScheduleDetailDAO.updateEmptySlot(id, emptySlot);

    }
}
