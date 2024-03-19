using BusinessObjects.Models;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class MovieTicketRepository : IMovieTicketRepository
    {
        public List<MovieTicket> getAll() => MovieTicketDAO.getAll();
        public void addTicket(MovieTicket ticket) => MovieTicketDAO.addTicket(ticket);
        public int countID() => MovieTicketDAO.countID();
        public List<MovieTicket> getAllWithID(int MemAccId) => MovieTicketDAO.getAllWithID(MemAccId);
    }
}
