using Config.Grid;
using UnityEngine;

namespace GridSystem
{
    public class GridDrawer : MonoBehaviour
    {
        [SerializeField] private GridConfig _config;
        [SerializeField] private Transform _startPoint;

        private Vector3 _startPosition;

        public void OnDrawGizmos()
        {
            Gizmos.color = Color.red;

            _startPosition = _startPoint.position;
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


