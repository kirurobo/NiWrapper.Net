
namespace NiTEWrapper
{
    public struct Rect3D
    {
        public double X, Y, Z;
        public double SizeX, SizeY, SizeZ;

        public Rect3D(
                double x,
                double y,
                double z,
                double sizeX,
                double sizeY,
                double sizeZ
            )
        {
            X = x;
            Y = y;
            Z = z;
            SizeX = sizeX;
            SizeY = sizeY;
            SizeZ = sizeZ;
        }
    }
}
