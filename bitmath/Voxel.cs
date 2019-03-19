using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

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
        public static Voxel[,] GenerateVoxels(int xs, int ys, string FilePath, Double[] weights, Double[,] extrWeights, WeightType[,] extrWeightsType)
        {
            int x = 0;
            int y = 0;
            Voxel[,] section = new Voxel[xs, ys];
            Voxel TopLeft = new Voxel(0.0, 0.0, 0, 0);
            Voxel TopCenter = new Voxel(0.0, 0.0, 0, 0);
            Voxel TopRight = new Voxel(0.0, 0.0, 0, 0);
            Voxel CenterLeft = new Voxel(0.0, 0.0, 0, 0);
            Voxel CenterRight = new Voxel(0.0, 0.0, 0, 0);
            Voxel BottomLeft = new Voxel(0.0, 0.0, 0, 0);
            Voxel BottomCenter = new Voxel(0.0, 0.0, 0, 0);
            Voxel BottomRight = new Voxel(0.0, 0.0, 0, 0);
            while (y <= ys)
            {
                while (x <= xs)
                {
                    section[x, y].Weight = weights[x * y];
                    section[x, y].Position = new Point(x, y);
                    if (x > 0)
                    {
                        CenterLeft = section[x - 1, y];
                        if (y > 0) TopLeft = section[x - 1, y - 1];
                        if (y < ys) BottomLeft = section[x - 1, y + 1];
                    }
                    if (x < xs)
                    {
                        CenterRight = section[x + 1, y];
                        if (y > 0) TopRight = section[x + 1, y - 1];
                        if (y < ys) BottomRight = section[x + 1, y + 1];
                    }
                    if (y > 0) TopCenter = section[x, y - 1];
                    if (y < ys) BottomCenter = section[x, y + 1];
                    section[x, y].Value = CalculateValue(extrWeightsType, extrWeights, TopLeft, TopCenter, TopRight, CenterLeft, CenterRight, BottomLeft, BottomCenter, BottomRight);
                    x++;
                }
                y++;
            }
            return section;
        }
        public static Bitmap RenderAll(Voxel[,] v, int xs, int ys, System.Drawing.Imaging.PixelFormat pf, Dictionary<Double[],Color> Colormap)
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
                b.SetPixel(ve.Position.X, ve.Position.Y, Colormap.Values.ElementAt(i));
            }
            return b;
        }
        internal static bool IsBetween(double inp, double i, double ii)
        {
            if (inp > i & inp < ii) return true;
            else return false;
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
