namespace MegaDesk_Museruka
{
    public class Desk
    {
        // validatator values
        public const int MINWIDTH = 24;
        public const int MAXWIDTH = 96;
        public const int MINDEPTH = 12;
        public const int MAXDEPTH = 48;

        //width, depth, number of drawers, and the surface material.
        public double Width { get; set; }
        public double Depth { get; set; }
        public double NumberOfDrawers { get; set; }
        public Material SurfaceMaterial { get; set; }


        public enum Material
        {
            // (laminate, oak, rosewood, veneer, or pine) 
            Laminate = 1,
            Oak,
            Rosewood,
            Veneer,
            Pine
        }

    }
}
