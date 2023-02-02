using System;
namespace SQA_Assignment2
{
    public class Circle
    {
        private int radius;
        public Circle()
        {
            radius = 1;
        }

        public Circle(int newRadius)
        {
            radius = newRadius;
        }

        public int GetRadius()
        {
            return radius;
        }

        public void SetRadius(int newRadius)
        {
            radius = newRadius;
        }

        public double GetCircumference()
        {
            return 2 * Math.PI * radius;
        }

        public double GetArea()
        {
            return Math.PI * radius * radius;
        }
    }
}

