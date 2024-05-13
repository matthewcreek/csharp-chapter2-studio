namespace CircleMethods {
    public class Circle {
        public static double Area(double radius) {
            double areaCircle = Math.Round(Math.PI * Math.Pow(radius, 2), 1);
            return areaCircle;
        }

        public static double Circumference(double radius) {
            double circumference = Math.Round(2 * Math.PI * radius, 1);
            return circumference;
        }
        public static double Diameter(double radius) {
            double diameter = Math.Round(2 * radius, 1);
            return diameter;
        }
    }
}