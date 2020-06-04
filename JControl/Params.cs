using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace JControl.Params
{
    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    }


    public enum ConveyorBeltPostion
    {
        UpperLeft=1,
        LowerLeft=2,
        UpperRight=4,
        LowerRight=8
        
    }
    public class PipeSingleParams:IComparable
    {
        [Description("序号"), Browsable(true)]
        public int Id { get; set; }
        [Description("长度"), Browsable(true)]
        public int Length { get; set; }
        [Description("方向"), Browsable(true)]
        public Direction ControlDirection { get; set; }

        public static bool operator ==(PipeSingleParams p1, PipeSingleParams p2)
       {
            return p1.Id == p2.Id;
       }
 
      public static bool operator !=(PipeSingleParams p1, PipeSingleParams p2)
     {
         return !(p1.Id == p2.Id);
     }

      public int CompareTo(object obj)
        {
            PipeSingleParams a = obj as PipeSingleParams;
            return Id.CompareTo(a.Id);
        }

    }
}
