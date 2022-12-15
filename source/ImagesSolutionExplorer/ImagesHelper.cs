using LSLEditor.Solution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSLEditor.ImagesSolutionExplorer
{
    public static class ImagesHelper
    {
        public static Bitmap getImageByType(this SolutionExplorer.TypeSL type)
        {
            return (Bitmap)typeof(SolutionImages).GetProperty(type.ToString()).GetValue(new SolutionImages());
        }
    }
}
