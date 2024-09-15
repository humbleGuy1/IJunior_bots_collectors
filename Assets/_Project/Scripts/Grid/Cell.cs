using UnityEngine;

namespace GridSystem
{
    public class Cell
    {
        public Cell(Vector3 position) =>
            Position = position;

        public Vector3 Position { get; private set; }
        public bool IsOccluded { get; private set; }
    }
}
    

