using System;

namespace Afluex.Areas.HelpPage
{
    /// <summary>
    /// This represents an image sample on the help page. There's a display template named ~/css/imagesample associated with this class.
    /// </summary>
    public class sample
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="~/css/imagesample"/> class.
        /// </summary>
        /// <param name="src">The URL of an image.</param>
        public sample(string src)
        {
            if (src == null)
            {
                throw new ArgumentNullException("src");
            }
            Src = src;
        }

        public string Src { get; private set; }

        public override bool Equals(object obj)
        {
           sample other = obj as sample;
            return other != null && Src == other.Src;
        }

        public override int GetHashCode()
        {
            return Src.GetHashCode();
        }

        public override string ToString()
        {
            return Src;
        }
    }
}