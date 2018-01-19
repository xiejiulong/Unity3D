using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class ArchievementSystem:IGameSystem
{

    private int mEnemyKilledCount = 0;
    private int mSoldieryKilledCount = 0;
    private int mMaxStageLv = 1;

    //PlayerPrefs  json xml  

    public override void Init()
    {
        base.Init();
        mFacade.RegisterObserver(GameEventType.EnemyKilled, new EnemyKillObserverArchievement(this));
        mFacade.RegisterObserver(GameEventType.SoldierKilled, new SoldierKilledObserverArchievement(this));
        mFacade.RegisterObserver(GameEventType.NewStage, new NewStageObserverArchievement(this));
    }

    public void AddEnemyKilledCount(int number = 1)
    {
        mEnemyKilledCount += number;
        //Debug.Log("EnemyKilledCount" + mEnemyKilledCount);
    }
    public void AddSoldierKilledCount(int number = 1)
    {
        mSoldieryKilledCount += number;
        //Debug.Log("SoldierKilledCount" + mSoldieryKilledCount);
    }
    public void SetMaxStageLv(int stageLv)
    {
        if (stageLv > mMaxStageLv)
        {
            mMaxStageLv = stageLv;
        }
        //Debug.Log("MaxStageLv" + mMaxStageLv);
    }

    public AchievementMemento CreateMemento()
    {
        //PlayerPrefs.SetInt("EnemyKilledCount", mEnemyKilledCount);
        //PlayerPrefs.SetInt("SoldierKilledCount", mSoldieryKilledCount);
        //PlayerPrefs.SetInt("MaxStageLv", mMaxStageLv);
        AchievementMemento memento = new AchievementMemento();
        memento.enemyKilledCount = mEnemyKilledCount;
        memento.soldieryKilledCount = mSoldieryKilledCount;
        memento.maxStageLv = mMaxStageLv;
        return memento;
    }

    public void SetMemento( AchievementMemento memento )
    {
        //mEnemyKilledCount = PlayerPrefs.GetInt("EnemyKilledCount" );
        //mSoldieryKilledCount=PlayerPrefs.GetInt("SoldierKilledCount" );
        //mMaxStageLv=PlayerPrefs.GetInt("MaxStageLv");
        mEnemyKilledCount = memento.enemyKilledCount;
        mSoldieryKilledCount = memento.soldieryKilledCount;
        mMaxStageLv = memento.maxStageLv;
    }
}

