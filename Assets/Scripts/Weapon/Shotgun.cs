using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Events;

public class Shotgun : Weapon
{
    [SerializeField] private int _bulletsPerShoot = 3;

    public override void Shoot(Transform shootPoint)
    {
        float offset = 5f;
        float spread = 5f;
        
        for(int i = 0; i < _bulletsPerShoot; i++)
        {
            Vector2 direction = new Vector2(1, 0).normalized;

            var bullet = Instantiate(Bullet, shootPoint.position, Quaternion.identity);

            bullet.transform.Rotate(0, 0, Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg + offset);

            offset -= spread;
        }
    }
}
