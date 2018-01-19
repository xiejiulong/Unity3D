using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class TrainSoldierCommand:ITrainCommand
{

    SoldierType mSoldierType;
    WeaponType mWeaponType;
    Vector3 mPosition;
    int mLv;

    public TrainSoldierCommand(SoldierType st, WeaponType wt, Vector3 pos, int lv)
    {
        mSoldierType = st;
        mWeaponType = wt;
        mPosition = pos;
        mLv = lv;
    }

    public override void Execute()
    {
        switch (mSoldierType)
        {
            case SoldierType.Rookie:
                FactoryManager.soldierFactory.CreateCharacter<SoldierRookie>(mWeaponType, mPosition, mLv);
                break;
            case SoldierType.Sergeant:
                FactoryManager.soldierFactory.CreateCharacter<SoldierSergeant>(mWeaponType, mPosition, mLv);
                break;
            case SoldierType.Captain:
                FactoryManager.soldierFactory.CreateCharacter<SoldierCaptain>(mWeaponType, mPosition, mLv);
                break;
            default:
                Debug.LogError("无法执行命令，无法根据SoldierType:" + mSoldierType + "创建角色");
                break;
        }
        //FactoryManager.soldierFactory.CreateCharacter<>
    }
}
