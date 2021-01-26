using UnityEngine;

namespace DefaultNamespace
{
    public class GUIManager : MonoBehaviour
    {
        public void ResetGame()
        {
            GameManager.Instance.ResetGame();
        }
    }
}