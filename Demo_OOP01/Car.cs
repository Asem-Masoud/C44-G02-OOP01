using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OOP01
{
    internal class Car
    {
        // Properties

        // Full Property // propfull + tab
        #region Attributes

        private int id;
        private int speed;
        private string model;

        #endregion

        #region Property

        public string Model
        {
            get { return model; }
            set { model = value; }
        }



        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }



        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        #endregion


        // CLR Will Generate Parameterless Constructor
        // This Constructor Do Nothing


        //public string Address { get; set; }// prop

        // CTOR
        //public Car()
        //{

        //}// Do Nothing

        //public Car()
        //{
        //    Id = default;
        //    Model = default;
        //    Speed = default;
        //}



        // internal chinning 
        public Car(int id, string model, int speed) : this(id, model)
        {
            //Id = id;
            //Model = model;
            Speed = speed;
        }

        public Car(int id, string model) : this(id)
        {
            //Id = id;
            Model = model;
        }

        public Car(int id)
        {
            Id = id;
        }

        public override string ToString()
        {
            return $"Car ID: {Id}, Model: {Model}, Speed: {Speed} km/h";
        }



    }
}
