namespace ObserveDesingPattern
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Player : IPlayer
    {
        private List<ICalculateObsever> observers = new List<ICalculateObsever>();
        private float direction;
        private float angle;
        private float force;

        public float Direction
        {
            get { return direction; }
            set { direction = value; NotifyObservers();}
        }

        public float Angle
        {
            get { return angle; }
            set { angle = value; NotifyObservers(); }
        }

        public float Force
        {
            get { return force; }
            set { force = value; NotifyObservers(); }
        }

        public PlayerType Type { get; set; }


        public void CreateObserver(ICalculateObsever observer)
        {
            observers.Add(observer);
        }

        public void NotifyObservers()
        {
            foreach (ICalculateObsever observer in observers)
            {
                observer.Update(direction, angle, force);
            }
        }

        public void Move(float x, float y)
        {
            float newDirection = (float)Math.Atan2(y, x);
            float newAngle = (float)Math.Atan2(y, x);
            float newForce = (float)Math.Sqrt(x * x + y * y);

            Direction = newDirection;
            Angle = newAngle;
            Force = newForce;
        }

    }

    public enum PlayerType { Type1, Type2 }

    public class Referee : ICalculateObsever
    {
        public void Update(float direction, float angle, float force)
        {
            Console.WriteLine("Oyuncu hareket bilgisi. Direction: " + direction + ", Angle: " + angle + ", Force: " + force);
        }
    }
}
