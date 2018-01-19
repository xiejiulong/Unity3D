using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class NewStageObserverArchievement:IGameEventObserver
{
    private NewStageSubject mSubject;

    private ArchievementSystem mArchSystem;
    public NewStageObserverArchievement(ArchievementSystem archSystem)
    {
        mArchSystem = archSystem;
    }

    public override void Update()
    {
        mArchSystem.SetMaxStageLv(mSubject.stageCount);
    }

    public override void SetSubject(IGameEventSubject sub)
    {
        mSubject = sub as NewStageSubject;
    }
}
