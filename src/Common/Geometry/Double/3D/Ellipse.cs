﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torbellino.Geometry.Double._3D
{
    /// <summary>
    /// 楕円
    /// </summary>
    public struct Ellipse : IGeometry, ICurve, I3D
    {
        /// <summary>
        /// 配置位置
        /// </summary>
        public Axis2 Position { get; }

        /// <summary>
        /// X軸方向半径
        /// </summary>
        public double R1 { get; }

        /// <summary>
        /// Y軸方向半径
        /// </summary>
        public double R2 { get; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="position">配置位置</param>
        /// <param name="r1">X軸方向半径</param>
        /// <param name="r2">Y軸方向半径</param>
        public Ellipse(Axis2 position, double r1, double r2)
        {
            Position = position;
            R1 = r1;
            R2 = r2;
        }
    }
}
