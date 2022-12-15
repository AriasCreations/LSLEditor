using LSLEditor.Solution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSLEditor.Images
{
    public static class ImagesHelper
    {
        public enum ImageType
        {
            Class,
            CloseActive,
            CloseDisabled,
            CloseInactive,
            Constants,
            Enum,
            Events,
            Functions,
            logo,
            Namespace,
            Properties,
            SealedClass,
            States,
            Unknown,
            Vars
        }
        public static Bitmap getImageByType(this ImageType type)
        {
            return (Bitmap)typeof(Images).GetProperty(type.ToString()).GetValue(new Images());
        }
    }
}
