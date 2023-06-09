using working_with_interface;

internal class Program
{
    private static void Main(string[] args)
    {
        IClown fingersTheClown = new ScaryScary("Wielkieczerwone nosy", 14);
        fingersTheClown.Honk();
        IScaryClown iScaryClownRef = fingersTheClown as ScaryScary;
        iScaryClownRef.ScareLittleChildren();
    }
}