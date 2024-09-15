using Config.Grid;
using System.Collections.Generic;
using UnityEngine;

namespace GridSystem
{
    public class Grid : MonoBehaviour
    {
        [SerializeField] private GridConfig _config;
        [SerializeField] private Transform _startPoint;

        private List<Cell> _cells;
        private Vector3 _startPosition;

        public IReadOnlyList<Cell> Cells => _cells;

        public void Initialize()
        {
            _startPosition = new(_startPoint.position.x, 0, _startPoint.position.z);
            _cells = new List<Cell>();

            Fill();
        }

        private void Fill()
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

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.red;

            _startPosition = new(_startPoint.position.x, 0, _startPoint.position.z);
            Vector3 start;
            Vector3 end;

            for (float x = 0; x <= _config.SizeX; x += _config.CellSizeX)
            {
                start = new Vector3(x + _startPosition.x, _startPosition.y, _startPosition.z);
                end = new Vector3(x + _startPosition.x, _startPosition.y, _config.SizeZ + _startPosition.z);

                Gizmos.DrawLine(start, end);
            }

            for (float z = 0; z <= _config.SizeZ; z += _config.CellSizeZ)
            {
                start = new Vector3(_startPosition.x, _startPosition.y, z + _startPosition.z);
                end = new Vector3(_config.SizeX + _startPosition.x, _startPosition.y, z + _startPosition.z);

                Gizmos.DrawLine(start, end);
            }
        }
    }
}
    

