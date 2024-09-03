using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProblems.Solutions.MediumSolution
{
    public class Solution735
    {
        public int[] AsteroidCollision(int[] asteroids)
        {
            var newAsteroids = new Stack<int>();

            foreach (var asteroid in asteroids)
            {
                var isAddAsteroids = true;
                while (newAsteroids.Count > 0  && (newAsteroids.Peek() > 0 && asteroid < 0))
                {
                    var lastAsteroid = newAsteroids.Peek();
                    if (Math.Abs(lastAsteroid) >= Math.Abs(asteroid))
                    {
                        isAddAsteroids = false;
                        if (Math.Abs(asteroid) == Math.Abs(lastAsteroid))
                            newAsteroids.Pop();
                        break;
                    }
                    newAsteroids.Pop();
                }

                if (isAddAsteroids)
                    newAsteroids.Push(asteroid);
            }
            
            return newAsteroids.Reverse().ToArray();
        }
    }
}
