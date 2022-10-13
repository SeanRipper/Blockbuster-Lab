using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blockbuster_Lab
{
    public class DVD : Movie
    {
        public DVD(string title, Genre category, int runTime, List<string> scenes) : base(title, category, runTime, scenes)
        {

        }



        public override void Play( int scene)
        {
            


        }
    } 
}
