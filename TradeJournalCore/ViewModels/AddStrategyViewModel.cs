﻿using System;
using System.Collections.Generic;
using System.Windows.Input;
using TradeJournalCore.Interfaces;
using TradingSharedCore;

namespace TradeJournalCore.ViewModels
{
    public sealed class AddStrategyViewModel : BindableBase
    {
        public EventHandler StrategyAdded;

        public ICommand ConfirmNewStrategyCommand => new BasicCommand(() => StrategyAdded.Raise(this));

        public IStrategyDetails StrategyDetails
        {
            get => _strategyDetails;
            set => SetProperty(ref _strategyDetails, value);
        }

        public StrategyType SelectedStrategyType
        {
            get => _selectedStrategyType;
            set
            {
                if (value != _selectedStrategyType)
                {
                    _selectedStrategyType = value;
                    RaisePropertyChanged(nameof(SelectedStrategyType));
                    UpdateStrategyDetails();
                }
            }
        }

        public List<StrategyType> StrategyTypes { get; }

        public AddStrategyViewModel()
        {
            StrategyTypes = GetStrategyTypes();
            UpdateStrategyDetails();
        }

        private void UpdateStrategyDetails()
        {
            switch (SelectedStrategyType)
            {
                case StrategyType.OutOfGap:
                case StrategyType.IntoGap:
                    StrategyDetails = new GapStrategyDetailsViewModel(SelectedStrategyType);
                    break;
                case StrategyType.Triangle:
                case StrategyType.FailedTriangle:
                    StrategyDetails = new StrategyDetailsViewModel(SelectedStrategyType);
                    break;
                case StrategyType.Other:
                    StrategyDetails = new OtherStrategyDetailsViewModel(SelectedStrategyType);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private static List<StrategyType> GetStrategyTypes()
        {
            var list = new List<StrategyType>();

            var strategies = (StrategyType[])Enum.GetValues(typeof(StrategyType));

            foreach (var strategy in strategies)
            {
                list.Add(strategy);
            }

            return list;
        }

        private StrategyType _selectedStrategyType;
        private IStrategyDetails _strategyDetails;
    }
}
