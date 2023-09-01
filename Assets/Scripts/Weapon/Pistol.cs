using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : Weapon
{
    public override void Shoot(Transform shootPoint)
    {
        var bullet = Instantiate(Bullet, shootPoint.position, Quaternion.identity);
    }
}
