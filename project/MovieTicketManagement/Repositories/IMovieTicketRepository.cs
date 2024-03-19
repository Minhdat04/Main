using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IMovieTicketRepository
    {
        List<MovieTicket> getAll();
        void addTicket (MovieTicket ticket);
        int countID();
        List<MovieTicket> getAllWithID(int MemAccId);
    }
}
