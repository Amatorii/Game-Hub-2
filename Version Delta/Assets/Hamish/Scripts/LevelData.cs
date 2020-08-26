using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Level/Level Info")]
public class LevelData : ScriptableObject
{
    public int AlbertLevel = 0;
    public int SpudLevel = 0;
    public int YamezLevel = 0;
    public int BenedickLevel = 0;
    public string GameLevel;
}
