using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Model
{
    public class Result
    {
        public bool Success { get; set; }
        public string Json { get; set; }
        public string Message { get; set; }
        public List<Error> Errors { get; set; }
    }
}
