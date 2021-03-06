﻿using CombinedCore.Interfaces;
using GapTraderWPF;
using GapTraderWPF.Windows;
using System;
using TradeJournalWPF;
using TradingSharedCore.Interfaces;

namespace CombinedWPF
{
    internal sealed class CombinedRunner : TradeJournalRunner, ICombinedRunner
    {
        public CombinedRunner(IContext context) : base(context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void ShowLoadSavedDataWindow(object sender)
        {
            _context.Send(_ =>
            {
                var owner = GetOwner(sender);
                var window = new LoadSavedDataWindow { DataContext = sender, Owner = owner };
                window.ShowDialog();
            });
        }

        public void ShowSaveDataWindow(object sender)
        {
            _context.Send(_ =>
            {
                var owner = GetOwner(sender);
                var window = new SaveDataWindow { DataContext = sender, Owner = owner };
                window.ShowDialog();
            });
        }

        public void ShowUploadNewDataWindow(object sender)
        {
            _context.Send(_ =>
            {
                var owner = GetOwner(sender);
                var window = new UploadDataWindow { DataContext = sender, Owner = owner };
                window.ShowDialog();
            });
        }

        public void ShowTrades(object sender, IStrategy strategy)
        {
            _context.Send(_ =>
            {
                var owner = GetOwner(sender);
                var window = new TradeListWindow { DataContext = strategy, Owner = owner };
                window.ShowDialog();
            });
        }

        private readonly IContext _context;
    }
}
