using static System.Math.*;

namespace Engine.Math {
  public class Vector2 {
    public double x;
    public double y;

    public double Magnitude {
      get {
        return Math.Sqrt(Math.Pow(x,2)+Math.Pow(y,2));
      }
      set {
        Angle a = this.Angle;
        this.x = value;
        this.Angle = a;
      }
    }
    public Angle Angle {
      get {
        return new Angle(this);
      }
      set {
        double m = this.Magnitude;
        this.x = cos(value)*m;
        this.y = sin(value)*m;
      }
    }

    public Vector2(double x,double y) {
      this.x=x;this.y=y;
    }
  }
}
