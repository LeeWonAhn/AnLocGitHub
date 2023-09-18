public class Point3D : Point2D
{
    private float z;

    public Point3D(float x, float y, float z)
    {
        SetXY(x, y);
        this.z = z;
    }

    public Point3D()
    {
        z = 0.0f;
    }

    public float GetZ()
    {
        return z;
    }

    public void SetZ(float z)
    {
        this.z = z;
    }

    public void SetXYZ(float x, float y, float z)
    {
        SetXY(x, y);
        this.z = z;
    }

    public float[] GetXYZ()
    {
        return new float[] { GetX(), GetY(), z };
    }

    public override string ToString()
    {
        return "(" + GetX() + "," + GetY() + "," + z + ")";
    }
}