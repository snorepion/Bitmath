using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics;
using MathNet.Numerics.Random;
using MathNet.Numerics.Statistics;

namespace bitmath
{
    public class Voxel
    {
        public Voxel(double w, double v, int x, int y)
        {
            Weight = w;
            Value = v;
            Position = new Point(x, y);
        }
        public double Weight { get; set; }
        public double Value { get; set; }
        public Point Position { get; set; }
        public static Voxel[,] GenerateVoxels(int xs, int ys, Double[] weights, Double[,] extrWeights, WeightType[,] extrWeightsType, int ChoiceType, double max, double min, double stdev, double[] vals = null, double Default=0.0)
        {
            int x = 0;
            int y = 0;
            Voxel[,] section = new Voxel[xs, ys];
            CryptoRandomSource r = new CryptoRandomSource();
            int x2 = 0;
            int y2 = 0;
            int i2 = 0;
            int ind = 0;
            double d2 = 0;
            while (y2 < ys)
            {
                while (x2 < xs) {
                    if (ChoiceType == 0)
                    {
                        i2 = r.Next(0, vals.Length);
                        d2 = Reduce(vals[i2], stdev);
                        if (d2 == 0) d2 = 1;
                    }
                    else d2 = Default;
                    section[x2, y2] = new Voxel(weights[ind], d2, x2, y2);
                    d2 = 0;
                    ++x2;
                    ++ind;
                }
                ++y2;
                x2 = 0;
            }
            Voxel TopLeft = new Voxel(0.0, 0.0, 0, 0);
            Voxel TopCenter = new Voxel(0.0, 0.0, 0, 0);
            Voxel TopRight = new Voxel(0.0, 0.0, 0, 0);
            Voxel CenterLeft = new Voxel(0.0, 0.0, 0, 0);
            Voxel CenterRight = new Voxel(0.0, 0.0, 0, 0);
            Voxel BottomLeft = new Voxel(0.0, 0.0, 0, 0);
            Voxel BottomCenter = new Voxel(0.0, 0.0, 0, 0);
            Voxel BottomRight = new Voxel(0.0, 0.0, 0, 0);
            double d = 0;
            int i = 0;
            while (y < ys)
            {
                while (x < xs)
                {
                    if (x > 0)
                    {
                        CenterLeft = section[x - 1, y];
                        if (y > 0) TopLeft = section[x - 1, y - 1];
                        if (y < ys - 1) BottomLeft = section[x - 1, y + 1];
                    }
                    if (x < xs - 1)
                    {
                        CenterRight = section[x + 1, y];
                        if (y > 0) TopRight = section[x + 1, y - 1];
                        if (y < ys - 1) BottomRight = section[x + 1, y + 1];
                    }
                    if (y > 0) TopCenter = section[x, y - 1];
                    if (y < ys - 1) BottomCenter = section[x, y + 1];
                    d = CalculateValue(extrWeightsType, extrWeights, TopLeft, TopCenter, TopRight, CenterLeft, CenterRight, BottomLeft, BottomCenter, BottomRight);
                    if (d == 0)
                    {
                        if (ChoiceType == 0)
                        {
                            i = r.Next(0, vals.Length);
                            d = Reduce(vals[i], stdev);
                            if (d == 0) d = 0.1;
                        }
                        else d = Default;
                    }
                    section[x, y].Value = Flatten(d, max, min);
                    ++x;
                }
                ++y;
                x = 0;
            }
            return section;
        }
        public static Bitmap RenderAll(Voxel[,] v, int xs, int ys, System.Drawing.Imaging.PixelFormat pf, Dictionary<Double[],Color[]> Colormap)
        {
            Bitmap b = new Bitmap(xs, ys, pf);
            bool f = false;
            int i = 0;
            foreach (Voxel ve in v)
            {
                while (f==false)
                {
                    f = IsBetween(ve.Value, Colormap.Keys.ElementAt(i)[0], Colormap.Keys.ElementAt(i)[1]);
                    i++;
                }
                b.SetPixel(ve.Position.X, ve.Position.Y, Colormap.Values.ElementAt(i-1)[0]);
            }
            return b;
        }
        internal static double Reduce(double a, double b)
        {
            if (a < 0) return a + b;
            else return a - b;
        }
        internal static double Flatten(double a, double b, double c)
        {
            if (a >= 0)
            {
                if (a > b) return b;
                else return a;
            }
            else
            {
                if (a < c) return c;
                else return a;
            }
        }
        internal static bool IsBetween(double inp, double i, double ii)
        {
            return inp != 0 && inp > i && inp < ii ? true : false;
        }
        internal static double CalculateValue(WeightType[,] w, Double[,] E, params Voxel[] V)
        {
            double v = 0.0;
            switch (w[0, 0])
            {
                case (WeightType.Add):
                    v += (E[0,0] + V[0].Value * V[0].Weight);
                    break;
                case (WeightType.Exp):
                    v += Math.Pow((V[0].Value * V[0].Weight), E[0, 0]); // (V[0].Value * V[0].Weight) ^ E[0,0]
                    break;
                case (WeightType.Times):
                    v += E[0, 0] * (V[0].Value * V[0].Weight);
                    break;
            }
            switch (w[0, 1])
            {
                case (WeightType.Add):
                    v += (E[0, 1] + V[1].Value * V[1].Weight);
                    break;
                case (WeightType.Exp):
                    v += Math.Pow((V[1].Value * V[1].Weight), E[0, 1]);
                    break;
                case (WeightType.Times):
                    v += E[0, 1] * (V[1].Value * V[1].Weight);
                    break;
            }
            switch (w[0, 2])
            {
                case (WeightType.Add):
                    v += (E[0, 2] + V[2].Value * V[2].Weight);
                    break;
                case (WeightType.Exp):
                    v += Math.Pow((V[2].Value * V[2].Weight), E[0, 2]);
                    break;
                case (WeightType.Times):
                    v += E[0, 2] * (V[2].Value * V[2].Weight);
                    break;
            }
            switch (w[1, 0])
            {
                case (WeightType.Add):
                    v += (E[1, 0] + V[3].Value * V[3].Weight);
                    break;
                case (WeightType.Exp):
                    v += Math.Pow((V[3].Value * V[3].Weight), E[1, 0]);
                    break;
                case (WeightType.Times):
                    v += E[1, 0] * (V[3].Value * V[3].Weight);
                    break;
            }
            switch (w[1, 2])
            {
                case (WeightType.Add):
                    v += (E[1, 2] + V[4].Value * V[4].Weight);
                    break;
                case (WeightType.Exp):
                    v += Math.Pow((V[4].Value * V[4].Weight), E[1, 2]);
                    break;
                case (WeightType.Times):
                    v += E[1, 2] * (V[4].Value * V[4].Weight);
                    break;
            }
            switch (w[2, 0])
            {
                case (WeightType.Add):
                    v += (E[2, 0] + V[5].Value * V[5].Weight);
                    break;
                case (WeightType.Exp):
                    v += Math.Pow((V[5].Value * V[5].Weight), E[2, 0]);
                    break;
                case (WeightType.Times):
                    v += E[2, 0] * (V[5].Value * V[5].Weight);
                    break;
            }
            switch (w[2, 1])
            {
                case (WeightType.Add):
                    v += (E[2, 1] + V[6].Value * V[6].Weight);
                    break;
                case (WeightType.Exp):
                    v += Math.Pow((V[6].Value * V[6].Weight), E[2, 1]);
                    break;
                case (WeightType.Times):
                    v += E[2, 1] * (V[6].Value * V[6].Weight);
                    break;
            }
            switch (w[2, 2])
            {
                case (WeightType.Add):
                    v += (E[2, 2] + V[7].Value * V[7].Weight);
                    break;
                case (WeightType.Exp):
                    v += Math.Pow((V[7].Value * V[7].Weight), E[2, 2]);
                    break;
                case (WeightType.Times):
                    v += E[2, 2] * (V[7].Value * V[7].Weight);
                    break;
            }
            return v;
        }
    }
    public enum VoxelDeterminerType
    {
        Gaussian, Poisson, CustomSet
    }
    public enum WeightType
    {
        Add, Exp, Times
    }
}
