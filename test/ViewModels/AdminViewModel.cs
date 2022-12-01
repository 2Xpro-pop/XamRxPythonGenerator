using System;
using System.Collections.Generic;
using System.Text;
using ReactiveUI;
using Xamarin.Forms;

namespace TestSharp.Hi.ViewModels
{
    public class AdminViewModel: ReactiveObject
    {
        [Reactive] public string RxText { get; set; }

        public AdminViewModel()
        {
            RxText = "Fody & RxUI ♡!"
        }
    }
}
