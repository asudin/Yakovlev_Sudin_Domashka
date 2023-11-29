using System;
using System.Collections.Generic;
using UnityEngine;

namespace BallsPattern
{
    public class AllBallsCondition : WinCondition
    {
        public AllBallsCondition(IReadOnlyCollection<Ball> balls, Window loseCanvas, Window winCanvas) : base(balls, loseCanvas, winCanvas) { }

        private void OnEnable()
        {
            foreach (Ball ball in Balls)
            {
                ball.Destroyed += OnBallDestroy;
            }
        }

        private void OnBallDestroy(Ball ball)
        {
            throw new NotImplementedException();
        }

        protected override void Interact(Color winColor)
        {
            throw new NotImplementedException();
        }
    }
}