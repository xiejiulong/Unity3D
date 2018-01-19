using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class SoldierCaptive:ISoldier
{
    private IEnemy mEnemy;

    public SoldierCaptive(IEnemy enemy)
    {
        mEnemy = enemy;
        
        ICharacterAttr attr = new SoldierAttr(enemy.attr.strategy, 1, enemy.attr.baseAttr);
        this.attr = attr;

        this.gameObject = mEnemy.gameObject;

        this.weapon = mEnemy.weapon;
    }

    protected override void PlaySound()
    {
        //Do nothing
    }

    protected override void PlayEffect()
    {
        mEnemy.PlayEffect();
    }
}
