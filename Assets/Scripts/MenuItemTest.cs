using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
// https://docs.unity3d.com/ScriptReference/MenuItem.html
public class MenuItemTest : MonoBehaviour
{
    [MenuItem("MyMenu/Do Something")]
    static void DoSomething()
    {
        Debug.Log("Doing Something...");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
