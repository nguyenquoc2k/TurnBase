using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridObject
{
    private GridSystem gridSystem;
    private GridPosition gridPosition;
    private List<Unit> unitList;

    public GridObject(GridSystem gridSystem, GridPosition gridPosition)
    {
        this.gridSystem = gridSystem;
        this.gridPosition = gridPosition;
        unitList = new List<Unit>();
    }

    public override string ToString()
    {
        string unitString = "";
        foreach (Unit unit in unitList)
        {
            unitString += unit + "\n";
        }

        return gridPosition.ToString() + "\n" + unitString;
    }

    public void AddUnit(Unit unit)
    {
        //để thêm đơn vị vào danh sách đơn vị của đối tượng lưới đó.
        unitList.Add(unit);
    }

    public void RemoveUnit(Unit unit)
    {
        //sẽ xóa một đơn vị khỏi danh sách đơn vị của đối tượng lưới.
        unitList.Remove(unit);
    }

    public List<Unit> GetUnitList()
    {
        //sẽ trả về danh sách các đơn vị trong đối tượng lưới.
        return unitList;
    }
    public bool HasAnyUnit()
    {
        return unitList.Count > 0;
    }

}