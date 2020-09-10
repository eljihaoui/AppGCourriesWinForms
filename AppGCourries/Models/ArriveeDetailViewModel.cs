using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGCourries.Models
{
    public class ArriveeDetailViewModel
    {
        public int idArrivee { get; set; }
        public int idArriveeDocs { get; set; }
        public string typeDoc { get; set; }
        public string filename { get; set; }
        public string sizeFile { get; set;  }
    }
}
