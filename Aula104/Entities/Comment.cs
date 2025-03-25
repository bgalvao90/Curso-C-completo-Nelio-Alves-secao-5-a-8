using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula104.Entities
{
    class Comment
    {
        public Comment()
        {
        }

        public string Text { get; set; }

        public Comment(string text)
        {
            this.Text = text;
        }
    }
}
