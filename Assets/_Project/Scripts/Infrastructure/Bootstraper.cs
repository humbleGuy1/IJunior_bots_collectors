using GridSystem;
using UnityEngine;

namespace Infrastructure
{
    public class Bootstraper : MonoBehaviour
    {
        [SerializeField] private GridBase _grid;

        private void Awake()
        {
            _grid.Initialize();
        }
    }
}

