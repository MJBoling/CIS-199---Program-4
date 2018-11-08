using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_4
{
    public class GroundPackage
    {
        // Backing fields
        private int _originZip;         // The package's origin Zip Code
        private int _destinationZip;    // The package's destination Zip Code
        private double _length;         // The package's length
        private double _width;          // The package's width
        private double _height;         // The package's height
        private double _weight;         // The package's weight

        // Constructor
        // Precondition: none
        // Postcondition: A package has been constructed
         public GroundPackage()
        {
        } 

        // Origin Zip property
        public int OriginZip
        {
            // Precondition: None
            // Postcondition: The origin zip has been returned
            get { return _originZip; }

            // Precondition: Zip is between 00000 and 99999
            // Postcondition: The zip code has been set to the specified value
            set
            {
                if (value >= 00000 && value <= 99999)
                    _originZip = value;
                else
                    _originZip = 40202;
            }
        }

        // Destination zip code property
        public int DestinationZip
        {
            // Precondition: None
            // Postcondition: The destination zip code is returned
            get { return _destinationZip; }

            // Precondition: value between 00000 and 99999
            // Postcondition: The zip code is set to the specified value
            set
            {
                if (value >= 00000 && value <= 99999)
                    _destinationZip = value;
                else
                    _destinationZip = 90210;
            }
         }

        // Length property
        public double Length
        {
            // Precondition: None
            // Postcondition: The length is returned
            get { return _length; }

            // Precondition: value > 0
            // Postcondition: The length is set to the specified value
            set
            {
                if (value > 0)
                    _length = value;
                else
                    _length = 1.0;
            }
        }

        // Width Property
        public double Width
        {
            // Precondition: None
            // Postcondition: The width is returned
            get { return _width; }

            // Precondition: Value > 0 
            // Postcondition: The width is set to the specified value
            set
            {
                if (value > 0)
                    _width = value;
                else
                    _width = 1.0;
            }
        }

        // Height Property
        public double Height
        {
            // Precondition: None
            // Postcondition: The height is returned
            get { return _height; }

            // Precondition: Value > 0
            // Postcondition: The height is set to the specified value
            set
            {
                if (value > 0)
                    _height = value;
                else
                    _height = 1.0;
            }
        }

        // Weight Property
        public double Weight
        {
            // Precondition: None
            // Postcondition: The weight is returned
            get { return _weight; }
            
            // Precondition: Weight > 0 
            // Postcondition: The weight is set to the specified value
            set
            {
                if (value > 0)
                    _weight = value;
                else
                    _weight = 1.0;
            }
        }

        // ZoneDistance property
        public int ZoneDistance
        {
            get { if (OriginZip >= DestinationZip)
                    return (OriginZip / 10000) - (DestinationZip / 10000);
                  else
                    return (DestinationZip / 10000) - (OriginZip / 10000);
        }
                    
        }

        // CalcCost property
        public double CalcCost()
        {
            double cost = .20 * (Length + Width + Height) + .5*(ZoneDistance + 1)*(Weight);
            return cost;
        }

        // Precondition: None
        // Postcondition: Will display the details of the package in a string format.
        public override string ToString()
        {
            return "Origin Zip Code: " + OriginZip + System.Environment.NewLine + "Destination Zip Code: " +
                DestinationZip + System.Environment.NewLine + "Length: " + Length + System.Environment.NewLine + 
                "Width: " + Width + System.Environment.NewLine + "Height: " + Height +
                System.Environment.NewLine + "Weight: " + Weight;

        }





    }
}
