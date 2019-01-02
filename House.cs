using System;

namespace homework3
{
    public class House
    {
        //the followings are fields.
        string _foundation;
        string _window;
        string _Roof;
        string _door;

        //standard long way of property.
        public string foundation
        {
            get
            {
                return _foundation;
            }
            set
            {
                this._foundation = value;
            }
        }
        public string window
        {
            get
            {
                return _window;
            }
            set
            {
                this._window = value;
            }
        }
        //short handed property + field; Auto property
        public string Roof { get; set; }

        public string PaintDoor { get; set; }
        //the followings are methods.
        public void OpenDoor()
        {
            Console.WriteLine("the door opens");
        }
        public void CloseDoor()
        {
            Console.WriteLine("the door closes");
        }























    }
}