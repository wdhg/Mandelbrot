using System;
using System.Drawing;
using System.Windows.Forms;

namespace Mandelbrot {
    public partial class Form1 : Form {

        private const int FractalSize = 4; // Graph units, from negative to position (-2 to 2)
        private const int ImageSize = 800; // Pixels
        private const float HalfImageSize = ImageSize / 2; // For quick and easy centring
        private const float ImageFractalRatio = (float) FractalSize / ImageSize; // How big each pixel is on the graph
        private const int Limit = 2; // Used for checking if the value is in the sequence
        private const int Iterations = 20; // The larger the value, the more accurate
        private const float XShift = -1; // To shift the graph over to the right so it's centred

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            Bitmap fractalImage = new Bitmap(ImageSize, ImageSize);

            for (int x = 0; x < ImageSize; x++) {
                for (int y = 0; y < ImageSize; y++) {
                    if (InMandelbrot(new Complex((x - HalfImageSize) * ImageFractalRatio + XShift, (y - HalfImageSize) * ImageFractalRatio), Iterations)) {
                        fractalImage.SetPixel(x, y, Color.Black);
                    } else {
                        fractalImage.SetPixel(x, y, Color.White);
                    }
                }
            }

            Output.Image = fractalImage;
        }

        // Zn+1 = Zn ^ 2 + C
        private bool InMandelbrot(Complex C, int iterations) {
            Complex Z = new Complex();

            for (int i = 0; i < iterations; i++) {
                if (Z.Abs() > 2) {
                    return false;
                } else {
                    Z = Z * Z + C;
                }
            }

            return true;
        }
    }

    class Complex {
        public float x, y;

        public Complex(float x, float y) {
            this.x = x;
            this.y = y;
        }

        public Complex() {
            this.x = 0;
            this.y = 0;
        }

        public override string ToString() {
            return string.Format("({0} + {1}i)", this.x, this.y);
        }

        public double Abs() {
            return Math.Sqrt(
                Math.Pow(this.x, 2) +
                Math.Pow(this.y, 2)
            );
        }

        public static Complex operator +(Complex a, Complex b) {
            return new Complex(a.x + b.x, a.y + b.y);
        }

        public static Complex operator *(Complex a, Complex b) {
            return new Complex(
                a.x * b.x + (a.y * b.y * -1), // Because i^2 is -1
                (a.x * b.y) + (a.y * b.x)
            );
        }
    }
}
