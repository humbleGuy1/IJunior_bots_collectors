using UnityEngine;

namespace Config.Grid
{
    [CreateAssetMenu(fileName = "GridConfig", menuName = "Grid")]
    public class GridConfig : ScriptableObject
    {
        [field: SerializeField, Min(0)] public float SizeX { get; private set; }
        [field: SerializeField, Min(0)] public float SizeZ { get; private set; }
        [field: SerializeField, Min(0)] public float CellSizeX { get; private set; }
        [field: SerializeField, Min(0)] public float CellSizeY { get; private set; }
    }
}

