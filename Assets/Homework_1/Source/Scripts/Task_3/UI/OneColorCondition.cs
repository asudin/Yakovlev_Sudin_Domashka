using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BallsPattern
{
    public class OneColorCondition : WinCondition
    {
        private Color _winningColor;

        public OneColorCondition(IReadOnlyCollection<Ball> balls, Window loseCanvas, Window winCanvas, Color winningColor) : base(balls, loseCanvas, winCanvas)
        {
            _winningColor = winningColor;

            Debug.Log($"To win you must explode all balls with the color {_winningColor}");
        }

        protected override void Interact(Color winColor)
        {
            if (winColor != _winningColor)
            {
                Lose();
                ApplyCondition(false);
            }

            Win();
            ApplyCondition(true);
        }
    }
}