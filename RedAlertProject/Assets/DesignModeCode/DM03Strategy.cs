using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;


public class DM03Strategy:MonoBehaviour
{
    void Start()
    {
        StrategyContext context = new StrategyContext();
        context.stragegy = new ConcreteStrategyB();

        context.Cal();

    }
}

public class StrategyContext
{
    public IStrategy stragegy;
    public void Cal()
    {
        stragegy.Cal();
    }
}

public interface IStrategy
{
    void Cal();
}
public class ConcreteStrategyA : IStrategy
{

    public void Cal()
    {
        Debug.Log("使用A策略计算");
    }
}
public class ConcreteStrategyB : IStrategy
{

    public void Cal()
    {
        Debug.Log("使用B策略计算");
    }
}
