using Config.Grid;
using UnityEngine;

namespace GridSystem
{
    public class Grid : MonoBehaviour
    {
        [SerializeField] private GridConfig _config;

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.red;

            //Gizmos.DrawLine()
        }
    }
}

