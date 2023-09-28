using UnityEngine;

public class Sphere : Shape //INHERITANCE
{
    void Start()
    {
        color = Color.green;
        shapeName = "Green Sphere";

        ColorShape();
    }

    public override void DisplayText() //POLYMORPHISM
    {
        text.text = shapeName + " says:\n I LIKE PLANTS";
    }
}
