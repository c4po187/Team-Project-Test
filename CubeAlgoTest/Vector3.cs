/***** Vector3 *****/

#region Prerequisites

using System;

#endregion

#region Namespaces

namespace CubeAlgoTest {

    #region Structures

    public struct Vector3 {

        #region Members

        public float X, Y, Z;

        #endregion

        #region Operator Overloads

        public static Vector3 operator +(Vector3 lhs, Vector3 rhs) {
            return new Vector3 { 
                X = lhs.X + rhs.X, 
                Y = lhs.Y + rhs.Y, 
                Z = lhs.Z + rhs.Z 
            };
        }

        public static Vector3 operator +(Vector3 lhs, float val) {
            return new Vector3 {
                X = lhs.X + val,
                Y = lhs.Y + val,
                Z = lhs.Z + val
            };
        }

        public static Vector3 operator -(Vector3 lhs, Vector3 rhs) {
            return new Vector3 { 
                X = lhs.X - rhs.X,
                Y = lhs.Y - rhs.Y,
                Z = lhs.Z - rhs.Z
            };
        }

        public static Vector3 operator -(Vector3 lhs, float val) {
            return new Vector3 {
                X = lhs.X - val,
                Y = lhs.Y - val,
                Z = lhs.Z - val
            };
        }

        public static Vector3 operator *(Vector3 lhs, Vector3 rhs) {
            return new Vector3 { 
                X = lhs.X * rhs.X,
                Y = lhs.Y * rhs.Y,
                Z = lhs.Z * rhs.Z
            };
        }

        public static Vector3 operator *(Vector3 lhs, float scalar) {
            return new Vector3 { 
                X = lhs.X * scalar,
                Y = lhs.Y * scalar,
                Z = lhs.Z * scalar
            };
        }

        public static Vector3 operator /(Vector3 lhs, float scalar) {
            return new Vector3 { 
                X = lhs.X / scalar,
                Y = lhs.Y / scalar,
                Z = lhs.Z / scalar
            };
        }

        public static implicit operator string(Vector3 rhs) {
            return rhs.ToString();
        }

        #endregion

        #region Functions

        public static Vector3 Zero() {
            return new Vector3 {  X = 0f, Y = 0f, Z = 0f };
        }

        public static Vector3 Unit() {
            return new Vector3 { X = 1f, Y = 1f, Z = 1f };
        }
        
        public double Norm() {
            return Math.Sqrt(Math.Pow(this.X, 2) + Math.Pow(this.Y, 2) + Math.Pow(this.Z, 2));
        }

        public Vector3 Normalize() {
            double norm = this.Norm();

            if (norm > 1.0e-8f) {
                double inverse = 1f - norm;

                this.X *= (float)inverse;
                this.Y *= (float)inverse;
                this.Z *= (float)inverse;
            }

            return this;
        }

        public double Dot(Vector3 rhs) {
            return ((this.X * rhs.X) + (this.Y * rhs.Y) + (this.Z * rhs.Z));
        }

        public Vector3 Cross(Vector3 rhs) {
            return new Vector3 { 
                X = ((this.Y * rhs.Z) - (this.Z - rhs.Y)),
                Y = ((this.Z * rhs.X) - (this.X - rhs.Z)),
                Z = ((this.X * rhs.Y) - (this.Y * rhs.X))
            };
        }

        public override string ToString() {
            return String.Concat(
                this.X.ToString("0.##"), ", ", 
                this.Y.ToString("0.##"), ", ",
                this.Z.ToString("0.##"), " "
                );
        }

        #endregion
    }

    #endregion

}

#endregion