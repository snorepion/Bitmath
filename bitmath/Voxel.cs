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
        public Voxel(double w, Switch s, int x, int y)
        {
            Weight = w;
            Value = s;
            Position = new Point(x, y);
        }
        public double Weight { get; set; }
        public Switch Value { get; set; }
        public Point Position { get; set; }
        public static Voxel[,] GenerateVoxels(int xs, int ys, Double[] weights, Double[,] extrWeights, WeightType[,] extrWeightsType, int ChoiceType, Switch Default=Switch.Indeterminate)
        {
            int x = 0;
            int y = 0;
            Voxel[,] section = new Voxel[xs, ys];
            CryptoRandomSource r = new CryptoRandomSource();
            int x2 = 0;
            int y2 = 0;
            int ind = 0;
            while (y2 < ys)
            {
                while (x2 < xs) {
                    section[x2, y2] = new Voxel(weights[ind], Switch.Indeterminate, x2, y2);
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
                            if (r.Next(-1, 0) == 0) d = 1;
                            else d = -1;
                        }
                        else {
                            d = (int)Default;
                        }
                    }
                    if (d < 0) section[x, y].Value = Switch.Off;
                    else section[x, y].Value = Switch.On;
                    ++x;
                }
                ++y;
                x = 0;
            }
            return section;
        }
        public static Bitmap RenderAll(Voxel[,] v, int xs, int ys, System.Drawing.Imaging.PixelFormat pf, Color[] colors)
        {
            Bitmap b = new Bitmap(xs, ys, pf);
            foreach (Voxel ve in v)
            {
                if (ve.Value == Switch.Off) b.SetPixel(ve.Position.X, ve.Position.Y, colors[0]);
                else b.SetPixel(ve.Position.X, ve.Position.Y, colors[1]);
            }
            return b;
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
                    v += (E[0,0] + (int)V[0].Value * V[0].Weight);
                    break;
                case (WeightType.Exp):
                    v += Math.Pow(((int)V[0].Value * V[0].Weight), E[0, 0]); // (V[0].Value * V[0].Weight) ^ E[0,0]
                    break;
                case (WeightType.Times):
                    v += E[0, 0] * ((int)V[0].Value * V[0].Weight);
                    break;
            }
            switch (w[0, 1])
            {
                case (WeightType.Add):
                    v += (E[0, 1] + (int)V[1].Value * V[1].Weight);
                    break;
                case (WeightType.Exp):
                    v += Math.Pow(((int)V[1].Value * V[1].Weight), E[0, 1]);
                    break;
                case (WeightType.Times):
                    v += E[0, 1] * ((int)V[1].Value * V[1].Weight);
                    break;
            }
            switch (w[0, 2])
            {
                case (WeightType.Add):
                    v += (E[0, 2] + (int)V[2].Value * V[2].Weight);
                    break;
                case (WeightType.Exp):
                    v += Math.Pow(((int)V[2].Value * V[2].Weight), E[0, 2]);
                    break;
                case (WeightType.Times):
                    v += E[0, 2] * ((int)V[2].Value * V[2].Weight);
                    break;
            }
            switch (w[1, 0])
            {
                case (WeightType.Add):
                    v += (E[1, 0] + (int)V[3].Value * V[3].Weight);
                    break;
                case (WeightType.Exp):
                    v += Math.Pow(((int)V[3].Value * V[3].Weight), E[1, 0]);
                    break;
                case (WeightType.Times):
                    v += E[1, 0] * ((int)V[3].Value * V[3].Weight);
                    break;
            }
            switch (w[1, 2])
            {
                case (WeightType.Add):
                    v += (E[1, 2] + (int)V[4].Value * V[4].Weight);
                    break;
                case (WeightType.Exp):
                    v += Math.Pow(((int)V[4].Value * V[4].Weight), E[1, 2]);
                    break;
                case (WeightType.Times):
                    v += E[1, 2] * ((int)V[4].Value * V[4].Weight);
                    break;
            }
            switch (w[2, 0])
            {
                case (WeightType.Add):
                    v += (E[2, 0] + (int)V[5].Value * V[5].Weight);
                    break;
                case (WeightType.Exp):
                    v += Math.Pow(((int)V[5].Value * V[5].Weight), E[2, 0]);
                    break;
                case (WeightType.Times):
                    v += E[2, 0] * ((int)V[5].Value * V[5].Weight);
                    break;
            }
            switch (w[2, 1])
            {
                case (WeightType.Add):
                    v += (E[2, 1] + (int)V[6].Value * V[6].Weight);
                    break;
                case (WeightType.Exp):
                    v += Math.Pow(((int)V[6].Value * V[6].Weight), E[2, 1]);
                    break;
                case (WeightType.Times):
                    v += E[2, 1] * ((int)V[6].Value * V[6].Weight);
                    break;
            }
            switch (w[2, 2])
            {
                case (WeightType.Add):
                    v += (E[2, 2] + (int)V[7].Value * V[7].Weight);
                    break;
                case (WeightType.Exp):
                    v += Math.Pow(((int)V[7].Value * V[7].Weight), E[2, 2]);
                    break;
                case (WeightType.Times):
                    v += E[2, 2] * ((int)V[7].Value * V[7].Weight);
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
    public enum Switch
    {
        On, Off, Indeterminate
    }
}
