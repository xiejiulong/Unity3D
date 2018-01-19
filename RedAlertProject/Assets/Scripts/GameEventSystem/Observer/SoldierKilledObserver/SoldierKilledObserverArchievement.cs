using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class SoldierKilledObserverArchievement:IGameEventObserver
{

    private ArchievementSystem mArchSystem;
    public SoldierKilledObserverArchievement(ArchievementSystem archSystem)
    {
        mArchSystem = archSystem;
    }

    public override void Update()
    {
        mArchSystem.AddSoldierKilledCount();
    }

    public override void SetSubject(IGameEventSubject sub)
    {
        return;
    }
}
