using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torbellino.Geometry.Double._3D
{
    /// <summary>
    /// 双曲線
    /// </summary>
    public struct Hyperbola : IGeometry, ICurve, I3D
    {
        /// <summary>
        /// 配置位置
        /// </summary>
        public Axis2 Position { get; }

        /// <summary>
        /// X軸上の距離
        /// </summary>
        public double R1 { get; }

        /// <summary>
        /// 線(1,1)からの距離
        /// </summary>
        public double R2 { get; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="position">配置位置</param>
        /// <param name="r1">X軸上の距離</param>
        /// <param name="r2">線(1,1)からの距離</param>
        public Hyperbola(Axis2 position, double r1, double r2)
        {
            Position = position;
            R1 = r1;
            R2 = r2;
        }
    }
}
