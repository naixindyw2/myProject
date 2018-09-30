using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


[CreateAssetMenu]//可以直接在Project右键创建
public class MySciptObj : ScriptableObject
{
    [System.Serializable]
    public class MyObj
    {
        public int age;
        public string name;
    }

    public List<MyObj> myObjs = new List<MyObj>();

    public void Print()
    {
        for (int i = 0, iMax = myObjs.Count; i < iMax; i++)
        {
            Debug.Log("Name:" + myObjs[i].name + "Age:" + myObjs[i].age);
        }
    }

    public void Save(string name, int age)
    {
        myObjs.Add(new MyObj {name = name, age = age});
    }

    private string age = string.Empty;
    private string name = string.Empty;

    private void OnGUI()
    {
        if (GUILayout.Button("Print"))
        {
            var data = Resources.Load<MySciptObj>("myObj");
            data.Print();
        }

        name = GUILayout.TextField(name);
        age = GUILayout.TextField(age);
        if (GUILayout.Button("Save"))
        {
            var data = Resources.Load<MySciptObj>("myObj");
            data.Save(name, int.Parse(age));
        }
    }

}
