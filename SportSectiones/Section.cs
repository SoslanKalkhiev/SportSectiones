using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportSectiones
{
   
    
    internal class Section
    {
         public List<string> Students { get; set; }
        public string Name { get; set; }
        public string Coach { get; set; }
        public int MaxStudents { get; set; }
        public Section(string name, string coach, int maxStudents)
        {
            Students = new List<string>();
            Name = name;
            Coach = coach;
            MaxStudents = maxStudents;
           
        }
        public int FreeSpots
        {
            get { return MaxStudents - Students.Count; }
        }
        
    }
}
