namespace EncapsulationPatika;

public class Cars
{
    //Cars class and its Properties
    public Cars()
    {
        Console.WriteLine("You created a car.");
    }
    
    public string Brand { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }
    
    //Private field for encapsulation
    private int _doorCount;

    public int DoorCount
        {
            get
            {
                return _doorCount;
            }
            set
            {
                //Can be set only if 2 or 4
                if ((value == 2) || (value == 4))
                {
                    _doorCount = value;
                }
                else
                {
                    _doorCount = -1;
                    Console.WriteLine("Door count can be only 2 or 4.");
                }    
            }
        }
}

