using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8.Task2
{
    public class ClientException : Exception
    {
        private string? _nation;
        private int _age;

        public ClientException(string nation): base($"Bad nation: {nation}")
        {
            this._nation = nation;
        }

        public ClientException(int age) : base($"You are very old: {age}")
        {
            this._age = age;
        }
    }
}
