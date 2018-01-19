using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class EnemyKillObserverArchievement:IGameEventObserver
{
    //private EnemyKilledSubject mSubject;

    private ArchievementSystem mArchSystem;
    public EnemyKillObserverArchievement(ArchievementSystem archSystem)
    {
        mArchSystem = archSystem;
    }

    public override void Update()
    {
        mArchSystem.AddEnemyKilledCount();
    }

    public override void SetSubject(IGameEventSubject sub)
    {
        //mSubject = sub as EnemyKilledSubject;
    }
}
