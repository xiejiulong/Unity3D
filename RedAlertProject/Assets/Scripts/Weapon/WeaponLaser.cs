using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class WeaponLaser:IWeapon
{

    //public override void Fire(UnityEngine.Vector3 targetPosition)
    //{
    //    //Debug.Log("显示特效 Laser");
    //    //Debug.Log("播放声音 Laser");
    //    //显示枪口特效
    //}
    public WeaponLaser(WeaponBaseAttr baseAttr, GameObject gameObject) : base(baseAttr, gameObject) { }
    protected override void SetEffetDisplayTime()
    {
        throw new NotImplementedException();
    }

    protected override void PlayBulletEffect(Vector3 targetPosition)
    {
        throw new NotImplementedException();
    }

    protected override void PlaySound()
    {
        throw new NotImplementedException();
    }
}
