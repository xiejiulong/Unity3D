using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class DM02Bridge:MonoBehaviour
{
    void Start()
    {
        //IRenderEngine renderEngine = new SuperRender();

        //Sphere sphere = new Sphere(renderEngine);
        //sphere.Draw();
        //Cube cube = new Cube(renderEngine);
        //cube.Draw();
        //Capsule capsule = new Capsule(renderEngine);
        //capsule.Draw();

        //ICharacter character = new SoldierCaptain();
        //WeaponGun gun = new WeaponGun();
        //character.gun = gun;

        //WeaponRifle rifle = new WeaponRifle();
        //character.rifle = rifle;
        //WeaponRocket rocket = new WeaponRocket();
        //character.rocket = rocket;
        //character.weapon = new WeaponLaser();
       // character.Attack(Vector3.one);
    }
}

public class IShape
{
    public string name;
    public IRenderEngine renderEngine;

    public IShape(IRenderEngine renderEngine)
    {
        this.renderEngine = renderEngine;
    }

    public void Draw()
    {
        renderEngine.Render(name);
    }
}
public abstract class IRenderEngine
{
    public abstract void Render(string name);
}

public class Sphere:IShape
{
    public Sphere(IRenderEngine re):base(re)
    {
        name = "Sphere";
    }
    //public string name = "Sphere";

    //public OpenGL openGL = new OpenGL();
    //public DirectX dx = new DirectX();

    //public void Draw()
    //{
    //    openGL.Render(name);
    //}
    //public void DrawDX()
    //{
    //    dx.Render(name);
    //}
}
public class Cube:IShape
{
    public Cube(IRenderEngine re):base(re)
    {
        name = "Cube";
    }
    //public string name = "Cube";

    //public OpenGL openGL = new OpenGL();
    //public DirectX dx = new DirectX();

    //public void Draw()
    //{
    //    openGL.Render(name);
    //}
    //public void DrawDX()
    //{
    //    dx.Render(name);
    //}
}
public class Capsule:IShape
{
    public Capsule(IRenderEngine re):base(re)
    {
        name = "Capsule";
    }
    //public string name = "Capsule";

    //public OpenGL openGL = new OpenGL();
    //public DirectX dx = new DirectX();

    //public void Draw()
    //{
    //    openGL.Render(name);
    //}
    //public void DrawDX()
    //{
    //    dx.Render(name);
    //}
}

public class OpenGL:IRenderEngine
{
    public override void Render(string name)
    {
        Debug.Log("OpenGL绘制出来了:" + name);
    }
}

public class DirectX:IRenderEngine
{
    public override void Render(string name)
    {
        Debug.Log("DrectX绘制出来了:" + name);
    }
}


public class SuperRender : IRenderEngine
{
    public override void Render(string name)
    {
        Debug.Log("SuperRender绘制出来了:" + name);
    }
}