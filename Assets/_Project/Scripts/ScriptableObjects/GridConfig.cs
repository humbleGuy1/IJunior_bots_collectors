using UnityEngine;

namespace Config.Grid
{
    [CreateAssetMenu(fileName = "GridConfig", menuName = "Grid")]
    public class GridConfig : ScriptableObject
    {
        [field: SerializeField, Min(0)] public int SizeX { get; private set; }
        [field: SerializeField, Min(0)] public int SizeZ { get; private set; }
        [field: SerializeField, Min(0)] public int CellSizeX { get; private set; }
        [field: SerializeField, Min(0)] public int CellSizeZ { get; private set; }
    }
}

