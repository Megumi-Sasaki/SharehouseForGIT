
using UnityEngine;


[CreateAssetMenu(fileName = "New Item", menuName ="ScriptableObject/ Create Item")]


public class KujyoItemScriptable : ScriptableObject
{

    new public string name = "New Item";

    public Sprite icon = null;

    public int SptitemNO;
}
