﻿namespace TradingSharedCore.Interfaces
{
    public interface ISelectableStrategy : ISelectable
    {
        string ShortName { get; }
    }
}