using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Starcounter;

namespace Ammad1
{
    [Database]
    public class Corporation
    {
        int id;
        string name;
        DateTime creationDate;

        public int Id { get => id; set => id = value; }

        public string Name { get => name; set => name = value; }
        public DateTime CreationDate { get => creationDate; set => creationDate = value; }


        //List<Franchise> Flist;
    }
}
