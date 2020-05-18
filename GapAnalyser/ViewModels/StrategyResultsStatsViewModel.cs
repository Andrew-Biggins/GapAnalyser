﻿using System;
using System.Collections.Generic;
using System.Text;
using GapAnalyser.Interfaces;

namespace GapAnalyser.ViewModels
{
    public sealed class StrategyResultsStatsViewModel
    {
        public string TradeCount { get; } = string.Empty;

        public string Wins { get; } = string.Empty;

        public string Loses { get; } = string.Empty;

        public string LongestWinningStreak { get; } = string.Empty;

        public string LongestLosingStreak { get; } = string.Empty;

        public string Profit { get; } = string.Empty;

        public string BiggestWin { get; } = string.Empty;

        public string AverageWin { get; } = string.Empty;

        public string AverageLoss { get; } = string.Empty;

        public string WinProbability { get; } = string.Empty;

        public string ProfitFactor { get; } = string.Empty;

        public string Expectancy { get; } = string.Empty;

        public StrategyResultsStatsViewModel()
        {
            
        }

        public StrategyResultsStatsViewModel(IStrategy strategy)
        {
            TradeCount = $"{strategy.Stats.TradeCount}";
            Wins = $"{strategy.Stats.Wins}";
            Loses = $"{strategy.Stats.Loses}";
            LongestWinningStreak = $"{strategy.Stats.LongestWinningStreak}";
            LongestLosingStreak = $"{strategy.Stats.LongestLosingStreak}";
            Profit = $"{strategy.Stats.Profit:N1}";
            BiggestWin = $"{strategy.Stats.BiggestWin:N1}";
            AverageWin = $"{strategy.Stats.AverageWin:N1}";
            AverageLoss = $"{strategy.Stats.AverageLoss:N1}";
            WinProbability = $"{strategy.Stats.WinProbability:P}";
            ProfitFactor = $"{strategy.Stats.ProfitFactor:N1}";
            Expectancy = $"{strategy.Stats.Expectancy:N1}";
        }
    }

}