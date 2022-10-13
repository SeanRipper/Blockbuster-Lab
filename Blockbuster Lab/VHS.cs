using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blockbuster_Lab
{
    public class VHS : Movie
    {
        public VHS(string title, Genre category, int runTime, List<string> scenes) : base(title, category, runTime, scenes)
        {

        }

        public int CurrentScene { get; set; } = 0;

        public override void Play(int scene)
        {
            //Console.WriteLine(scenes[CurrentScene]);
            CurrentScene++;
        }
        public static void Rewind(List<string> scenes)
        {

        }
    }
}
