using UnityEngine;

public class Cilinder : Shape //INHERITANCE
{
    void Start()
    {
        color = Color.blue;
        shapeName = "Blue Cilinder";

        ColorShape();
    }

    public override void DisplayText() //POLYMORPHISM
    {
        text.text = shapeName + " says:\n I AM WET";
    }

}
