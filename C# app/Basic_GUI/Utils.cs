using System;

namespace Basic_GUI
{   
    // This class handle util functions 
    class Utils
    {
        // Yaw angle calculation 
        public double[] toEuler(float qX, float qY, float qZ, float qW)
        {

            double sqW = qW * qW;
            double sqX = qX * qX;
            double sqY = qY * qY;
            double sqZ = qZ * qZ;
            double yaw = 0.0;
            double roll = 0.0;
            double pitch = 0.0;
            double[] retv = new double[3];
            double unit = sqX + sqY + sqZ + sqW; // if normalised is one, otherwise
                                                 // is correction factor
            double test = qW * qX + qY * qZ;
            if (test > 0.499 * unit)
            { // singularity at north pole
                yaw = 2 * Math.Atan2(qY, qW);
                pitch = Math.PI / 2;
                roll = 0;
            }
            else if (test < -0.499 * unit)
            { // singularity at south pole
                yaw = -2 * Math.Atan2(qY, qW);
                pitch = -Math.PI / 2;
                roll = 0;
            }
            else
            {
                yaw = Math.Atan2(2.0 * (qW * qZ - qX * qY),
                        1.0 - 2.0 * (sqZ + sqX));
                roll = Math.Asin(2.0 * test / unit);
                pitch = Math.Atan2(2.0 * (qW * qY - qX * qZ),
                        1.0 - 2.0 * (sqY + sqX));
            }
            retv[0] = pitch;
            retv[1] = roll;
            retv[2] = yaw;
            return retv;
        }        
    }
}
