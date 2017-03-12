using System;

namespace Hex.WinApp
{
    internal interface IDiscountView
    {
        void ReadValues();
        void DisplayError(string message);
    }
}
