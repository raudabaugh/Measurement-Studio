﻿using System;

namespace Common
{
    /// <summary>
    /// Структура, представляющая результат измерения в определённый момент времени
    /// X - время
    /// Y - показание первого прибора
    /// Z - показание второго прибора
    /// </summary>
    public struct Point3D
    {       
        public double X { get { return x; } }
        public double Y { get { return y; } }
        double x, y;

        public double? Z { 
            get { return z; }
            set { z = value; }
        }
        double? z;

        public bool WasInitialized { get { return wasInitialized; } }
        bool wasInitialized;

        public Point3D(double x, double y)
        {
            this.x = x;
            this.y = y;            
            this.z = null;
            wasInitialized = true;
        }

        public Point3D(double x, double y, double z):this(x,y)
        {
            this.z = z;
        }

        public override string ToString()
        {
            return String.Format("{0:F3}\t{1:F3}\t{2:F3}", X, Y, Z);
        }
    }
}