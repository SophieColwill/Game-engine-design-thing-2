using UnityEngine;

public class Apple : Fruit
{
    public override void GiveFruit()
    {
        manager.AddScore(25);
    }
}
