using UnityEngine;
using UnityEngine.UI;

namespace WhackAMole
{
    public sealed class GameHud : MonoBehaviour
    {
        public GameManager game;
        public Text label;
        private void OnEnable() { if (game) game.Changed += Refresh; Refresh(); }
        private void OnDisable() { if (game) game.Changed -= Refresh; }
        private void Refresh()
        {
            if (game && label) label.text = $"제한시간 :  {Mathf.CeilToInt(game.Remaining)}    점수 : {game.Score}    미스 : {game.Misses}";
        }
    }
}
