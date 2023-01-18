using System;

//Struct này đã implement interface IEquatable với kiểu dữ liệu GridPosition, nó cho phép bạn so sánh 2 đối tượng GridPosition bằng cách sử dụng toán tử == hoặc !=.
public struct GridPosition : IEquatable<GridPosition>
{
    public int x;
    public int z;

    public GridPosition(int x, int z)
    {
        this.x = x;
        this.z = z;
    }
    public bool Equals(GridPosition other)
    {
        return this == other;
    }

    public override bool Equals(object obj)
    {
        return obj is GridPosition position &&
               x == position.x &&
               z == position.z;
    }

    public override int GetHashCode()
    {
        //GetHashCode để trả về mã băm của đối tượng và ToString để in ra thông tin của đối tượng.
        return (x, z).GetHashCode();
    }

    public override string ToString()
    {
        return $"x: {x}; z: {z}";
    }

    public static bool operator ==(GridPosition a, GridPosition b)
    {
        return a.x == b.x && a.z == b.z;
        //Toán tử == so sánh xem hai đối tượng có cùng giá trị x và z không. Nếu có, nó sẽ trả về true, nếu không nó sẽ trả về false
    }

    public static bool operator !=(GridPosition a, GridPosition b)
    {
        return !(a == b);
        //nó sẽ trả về true nếu hai đối tượng không có giá trị bằng nhau và false nếu có.
    }
    public static GridPosition operator +(GridPosition a, GridPosition b)
    {
        return new GridPosition(a.x + b.x, a.z + b.z);
    }

    public static GridPosition operator -(GridPosition a, GridPosition b)
    {
        return new GridPosition(a.x - b.x, a.z - b.z);
    }

}