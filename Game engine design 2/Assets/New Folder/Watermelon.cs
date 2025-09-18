using UnityEngine;

public class Watermelon : Fruit
{
    public override void GiveFruit()
    {
        manager.AddScore(100);
    }
}
