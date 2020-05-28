using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tinker;

public class TestClick : TButton<string>
{
    // Start is called before the first frame update
    void Start()
    {
        m_genericMember = "Hello Test";
        Init();
        Callback += TestProcess;
    }

   void TestProcess(string ret)
   {
        Debug.Log("Clicked : " + ret);
   }
}
