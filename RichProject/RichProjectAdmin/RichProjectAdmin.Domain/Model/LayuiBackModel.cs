using System;
using System.Collections.Generic;
using System.Text;

namespace RichProjectAdmin.Domain.Model
{
    public class LayuiBackModel<T>
    {
        public int Code { get; set; }

        public string Msg => string.Empty;

        public int Count { get; set; }

        public T Data { get; set; }
    }
}
