namespace Engine.Math {
  public class Angle {
    private double radians;

    public double Degrees {
      get {return (radians/Math.PI)*180;}
      set {
        this.radians = (value / 180) * Math.PI;
      }
    }
    public double Gradians {
      get {return (radians/Math.PI)*200;}
      set {
        this.radians = (value / 200) * Math.PI;
      }
    }
    public double Radians {
      get {return this.radians;}
      set {this.radians = value;}
    }

    public Angle(decimal x) : this(x,'r') {}
    public Angle(decimal x,char c) {
      if (c == 'r') this.Radians = (double) x;
      else if (c == 'g') this.Gradians = (double) x;
      else this.Degrees = (double) x;
    }

    public static implicit operator double(Angle a) {
      return a.Radians;
    }
  }
}
