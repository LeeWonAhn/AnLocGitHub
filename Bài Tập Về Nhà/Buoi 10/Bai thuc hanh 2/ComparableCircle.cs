using System;

namespace Shape
{
  public class ComperableCircle : Circle, IComparable<ComperableCircle>
  {

    public ComperableCircle() { }
    public ComperableCircle(double radius) : base(radius) { }
    public ComperableCircle(double radius, string color, bool filled) : base(radius, color, filled) { }

    public int CompareTo(ComperableCircle o)
    {
      if (getRadius() > o.getRadius()) return 1;
      else if (getRadius() < o.getRadius()) return -1;
      else return 1;
    }
  }
}