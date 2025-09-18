using UnityEngine;

public class Orange : Fruit
{
    public override void GiveFruit()
    {
        manager.AddScore(50);
    }
}
