using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bobakk_Doga_20241126
{
    internal class varos
    {
        public string varosNeve { get; set; }
        public string orszagNeve { get; set; }
        public double nepsegMillioFoben { get; set; }


        public override string ToString()
        {
            return $"{varosNeve} {orszagNeve} {Math.Round(nepsegMillioFoben,2)}";
        }

        public varos(string x)
        {
            string[] sor = x.Split(';');
            varosNeve = sor[0];
            orszagNeve = sor[1];
            nepsegMillioFoben = double.Parse(sor[2]);

        }

    }
}
