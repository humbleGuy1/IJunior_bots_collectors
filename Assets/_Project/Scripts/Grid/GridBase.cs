using Config.Grid;
using System.Collections.Generic;
using UnityEngine;

namespace GridSystem
{
    public class GridBase : MonoBehaviour
    {
        [SerializeField] private GridConfig _config;
        [SerializeField] private Transform _startPoint;

        private List<Cell> _cells;
        private Vector3 _startPosition;

        public void Initialize()
        {
            _startPosition = _startPoint.position;
            _cells = new List<Cell>();

            FillWithCells();
        }

        private void FillWithCells()
        {
            for (float x = 0; x < _config.SizeX; x += _config.CellSizeX)
            {
                for (float z = 0; z < _config.SizeZ; z += _config.CellSizeZ)
                {
                    float centerX = x + _config.CellSizeX / 2;
                    float centerZ = z + _config.CellSizeZ / 2;
                    Vector3 cellCenter = new(centerX + _startPosition.x, _startPosition.y, centerZ + _startPosition.z);

                    _cells.Add(new Cell(cellCenter));
                }
            }
        }
    }
}


