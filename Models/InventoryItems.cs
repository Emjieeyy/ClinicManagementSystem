using System;
using System.ComponentModel;

namespace ClinicManagementSystem.Models
{
    internal class InventoryItems : INotifyPropertyChanged
    {
        private int? _itemId;
        private string _itemName;
        private int? _quantity;
        private DateTime _expiryDate;

        public int? ItemId
        {
            get => _itemId;
            set
            {
                if (_itemId != value)
                {
                    _itemId = value;
                    OnPropertyChanged(nameof(ItemId));
                }
            }
        }

        public string ItemName
        {
            get => _itemName;
            set
            {
                if (_itemName != value)
                {
                    _itemName = value;
                    OnPropertyChanged(nameof(ItemName));
                }
            }
        }

        public int? Quantity
        {
            get => _quantity;
            set
            {
                if (_quantity != value)
                {
                    _quantity = value;
                    OnPropertyChanged(nameof(Quantity));
                }
            }
        }

        public DateTime ExpiryDate
        {
            get => _expiryDate;
            set
            {
                if (_expiryDate != value)
                {
                    _expiryDate = value;
                    OnPropertyChanged(nameof(ExpiryDate));
                }
            }
        }

        public InventoryItems()
        {
            _itemName = string.Empty;
            _expiryDate = DateTime.Now.AddYears(1);
            _quantity = 0;
            _itemId = 0;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}