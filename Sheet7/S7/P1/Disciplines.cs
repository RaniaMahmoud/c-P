using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1
{
    class Disciplines
    {
        private string nameCorse;
        private int numberCorse;
        private string numberOfExercises;

        public string NameCorse
        {
            get
            {
                return nameCorse;
            }

            set
            {
                nameCorse = value;
            }
        }

        public int NumberCorse
        {
            get
            {
                return numberCorse;
            }

            set
            {
                numberCorse = value;
            }
        }

        public string NumberOfExercises
        {
            get
            {
                return numberOfExercises;
            }

            set
            {
                numberOfExercises = value;
            }
        }

    }
}
