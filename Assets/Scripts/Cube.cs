using UnityEngine;

public class Cube : Shape //INHERITANCE
{
    void Start()
    {
        color = Color.red;
        shapeName = "Red Cube";

        ColorShape();
    }

    public override void DisplayText() //POLYMORPHISM
    {
        text.text = shapeName + " says:\n I AM HOT";
    }
}
