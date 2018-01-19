using System;
using System.Collections.Generic;
using UnityEngine;
using System.Text;


public abstract class IBaseUI
{
    protected GameFacade mFacade;

    public GameObject mRootUI;
    public virtual void Init() {
        mFacade = GameFacade.Insance;
    }
    public virtual void Update() { }
    public virtual void Release() { }


    protected void Show()
    {
        mRootUI.SetActive(true);
    }
    protected void Hide()
    {
        mRootUI.SetActive(false);
    }
}
