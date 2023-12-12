using static Ukol_4b.Form1.BarvaRGB;

namespace Ukol_4b
{

    public partial class Form1 : Form
    {
        private SpravaBodu spravaBodu;

        /*Questions to 4b a)

1. Jak jsou definovány použité vlastnosti (accessors)?
   - In the `BarvaRGB` class, the RGB values (R, G, B) are defined 
        as properties with only a getter (`get`) but no setter (`set`). 
        This means that these properties can be read from outside the class but cannot be modified directly from external code.
        To set these values, you would need to use the constructor when creating an instance of the `BarvaRGB` class.

2. Jak je využito provolávání konstruktorů?
   - In the `BarvaRGB` class, there is a parameterized constructor that takes three arguments (`r`, `g`, `b`)
        to initialize the RGB values when an instance of the class is created. 
        This constructor is utilized to set the initial values of the RGB components when a `BarvaRGB` object is instantiated.

3. Jak je řešeno formátování hodnot složek v textovém popisu?
   - In the `ToString` method of the `BarvaRGB` class, the RGB values are formatted
        as hexadecimal values using the `X2` format specifier. 
        This ensures that each component is represented as a two-digit hexadecimal value,
        which is a common way to represent colors in hexadecimal format.
        For example, `[ff0a05]` represents the color with RGB values (255, 10, 5).
       */
        public class BarvaRGB
        {
            public class SpravaBodu
            {
                private List<BodZakladni> seznamBodu;

                public SpravaBodu()
                {
                    seznamBodu = new List<BodZakladni>();
                }

                public List<BodZakladni> SeznamBodu
                {
                    get { return seznamBodu; }
                }

                public void Add(BodZakladni bod)
                {
                    // Check if a point with the same coordinates already exists
                    if (SeznamBodu.Exists(existingBod => existingBod.Equals(bod)))
                    {
                        throw new DuplicitniBodException();
                    }

                    // If not, add the new point to the list
                    seznamBodu.Add(bod);
                }

                public void Remove(BodZakladni bod)
                {
                    // Remove the specified point from the list
                    seznamBodu.Remove(bod);
                }
            }

            public class DuplicitniBodException : Exception
            {
                public DuplicitniBodException()
                    : base("Bod s danými souřadnicemi již existuje.")
                {
                }
            }
            // Properties for the RGB values
            public byte R { get; }
            public byte G { get; }
            public byte B { get; }

            // Constructor to initialize the RGB values
            public BarvaRGB(byte r, byte g, byte b)
            {
                R = r;
                G = g;
                B = b;
            }

            // Calculate and return the intensity of the color
            public double Intenzita()
            {
                return (R + G + B) / 3.0;
            }

            // Override ToString method to display color values
            public override string ToString()
            {
                return $"[{R:X2}{G:X2}{B:X2}]";
            }
        }
        public class BodZakladni : IEquatable<BodZakladni>
        {
            public int X { get; private set; }
            public int Y { get; private set; }

            public BodZakladni(int x, int y)
            {
                X = x;
                Y = y;
            }

            public override string ToString()
            {
                return $"[{X};{Y}]";
            }

            public bool Equals(BodZakladni other)
            {
                if (other == null)
                    return false;

                return X == other.X && Y == other.Y;
            }

            public override bool Equals(object obj)
            {
                if (obj == null || GetType() != obj.GetType())
                    return false;

                return Equals(obj as BodZakladni);
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(X, Y);
            }
        }

        public class BodBarevny : BodZakladni, IEquatable<BodBarevny>
        {
            public BarvaRGB Barva { get; private set; }

            public BodBarevny(int x, int y, byte r, byte g, byte b) : base(x, y)
            {
                Barva = new BarvaRGB(r, g, b);
            }

            public BodBarevny(int x, int y, BarvaRGB barva) : base(x, y)
            {
                Barva = barva;
            }

            public override string ToString()
            {
                return $"{base.ToString()} - {Barva}";
            }

            public bool Equals(BodBarevny other)
            {
                if (other == null)
                    return false;

                return base.Equals(other) && Barva.Equals(other.Barva);
            }

            public override bool Equals(object obj)
            {
                if (obj == null || GetType() != obj.GetType())
                    return false;

                return Equals(obj as BodBarevny);
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(base.GetHashCode(), Barva);
            }
        }

        private void UpdatePointsListBox(List<BodZakladni> points)
        {
            // Clear the ListBox
            listBoxPoints.Items.Clear();

            // Add all the points to the ListBox
            foreach (var point in points)
            {
                listBoxPoints.Items.Add(point.ToString());
            }
        }





        public Form1()
        {
            spravaBodu = new SpravaBodu();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btnAddPoint_Click(object sender, EventArgs e)
        {
            // Retrieve X and Y coordinates from TextBox controls
            if (int.TryParse(txtX.Text, out int x) && int.TryParse(txtY.Text, out int y))
            {
                try
                {
                    // Create a new basic point
                    BodZakladni basicPoint = new BodZakladni(x, y);

                    // Add the point to the list
                    spravaBodu.Add(basicPoint);

                    // Optionally, clear the TextBox controls after adding the point
                    txtX.Clear();
                    txtY.Clear();

                    // Display the updated list of points in the ListBox
                    UpdatePointsListBox(spravaBodu.SeznamBodu);
                }
                catch (DuplicitniBodException ex)
                {
                  
                    MessageBox.Show($"Point with coordinates ({x}, {y}) already exists.");
                }
            }
            else
            {
               
                MessageBox.Show("Invalid input. Please enter valid coordinates.");
            }
        }

        private void btnSortPoints_Click(object sender, EventArgs e)
        {
            // Sort the points by the angle with the origin
            var sortedPoints = spravaBodu.SeznamBodu
                .OrderBy(bod => Math.Atan2(bod.Y, bod.X))
                .ToList();

            // Clear the ListBox and add the sorted points
            listBoxPoints.Items.Clear();
            foreach (var point in sortedPoints)
            {
                listBoxPoints.Items.Add(point.ToString());
            }
        }

        private void txtX_TextChanged(object sender, EventArgs e)
        {

        }
    }
}