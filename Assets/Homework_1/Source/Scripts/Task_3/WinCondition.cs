using System.Collections.Generic;
using UnityEngine;

namespace BallsPattern
{
    public abstract class WinCondition
    {
        private Window _loseCanvas;
        private Window _winCanvas;

        public IReadOnlyCollection<Ball> Balls { get; private set; }

        public WinCondition(IReadOnlyCollection<Ball> balls, Window loseCanvas, Window winCanvas)
        {
            Balls = new List<Ball>(balls);
            _loseCanvas = loseCanvas;
            _winCanvas = winCanvas;
        }

        protected abstract void Interact(Color winColor);

        protected void Win() => _winCanvas.Show(true, 0.25f);

        protected void Lose() => _loseCanvas.Show(true, 0.25f);

        protected void ApplyCondition(bool isSuccess)
        {
            foreach (var ball in Balls)
            {

            }
        }
    }
}